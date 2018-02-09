using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_InPractice.SortingAlgorithms
{
    public static class BubbleSort
    {
        public static void sort()
        {
            int[] unsorted = new int[] { 1, 33, 4,2, 5,76,23,76, 89,34,23,54,898,23,53453,0,099, -0999, -032222,-222222,-55555555, 8888888};

            for (int i = 0; i < unsorted.Length; i++)
            {
                for (int j = 1; j < unsorted.Length; j++)
                {
                    int temp = 0;
                    if(unsorted[j-1] > unsorted[j])
                    {
                        temp = unsorted[j];
                        unsorted[j] = unsorted[j-1];
                        unsorted[j-1] = temp;
                    }
                }
            }
            Console.WriteLine("Bubble Sorted Array: ");
            foreach (var item in unsorted)
            {
                Console.WriteLine(item.ToString());
            }
            
        }

    }
}
