using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_program
{
    internal class GC
    {
        public void ListHandling()
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(200);
            numbers.Add(130);
            numbers.Add(66);
            numbers.Add(55);
            numbers.Add(1234);



            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.Reverse();

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.RemoveAt(2);

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Sort();
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Clear();
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(numbers.Contains(1234));
            Console.WriteLine(numbers.IndexOf(200));
        }


        public void StackHandling()
        {
            Stack<string> nam = new Stack<string>();
            nam.Push("a");
            nam.Push("b");
            nam.Push("c");
            nam.Push("d");


            foreach (var item in nam)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(nam.Pop());

            foreach (var item in nam)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(nam.Peek());
            foreach (var item in nam)
            {
                Console.WriteLine(item);
            }
        }
        public void Dicthandling()
        {
            Dictionary<int,string> dict= new Dictionary<int,string>();
            dict.Add(1, "10");
            dict.Add(2, "20");
            dict.Add(3, "30");
            dict.Add(5, "aa");
            dict.Add(4, "bb");

            foreach (int item in dict.Keys)
            {
                Console.WriteLine(item);
            }

            dict.Remove(3);
            foreach (int item in dict.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(dict.ContainsKey(6));

            foreach (int item in dict.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (int item in dict.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Count:" + dict.Count);
        }




    }
}

