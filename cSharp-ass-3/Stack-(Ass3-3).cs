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
// -----------------------------------------------------------------------

using System;

namespace CustomStackExample
{
    class Stack
    {
        private int[] stackArray; // Array to store stack elements
        private int top; // Points to the top of the stack
        private int size; // Maximum size of the stack

        public Stack(int size)
        {
            this.size = size;
            stackArray = new int[size];
            top = -1; // Stack is initially empty
        }

        public void Push(int element)
        {
            if (top == size - 1)
            {
                Console.WriteLine("Stack Overflow! Cannot push more elements.");
                return;
            }
            stackArray[++top] = element;
            Console.WriteLine($"Pushed {element} into the stack.");
        }

        public void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow! No elements to pop.");
                return;
            }
            Console.WriteLine($"Popped {stackArray[top]} from the stack.");
            top--;
        }

        public void Display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Console.WriteLine("Stack elements are:");
            for (int i = top; i >= 0; i--)
            {
                Console.Write(stackArray[i] + " <- ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter the size of the stack: ");
            int size = int.Parse(Console.ReadLine());

            Stack stack = new Stack(size);

            while (true)
            {
                Console.WriteLine("\n1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter element to push: ");
                        int ele = int.Parse(Console.ReadLine());
                        stack.Push(ele);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        stack.Display();
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

