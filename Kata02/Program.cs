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
        public delegate int MyDelegate(int t, int[] arr);
        static void Main(string[] args)
        {
            MyDelegate chop = FindInArray;

            int[] array1 = new int[0];
            int[] array2 = { 1 };
            int[] array3 = { 1, 3, 5 };
            int[] array4 = { 1, 3, 5, 7 };
            int[] array5 = new int[0];

            assert_equal(-1, chop(3, array1));
            assert_equal(-1, chop(3, array2));
            assert_equal(0, chop(1, array2));
            assert_equal(0, chop(1, array3));
            assert_equal(1, chop(3, array3));
            assert_equal(2, chop(5, array3));
            assert_equal(-1, chop(0, array3));
            assert_equal(-1, chop(2, array3));
            assert_equal(-1, chop(4, array3));
            assert_equal(-1, chop(6, array3));
            assert_equal(0, chop(1, array4));
            assert_equal(1, chop(3, array4));
            assert_equal(2, chop(5, array4));
            assert_equal(3, chop(7, array4));
            assert_equal(-1, chop(0, array4));
            assert_equal(-1, chop(2, array4));
            assert_equal(-1, chop(4, array4));
            assert_equal(-1, chop(6, array4));
            assert_equal(3, chop(7, array4));
            Console.ReadLine();
        }

        private static void assert_equal(int value, int target)
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
