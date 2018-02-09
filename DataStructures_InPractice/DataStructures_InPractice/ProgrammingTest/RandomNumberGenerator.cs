using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_InPractice.ProgrammingTest
{
    public static class RandomNumberGenerator
    {
        public static void process()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append(rnd.Next(1, 9));
            }
            Console.Write(sb);
        }
    }
}
