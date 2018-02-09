using System;
using System.Collections.Generic;

namespace DataStructures_InPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //ParathesisMatcher bc = new ParathesisMatcher();

            //if (bc.checkBrackets("{}"))
            //    Console.WriteLine("Brackets matched");
            //else
            //    Console.WriteLine("Brackets not matching");
            //Console.ReadKey();

            //****** ARRAY INTERSECTION ****////
            ArrayIntersection.printIntersection();
            ArrayIntersection.printUnion();

            ////****** GENERICS *******/////
            GenericsPractice.testArrayList();

            int[] a1 = new int[] { 34, 54, 65, 23, 54, -9, 0, 456 };
            int[] a2 = new int[] { 22, 24, 25, 34, 54 };

            //matching pairs problem
            ArrayProblem.getMatchingPairs(a1, 10);

            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());


            //Palindrome program
            Console.WriteLine(isPalidrome("Deleveled"));
            Console.WriteLine(isPalidrome("nitin"));
            Console.WriteLine(isPalidrome("3223"));

            //reverse
            a1 = reverse(a1);
            Console.WriteLine("reversed array:");
            for (int i = 0; i < a1.Length; i++)
                Console.Write(a1[i] + "\t");

            Console.WriteLine();
            Console.WriteLine();

            //compare two arrays
            checkArrayContainsMatch(a1, a2);
            Console.WriteLine("is Array Contains Matching Element: " + checkArrayContainsMatch(a1, a2));

            Console.WriteLine();

            int[] output = getMinMaxOfArray(a1);
            Console.WriteLine("MIN: " +output[0]);
            Console.WriteLine("MAX: " + output[1]);
            Console.ReadKey();
        }

        private static int[] getMinMaxOfArray(int[] a)
        {
            var min = 0;
            var max = 0;
            
            //using for loop
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];

                if (a[i] > max)
                    max = a[i];
            }

            //using while loop
            //int i = 0;
            //while (i < a.Length)
            //{
            //    if (a[i] < min)
            //    {
            //        min = a[i];
            //    }
            //    if (a[i] > max)
            //    {
            //        max = a[i];
            //    }
            //    i++;
            //}

            int[] output = new int[2];
            output[0] = min;
            output[1] = max;

            return output;
        }

        private static bool checkArrayContainsMatch(int[] a1, int[] a2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            var result = false;
            for (int i = 0; i < a2.Length; i++)
            {
                dic.Add(a2[i], a2[i]);
            }

            for (int i = 0; i < a1.Length; i++)
            {
                if (dic.ContainsKey(a1[i]))
                {
                    result = true;
                }
            }
            return result;
        }

        private static int[] reverse(int[] a)
        {
            int begin = 0;
            int end = a.Length - 1;
            int temp;

            while (begin < end)
            {
                temp = a[begin];
                a[begin] = a[end];
                a[end] = temp;

                begin++;
                end--;
            }
            return a;
        }

        private static bool isPalidrome(string word)
        {
            word = word.ToLower();
            char[] a = word.ToCharArray();
            int start = 0;
            int end = a.Length - 1;

            if (start > end)
            {
                return true;
            }

            while (start < end && start != end)
            {
                if(a[start] == a[end])
                {
                    start++;
                    end--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}