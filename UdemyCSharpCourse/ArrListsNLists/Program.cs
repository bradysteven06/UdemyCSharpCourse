using System.Collections;

namespace ArrListsNLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList

            // declaring an ArrayList with undefined amount of objects
            ArrayList myArrayList = new ArrayList();
            // declaring an ArrayList with defined amount of objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            // delete element with specific value from the arraylist
            myArrayList.Remove(13);
            myArrayList.Remove(13);

            // delete element at specific position
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is double)
                {
                    sum += (double)obj;
                }
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);
            #endregion


            #region List

            List<int> numbers = new List<int>();

            for (int i = 100; i <= 170; i += 2)
            {
                numbers.Add(i);
            }

            Console.WriteLine(numbers.Count);
            int counter = 0;
            foreach(int i in numbers)
            {
                Console.Write("{0} ", i);
                counter++;
                if(counter % 5 == 0)
                {
                    Console.WriteLine();
                }
            }

            #endregion

            Console.ReadLine();
        }
    }
}