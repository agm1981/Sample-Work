using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Kata02
{
    class Program
    {
        /// <summary>
        /// Using Delegates just for fun.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public delegate int CustomDelegate(int t, int[] arr);

        static void Main(string[] args)
        {
            CustomDelegate findInArrayDelegated = FindInArray;

            findInArrayDelegated += FindInArray;
            findInArrayDelegated += FindInArray;
            findInArrayDelegated += FindInArray;


            int[] array1 = new int[0];
            int[] array2 = { 1 };
            int[] array3 = { 1, 3, 5 };
            int[] array4 = { 1, 3, 5, 7 };
            int[] array5 = new int[0];

            AreEqual(-1, findInArrayDelegated(3, array1));
            //AreEqual(-1, findInArrayDelegated(3, array2));
            //AreEqual(0, findInArrayDelegated(1, array2));
            //AreEqual(0, findInArrayDelegated(1, array3));
            //AreEqual(1, findInArrayDelegated(3, array3));
            //AreEqual(2, findInArrayDelegated(5, array3));
            //AreEqual(-1, findInArrayDelegated(0, array3));
            //AreEqual(-1, findInArrayDelegated(2, array3));
            //AreEqual(-1, findInArrayDelegated(4, array3));
            //AreEqual(-1, findInArrayDelegated(6, array3));
            //AreEqual(0, findInArrayDelegated(1, array4));
            //AreEqual(1, findInArrayDelegated(3, array4));
            //AreEqual(2, findInArrayDelegated(5, array4));
            //AreEqual(3, findInArrayDelegated(7, array4));
            //AreEqual(-1, findInArrayDelegated(0, array4));
            //AreEqual(-1, findInArrayDelegated(2, array4));
            //AreEqual(-1, findInArrayDelegated(4, array4));
            //AreEqual(-1, findInArrayDelegated(6, array4));
            //AreEqual(3, findInArrayDelegated(7, array4));
            Console.ReadLine();
        }

        private static void AreEqual(int value, int target)
        {
            if (value != target)
                throw new Exception();
            Console.WriteLine("Found {0} at {1}", value, target);

        }

        /// <summary>
        /// Assumptions is that the list is ordered.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public static int FindInArray(int target, int[] source)
        {

            List<int> items = source.ToList();
            return items.FindIndex(x => x == target);



        }



    }

}
