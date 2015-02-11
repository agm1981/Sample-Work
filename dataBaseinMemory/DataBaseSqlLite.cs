using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace dataBaseinMemory
{
    /// <summary>
    /// This will be implemented like SQL, a permanet storage plus a temporary storage, the transactions
    /// </summary>
    public class DataBaseSqlLite : IDatabaseOperations, IDataBaseOperationsBasic
    {


        private readonly List<PendingTransactions> openTransactions;

        public DataBaseSqlLite()
        {

            openTransactions = new List<PendingTransactions>
                               {
                                   new PendingTransactions(1)
                               };
        }

        public string Get(string variableName)
        {
            string variableNameLowerCase = variableName.ToLowerInvariant();
            string value = openTransactions.Where(x => x.Peek(variableNameLowerCase)).OrderByDescending(x => x.TransactionId).Select(transactions => transactions.Get(variableNameLowerCase)).FirstOrDefault();
            return value ?? "NULL";
        }

        public void Set(string variableName, string value)
        {
            string variableNameLowerCase = variableName.ToLowerInvariant();
            PendingTransactions transactions = GetTopMostTransaction();
            transactions.Set(variableNameLowerCase, value);
        }

        public void UnSet(string variableName)
        {
            string variableNameLowerCase = variableName.ToLowerInvariant();
            PendingTransactions transactions = GetTopMostTransaction();
            transactions.UnSet(variableNameLowerCase);
        }


        public int NumEqualTo(string value)
        {
            List<string> variables = new List<string>();
            foreach (PendingTransactions transactions in openTransactions)
            {
                variables.AddRange(transactions.FindByValue(value));
            }
            //we have to check for vaiables been null. those mess things up.
            //so well check that the last value on any transaction is not null
            List<string> variablesToCheck = variables.Distinct(new PendingTransactionsComparerByName()).ToList();
            List<string> variablesToRemove = new List<string>();
            foreach (string variableName in variablesToCheck.Where(variableName => Get(variableName) == "NULL"))
            {
                variablesToRemove.Add(variableName);
            }
            variablesToCheck = variablesToCheck.Where(x => !variablesToRemove.Contains(x)).ToList();
            return variablesToCheck.Count();
        }

        public void End()
        {
            foreach (PendingTransactions transactions in openTransactions)
            {
                transactions.Clear();
            }
            openTransactions.Clear();

        }

        public void Begin()
        {
            long lstId = openTransactions.Max(x => x.TransactionId);
            openTransactions.Add(new PendingTransactions(lstId + 1));
        }

        public string RollBack()
        {
            if (openTransactions.Count <= 1)
            {
                return "NO TRANSACTION";
            }
            openTransactions.Remove(GetTopMostTransaction());
            return string.Empty;
        }
        /// <summary>
        /// This will work as a way of flatting the transactions. 
        /// It will basicaly fold one by one and flat out all the transactions all the way to transaction Id 1.
        /// </summary>
        /// <returns></returns>
        public string Commit()
        {
            if (GetTopMostTransaction().TransactionId == 1)
                return "NO TRANSACTION";
            FlatTransactionsRecursive();
            return string.Empty;
        }

        private PendingTransactions GetTopMostTransaction()
        {
            return openTransactions.OrderByDescending(x => x.TransactionId).First();
        }

        private void FlatTransactionsRecursive()
        {
            if (GetTopMostTransaction().TransactionId == 1)
                return;
            FlatTransactions(GetTopMostTransaction(), openTransactions.OrderByDescending(x => x.TransactionId).Skip(1).First());
            openTransactions.Remove(GetTopMostTransaction());
            FlatTransactionsRecursive();
        }

        private void FlatTransactions(PendingTransactions sourceTransaction, PendingTransactions targetTransaction)
        {
            foreach (KeyValuePair<string, string> value in sourceTransaction.GetEnumerator())
            {
                targetTransaction.Set(value.Key, value.Value);
            }
        }


        private class PendingTransactions : IDataBaseOperationsBasic
        {
            private readonly Dictionary<string, string> dataStore;

            public void Clear()
            {
                dataStore.Clear();
            }
            public PendingTransactions(long tranId)
            {
                TransactionId = tranId;
                dataStore = new Dictionary<string, string>();
            }
            public long TransactionId
            {
                get;
                private set;
            }

            public IEnumerable GetEnumerator()
            {

                return dataStore.AsEnumerable();
            }

            public string Get(string variableName)
            {
                string variableNameLowerCase = variableName.ToLowerInvariant();
                return dataStore.ContainsKey(variableNameLowerCase) ? dataStore[variableNameLowerCase] : null;
            }

            public void Set(string variableName, string value)
            {
                string variableNameLowerCase = variableName.ToLowerInvariant();
                if (dataStore.ContainsKey(variableNameLowerCase))
                {
                    dataStore[variableNameLowerCase] = value;
                }
                else
                {
                    dataStore.Add(variableNameLowerCase, value);
                }
            }

            public void UnSet(string variableName)
            {
                string variableNameLowerCase = variableName.ToLowerInvariant();
                if (dataStore.ContainsKey(variableNameLowerCase))
                {
                    dataStore[variableNameLowerCase] = null;
                }
                else
                {
                    dataStore.Add(variableNameLowerCase, null);
                }
            }

            public int NumEqualTo(string value)
            {
                return dataStore.Count(x => x.Value == value);
            }

            public bool Peek(string variableName)
            {
                string variableNameLowerCase = variableName.ToLowerInvariant();
                return dataStore.ContainsKey(variableNameLowerCase);
            }

            public IEnumerable<string> FindByValue(string value)
            {
                return dataStore.Where(x => x.Value == value).Select(y=>y.Key);
            }
        }

        private class PendingTransactionsComparerByName : IEqualityComparer<string>
        {
            public bool Equals(string x, string y)
            {
                return x.Equals(y, StringComparison.InvariantCultureIgnoreCase);
            }

            public int GetHashCode(string obj)
            {
                unchecked
                {
                    int hashA = 113;
                    const int hashB = 213;
                    hashA = hashA * hashB + obj.GetHashCode();
                    return hashA;
                }
            }
        }
    }
}
