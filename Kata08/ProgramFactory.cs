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
    class ProgramFactory
    {
        private static List<string> dictionary;

        public static void OldMain(string[] args)
        {
            


            FillWords(out dictionary);
            CollectionFactory factory = new CollectionFactory();
            ICollectionFinder coll = factory.FactoryMethod(dictionary);

            ICollection splittedCollection = coll.GetSplittedCollection(dictionary, 6);

            foreach (string elements in from object value in splittedCollection select value as string)
            {
                Console.WriteLine(elements);
            }
            Console.ReadLine();
        }


        private static void FillWords(out List<string> values)
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


   
    }
}
