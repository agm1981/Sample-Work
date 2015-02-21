using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Kata08
{

    public class StringCollectionFinder<T> : ICollectionFinder<T>
    {

        public ICollection GetSplittedCollection(IEnumerable colToSplit, DoesWordBelongInOutput<T> comparerFunction)
        {
           
            //if (colToSplit.GetType() != typeof(IEnumerable<string>))// &&
            ////    colToSplit.GetType() != typeof(List<string>) 
            ////    )
            //{
            //    throw new InvalidOperationException("This type can not process this collection");
            //}

            HashSet<T> wordsOfSix = new HashSet<T>();

            HashSet<T> wordsLessThanSix = new HashSet<T>();
            List<T> finalList = new List<T>();
            //List<string> wordsOfSixOrUnder = new List<string>();
            List<T> allWords = colToSplit as List<T>;
            if (allWords == null ||
                !allWords.Any())
            {
                return new List<T>();
            }
            //foreach (T word in allWords.Where(x => x.Length == maxNumberOfChars))
            //{
            //    wordsOfSix.Add(word);
            //}

            //foreach (string word in allWords.Where(x => x.Length < maxNumberOfChars))
            //{
            //    wordsLessThanSix.Add(word);
            //}
            //wordsLessThanSix. AddRange(allWords.Where(x => x.Length < maxNumberOfChars)).;

            //foreach ( string word in allWords)//.Where(x=>x.Length <= maxNumberOfChars ))
            //{
            //    if (word.Length == maxNumberOfChars)
            //    {
            //        wordsOfSix.Add(word);
            //    }
            //    if (word.Length < maxNumberOfChars)
            //    {
            //        wordsLessThanSix.Add(word);
            //    }
            //}


            foreach (T fullword in wordsOfSix)
            {
                if (comparerFunction(fullword, wordsLessThanSix))
                {
                    finalList.Add(fullword);
                }
                
            }
            return finalList;
        }

        
    }
}
