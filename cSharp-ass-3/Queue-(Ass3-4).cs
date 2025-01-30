//4)	To implement the following operations on a Queue
//    i)	 Add an Element
//    ii)	 Delete an Element
//    iii)	 Display the contents of the queue 


using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_3
{
    class Queue
    {
        static void enQueue(Queue<int> queue)
        {
            Console.Write("Enter the element you want to add to the queue: ");
            int ele = int.Parse(Console.ReadLine());

            queue.Enqueue(ele);
        }

        static void deQueue(Queue<int> queue)
        {
            queue.Dequeue();
        }

        static void displayQueue(Queue<int> queue)
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Empty queue");
                return;
            }

            foreach (int q in queue)
            {
                Console.Write(q + "<-");
            }
        }

        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            while (true)
            {
                Console.WriteLine("\n1. Push.");
                Console.WriteLine("2. Pop.");
                Console.WriteLine("3. Display.");
                Console.WriteLine("4. Exit.");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        enQueue(queue);
                        break;

                    case 2:
                        deQueue(queue);
                        break;

                    case 3:
                        displayQueue(queue);
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
            }
        
        }
    }
}
