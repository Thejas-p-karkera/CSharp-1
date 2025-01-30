//3)	To implement a Stack and to perform Push and Pop operations.

using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_3
{
    class Stack
    {
        static void pushStack(Stack<int> stack)
        {
            Console.Write("Enter the element you want to push into stack: ");
            int ele = int.Parse(Console.ReadLine());

            stack.Push(ele);
        }

        static void popStack(Stack<int> stack)
        {
            stack.Pop();
        }

        static void displayStack(Stack<int> stack)
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Empty stack");
                return;
            }

            Console.WriteLine("Stack elements are:");

            foreach (int st in stack)
            {
                Console.Write(st + "<-");
            }
            Console.WriteLine("NULL");
            
        }

        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

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
                        pushStack(stack);
                        break;

                    case 2:
                        popStack(stack);
                        break;

                    case 3:
                        displayStack(stack);
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
