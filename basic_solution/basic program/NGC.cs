using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace basic_program
{
    internal class NGC
    {
        public void ArrayListHandling()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);

            /*  for(int i = 0; i < arrayList.Count; i++) 
              {
                  Console.WriteLine(arrayList[i]);
              }*/

            /*foreach (var item in arrayList) 
            {
                Console.WriteLine(item);
              } */
            arrayList.Add("aa");
            arrayList.Add(true);
            arrayList.Add(false);


            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            arrayList.Reverse();

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.RemoveAt(2);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }

        public void StackHandling()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push("abd");
            stack.Push(25);
            stack.Push(100);


            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(stack.Pop());

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }





        }

        public void QueueHandling()
        {
            Queue qu = new Queue();
            qu.Enqueue(10);
            qu.Enqueue(20);
            qu.Enqueue(30);
            qu.Enqueue(40);


            foreach (var item in qu)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(qu.Dequeue());

            foreach (var item in qu)
            {
                Console.WriteLine(item);
            }

        }
        public void HashTablehandling()
        {
            Hashtable h = new Hashtable();
            h.Add(1, 10);
            h.Add(2, 20);
            h.Add(3, 30);
            h.Add("3", "aaa");
            h.Add(4, "bb");

            foreach (var item in h)
            {
                Console.WriteLine(item);
            }

            h.Remove(3);
            foreach (var item in h)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(h.ContainsKey("6"));
            foreach (var item in h.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in h.Values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Count:" + h.Count);
        }

        public void SLHandling()
        {
            SortedList sl=new SortedList();
            sl.Add(3, 30);
            sl.Add(4, "aa");
            sl.Add(1, 10);
            sl.Add(2, 20);

            foreach(var item in sl)
            {
                Console.WriteLine(item);
            }
         
        }









        }

    }


