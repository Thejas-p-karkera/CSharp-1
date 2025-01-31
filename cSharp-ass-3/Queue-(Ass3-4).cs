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

// ----------------------------------------------------------------------------------

using System;

namespace CustomQueueExample
{
    class Queue
    {
        private int[] queueArray; // Array to store queue elements
        private int front; // Points to the front of the queue
        private int rear; // Points to the rear of the queue
        private int size; // Maximum size of the queue

        public Queue(int size)
        {
            this.size = size;
            queueArray = new int[size];
            front = -1; // Queue is initially empty
            rear = -1;
        }

        public void Enqueue(int element)
        {
            if (rear == size - 1)
            {
                Console.WriteLine("Queue Overflow! Cannot add more elements.");
                return;
            }
            if (front == -1) front = 0; // Set front if it's the first element
            queueArray[++rear] = element;
            Console.WriteLine($"Added {element} to the queue.");
        }

        public void Dequeue()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Queue Underflow! No elements to delete.");
                return;
            }
            Console.WriteLine($"Deleted {queueArray[front]} from the queue.");
            front++; // Move front forward
        }

        public void Display()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Console.WriteLine("Queue elements are:");
            for (int i = front; i <= rear; i++)
            {
                Console.Write(queueArray[i] + " <- ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter the size of the queue: ");
            int size = int.Parse(Console.ReadLine());

            Queue queue = new Queue(size);

            while (true)
            {
                Console.WriteLine("\n1. Add (Enqueue)");
                Console.WriteLine("2. Delete (Dequeue)");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter element to add: ");
                        int ele = int.Parse(Console.ReadLine());
                        queue.Enqueue(ele);
                        break;
                    case 2:
                        queue.Dequeue();
                        break;
                    case 3:
                        queue.Display();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Enter a valid choice.");
                        break;
                }
            }
        }
    }
}

