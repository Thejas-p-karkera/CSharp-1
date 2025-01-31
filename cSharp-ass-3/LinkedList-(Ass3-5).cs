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

// --------------------------------------------------------------------------------------------

using System;

namespace CustomLinkedListExample
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    class SinglyLinkedList
    {
        private Node head;

        public SinglyLinkedList()
        {
            head = null;
        }

        public void AddFront(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine($"{data} added at the front.");
        }

        public void AddBack(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine($"{data} added at the back.");
                return;
            }

            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
            Console.WriteLine($"{data} added at the back.");
        }

        public void DeleteNode(int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty. Cannot delete.");
                return;
            }

            if (head.data == data)
            {
                head = head.next;
                Console.WriteLine($"{data} deleted.");
                return;
            }

            Node temp = head;
            while (temp.next != null && temp.next.data != data)
            {
                temp = temp.next;
            }

            if (temp.next == null)
            {
                Console.WriteLine($"{data} not found in the list.");
                return;
            }

            temp.next = temp.next.next;
            Console.WriteLine($"{data} deleted.");
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty.");
                return;
            }

            Node temp = head;
            Console.WriteLine("Linked List elements are:");
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
            Console.WriteLine("NULL");
        }
    }

    class Program
    {
        static void Main()
        {
            SinglyLinkedList list = new SinglyLinkedList();

            while (true)
            {
                Console.WriteLine("\n1. Add a Node to the Front");
                Console.WriteLine("2. Add a Node to the Back");
                Console.WriteLine("3. Delete a specified Node");
                Console.WriteLine("4. Display the List");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter element to insert at the front: ");
                        int frontEle = int.Parse(Console.ReadLine());
                        list.AddFront(frontEle);
                        break;
                    case 2:
                        Console.Write("Enter element to insert at the back: ");
                        int backEle = int.Parse(Console.ReadLine());
                        list.AddBack(backEle);
                        break;
                    case 3:
                        Console.Write("Enter element to delete: ");
                        int delEle = int.Parse(Console.ReadLine());
                        list.DeleteNode(delEle);
                        break;
                    case 4:
                        list.Display();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Enter a valid choice.");
                        break;
                }
            }
        }
    }
}
