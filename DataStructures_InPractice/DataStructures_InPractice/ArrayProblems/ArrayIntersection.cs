using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures_InPractice
{
    public static class ArrayIntersection
    {
        public static void printIntersection()
        {
            int[] a = new int[] { 2, 4, 78, 43, 67, 67, 0, -9, 23 };
            int[] b = new int[] { 2, 44, 78, 99, 34, 43, 67 };
            List<int> intersect = new List<int>();

            var result = a.Intersect(b);   //using library function

            HashSet<int> hs = new HashSet<int>(a);

            for (int i = 0; i < b.Length; i++)
            {
                if(hs.Contains(b[i]))
                {
                    intersect.Add(b[i]);
                }
            }

            foreach (var item in intersect)
            {
                Console.WriteLine(item);
            }
        }

        public static void printUnion()
        {
            int[] a = new int[] { 2, 4, 78, 43, 67, 67, 0, -9, 23 };
            int[] b = new int[] { 2, 44, 78, 99, 34, 43, 67 };

            var result = a.Union(b);   //using library function

            Console.WriteLine("UNION USING LIBRARY FUNCTION");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            HashSet<int> hs = new HashSet<int>(a);   //Time Complexity O(1)

            //hs.RemoveWhere(x => x > 10);  remove element from HashSet with where condition
            //hs.remove(10)   // remove specific element

            for (int i = 0; i < b.Length; i++)      //Time Complexity O(n)
            {
                if (!hs.Contains(b[i]))
                {
                    hs.Add(b[i]);
                }
            }

            Console.WriteLine("UNION WITHOUT USING LIBRARY FUNCTION");

            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
