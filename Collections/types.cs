using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    internal class types
    {
        static void Main()
        {
            // ArrayList allows you to perform insertion deletion anywhere
            ArrayList list = new ArrayList();
            // collection > dynamic in nature, memory is not wasted
            list.Add(1);
            list.Add(2);
            list.Add(3);
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            list.Insert(0, 200);
            list.Insert(1, 300);

            Console.WriteLine("after insertion");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            list.Remove(1);
            list.RemoveAt(0);
            Console.WriteLine("after deletion");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            Stack stack = new Stack();
            stack.Push(1000);
            stack.Push(2000);
            stack.Push(3000);
            Console.WriteLine("stack");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }

            stack.Pop();
            Console.WriteLine("after deletion");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }

            Queue queue = new Queue();
            queue.Enqueue(1000);
            queue.Enqueue(2000);
            queue.Enqueue(3000);

            Console.WriteLine("Queue");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Dequeue();
            Console.WriteLine("after deletion");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

            //foreach (int item in queue)
            //{
            //    if(item==90)
            //    {

            //    }
            //}

            Hashtable ht = new Hashtable();
            ht[100] = "New Delhi";
            ht[190] = "Calcutta";
            ht[1] = "Delhi";
            ht["Ajay"] = "delhi";
            if (ht.ContainsKey(200))
            {
                Console.WriteLine("found");
            }

            Console.WriteLine(ht["Ajay"]);

            Console.WriteLine(ht[190]);

            foreach (int item in ht.Keys)
            {
                Console.WriteLine("Key " + item + " ==> " + ht[item]);
            }

        }
    }
}