using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Kata08
{

    /// <summary>
    /// Program for the cration of a pair of words where criteria is simple
    /// If exists on the dictionay word C where word A concat B = C
    /// then display A + B => C
    /// </summary>
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Starting the process... Please wait.");
            ProgramFactory.OldMain(args);
        }



        //private class WorkClass
        //{
        //    private readonly List<string> allWords;
        //    private readonly List<string> wordsOfSix;
        //    private readonly List<string> wordsLessThanSix;

        //    //output this to verify it
        //    public WorkClass()
        //    {
        //        allWords = new List<string>();
        //        wordsOfSix = new List<string>();
        //        wordsLessThanSix = new List<string>();

        //    }
        //    public void FillWords()
        //    {
        //        using (StreamReader sr = new StreamReader("dictio.txt"))
        //        {
        //            while (!sr.EndOfStream)
        //            {
        //                String line = sr.ReadLine();
        //                if (!string.IsNullOrEmpty(line) &&
        //                    !string.IsNullOrWhiteSpace(line))
        //                {
        //                    allWords.Add(line);
        //                }
        //            }
        //        }
        //        wordsOfSix.AddRange(allWords.Where(x => x.Length == 6));
        //        wordsLessThanSix.AddRange(allWords.Where(x => x.Length < 6));
        //    }

        //    public void Output()
        //    {
        //        Console.WriteLine("Total words loaded {0}",allWords.Count);
        //    }

        //    public void FindConcatenatedWords()
        //    {
        //        //we are going the route of instead of looping until we find aresult that matches.
        //        //we start from the knowing matcehs and work our way backwards
        //        //we just have to check wordsOfSix * 5 since the number of max combinations is 5
        //        foreach (string fullword in wordsOfSix)
        //        {
        //            for (int i = 1; i < 6; i++)
        //            {
        //                string a = fullword.Substring(0, i);
        //                string b = fullword.Substring(i, 6 - i);
        //                if (wordsLessThanSix.Any(x => x == a) &&
        //                    wordsLessThanSix.Any(x => x == b) )
        //                {
        //                    Console.WriteLine("{0} + {1} => {2}", a, b, fullword);
        //                    i=7;// exit the loop
        //                }
        //            }
        //        }


        //    }

            
        //}
    }
}
