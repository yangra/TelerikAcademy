using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericListTest
    {
        static void Main()
        {
            Random rnd = new Random();
            GenericList<int> list = new GenericList<int>(208);
            Console.WriteLine("Create list with capacity 208");
            Console.WriteLine(list);
            Console.WriteLine("Count: {0}", list.Count);
            Console.WriteLine("Capacity: {0}", list.Capacity);
            Console.WriteLine("Add 5 random elements");
            for (int i = 0; i < 5; i++)
            {
                list.Add(rnd.Next(-647,655));
            }
            Console.WriteLine(list);
            Console.WriteLine("Count: {0}", list.Count);
            Console.WriteLine("Capacity: {0}", list.Capacity);
            list.InsertAt(1, 6);
            Console.WriteLine("Add 6 at index 1");
            Console.WriteLine(list);
            Console.WriteLine("Count: {0}", list.Count);
            Console.WriteLine("Capacity: {0}", list.Capacity);
            list.RemoveAt(2);
            Console.WriteLine("Remove at index 2");
            Console.WriteLine(list);
            Console.WriteLine("Count: {0}", list.Count);
            Console.WriteLine("Capacity: {0}", list.Capacity);
            Console.WriteLine("Max: {0}", list.Max());
            Console.WriteLine("Min: {0}", list.Min());
            int index6 = list.Find(6);
            Console.WriteLine("Find index of 6");
            Console.WriteLine("Index: {0}", index6);
            list.Clear();
            Console.WriteLine("Clear list");
            Console.WriteLine(list);
            Console.WriteLine("Count: {0}", list.Count);
            Console.WriteLine("Capacity: {0}", list.Capacity);
        }
    }
}
