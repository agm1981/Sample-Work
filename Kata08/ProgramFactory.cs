using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Schema;

namespace Kata08
{

    /// <summary>
    /// Program for the cration of a pair of words where criteria is simple
    /// If exists on the dictionay word C where word A concat B = C
    /// then display A + B => C
    /// </summary>
    public static class ProgramFactory
    {
        private static List<string> dictionary;

        public static void OldMain(string[] args)
        {
            


            FillWords(out dictionary);
            CollectionFactory<string> factory = new CollectionFactory<string>();
            ICollectionFinder<string> coll = factory.FactoryMethod(dictionary);

            ICollection splittedCollection = coll.GetSplittedCollection(dictionary, WordBelongs);

            foreach (string elements in from object value in splittedCollection select value as string)
            {
                Console.WriteLine(elements);
            }
            Console.ReadLine();
        }


        public static void FillWords(out List<string> values)
        {
            values = new List<string>();
            using (StreamReader sr = new StreamReader("dictio.txt"))
            {
                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();
                    if (!string.IsNullOrEmpty(line) &&
                        !string.IsNullOrWhiteSpace(line))
                    {
                        values.Add(line);
                    }
                }
            }
        }

        public static bool WordBelongs(string word, HashSet<string> collectionToSearchOn)
        {
            for (int i = 1; i < word.Length; i++)
            {
                string a = word.Substring(0, i);
                string b = word.Substring(i, word.Length - i);
                if (collectionToSearchOn.Contains(a) &&
                    collectionToSearchOn.Contains(b))
                {
                    return true;
                }
            }
            return false;
        }
   
    }
}
