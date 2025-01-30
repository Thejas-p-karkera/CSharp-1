//5)	 To implement the following on a Singly Linked list
//    i)	    Create a List
//    ii)	    Add a Node to the Front of a list
//    iii)	Add a Node to the Back of a List
//    iv)	    Delete a specified Node
//    v)	    Display a list


using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_3
{
    class LinkedList
    {
        static void addFront(LinkedList<int> linkedList)
        {
            Console.Write("Enter the element to insert at front of the list: ");
            int ele = int.Parse(Console.ReadLine());

            linkedList.AddFirst(ele);
        }

        static void addBack(LinkedList<int> linkedList)
        {
            Console.Write("Enter the element to insert at Back of the list: ");
            int ele = int.Parse(Console.ReadLine());

            linkedList.AddLast(ele);
        }

        static void deleteANode(LinkedList<int> linkedList)
        {
            Console.Write("Enter the element you want to delete from the list: ");
            int ele = int.Parse(Console.ReadLine());

            if (linkedList.Contains(ele))
            {
                linkedList.Remove(ele);
            }
            else
            {
                Console.WriteLine(ele+" deos not found in the list.");
            }
        }

        static void displayList(LinkedList<int> linkedList)
        {
            if (linkedList.Count == 0)
            {
                Console.WriteLine("Empty Linked List");
                return;
            }

            Console.WriteLine("Linked List elements are:");

            foreach (int ll in linkedList)
            {
                Console.Write(ll + "<-");
            }
            Console.WriteLine("NULL");

        }

        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            while (true)
            {
                Console.WriteLine("\n1. Add a Node to the Front of the list.");
                Console.WriteLine("2. Add a Node to the Back of the List.");
                Console.WriteLine("3. Delete a specified Node.");
                Console.WriteLine("4. Display the list.");
                Console.WriteLine("5. Exit.");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addFront(linkedList);
                        break;

                    case 2:
                        addBack(linkedList);
                        break;

                    case 3:
                        deleteANode(linkedList);
                        break;

                    case 4:
                        displayList(linkedList);
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
            }
        }
    }
}
