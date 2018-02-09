using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_InPractice
{
   public static class ArrayProblem
    {
        public static void getMatchingPairs(int[] a, int sum)
        {
            LinkedList<int> ll = new LinkedList<int>();
                
                //sum : 15
            //matching pairs: [14, 1], [12, 3], [0, 15], [20, -5]
            int noOfMatchingPairs = 0;
            //a = new int[] { 1, 14, 12, 3, 0, 15, 20, -5};
            a = new int[] { 1,4,5,6,4,3,2,4,-6,7,4,1,3, 16 };

            //using for loops

            //for (int i = 0; i < a.Length; i++)
            //{
            //    for (int j = i+1; j < a.Length; j++)
            //    {
            //        if ((a[i] + a[j]) == sum) noOfMatchingPairs += 1;
            //        else continue;
            //    }
            //}

            //without using for loop
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if(!dic.ContainsKey(a[i]))
                    dic.Add(a[i], a[i]);
            }

            int remaining = 0;
            for (int i = 0; i < a.Length; i++)
            {
                remaining = sum - a[i];
                if (dic.ContainsKey(remaining)) noOfMatchingPairs += 1;
                else continue;
            }

            Console.WriteLine("No. of matching pairs:" + noOfMatchingPairs/2);

          
        }
    
    }
}
