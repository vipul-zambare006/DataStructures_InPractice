using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_InPractice
{
    public static class GenericsPractice
    {
        public static void testArrayList()
        {
            ArrayList al = new ArrayList();
            al.Add("string");
            al.Add("string");
            al.Add(1);
            al.Add(true);

            var alEnumerator = al.GetEnumerator();

            while (alEnumerator.MoveNext())
            {
                Console.WriteLine(alEnumerator.Current.ToString());
            }

            StudyStack();
        }

        private static void StudyStack()
        {
            int[] iArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Define a stack
            Stack sObj = new Stack(iArray);

            Console.WriteLine("Total items=" + sObj.Count);

            //displaying collections
            for (int i = 0; i < sObj.Count; ++i)
            {
                Console.WriteLine(sObj.Pop());
            }

            Console.ReadKey();
        }

        public static void studyKeyValuePair()
        {
            //Dictionary < (Of < (TKey, TValue >)>) -Represents a collection of keys and values
            //KeyValuePair < (Of < (TKey, TValue >)>) -Defines a key/ value pair that can be set or retrieved.

            Dictionary<int, String> student = new Dictionary<int, string>();

            student.Add(1, "Vipul");
            student.Add(2, "Sujit");
            student.Add(3, "Jay");
            student.Add(4, "Dhruv");
            student.Add(5, "Akash");

            //Usage of KeyValue Pair
            foreach (KeyValuePair<int, string> item in student)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }

        public static void studyIqueryable()
        {
            IQueryable<Car> cars = null;
            IEnumerable<Car> carIE = null;
            
            //carIE.    
            //cars.All(x => x.Name != null);
            //cars.
        }
    }
}

public class Car
{
    public int id { get; set; }
    public string Name { get; set; }

    public string getCarDetails()
    {
        return id + " " + Name;
    }
}

