using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Kata08
{

    class StringCollectionFinder : ICollectionFinder
    {
        
        public ICollection GetSplittedCollection(ICollection colToSplit, int maxNumberOfChars)
        {

            if (colToSplit.GetType() != typeof(IEnumerable<string>) &&
                colToSplit.GetType() != typeof(List<string>) 
                )
            {
                throw new InvalidOperationException("This class can not process this collection");
            }
            
            List<string> wordsOfSix = new List<string>();
            List<string> wordsLessThanSix = new List<string>();
            List<string> finalList = new List<string>();

            List<string> allWords = colToSplit as List<String>;
            if (allWords == null ||
                !allWords.Any())
            {
                return new List<string>();
            }

            wordsOfSix.AddRange(allWords.Where(x => x.Length == maxNumberOfChars));
            wordsLessThanSix.AddRange(allWords.Where(x => x.Length < maxNumberOfChars));
            foreach (string fullword in wordsOfSix)
            {
                for (int i = 1; i < maxNumberOfChars; i++)
                {
                    string a = fullword.Substring(0, i);
                    string b = fullword.Substring(i, maxNumberOfChars - i);
                    if (wordsLessThanSix.Any(x => x == a) &&
                        wordsLessThanSix.Any(x => x == b))
                    {
                        //Console.WriteLine("{0} + {1} => {2}", a, b, fullword);
                        finalList.Add(fullword);
                        i = 7;// exit the loop
                    }
                }
            }
            return finalList;
        }


        

    }
}
