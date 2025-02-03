using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_programs
{
    using System;

    interface Book
    {
        void GetBook();
        void Calculate();
        void DisplayBook();
        void Discount();
    }

    interface Cassette
    {
        void GetCassette();
        void Calculate();
        void DisplayCassette();
        double Commission();
    }

    class Media : Book, Cassette
    {
        public int itno;
        public string title, author, singer;
        public int nopages, duration;
        public double price;

        public void GetBook()
        {
            Console.Write("Enter Book ID: ");
            itno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book Title: ");
            title = Console.ReadLine();

            Console.Write("Enter Author Name: ");
            author = Console.ReadLine();

            Console.Write("Enter Number of Pages: ");
            nopages = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Price: ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        public void GetCassette()
        {
            Console.Write("Enter Cassette ID: ");
            itno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Cassette Title: ");
            title = Console.ReadLine();

            Console.Write("Enter Singer Name: ");
            singer = Console.ReadLine();

            Console.Write("Enter Duration (minutes): ");
            duration = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Price: ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        public void Calculate()
        {
            if (nopages > 0) // Identifying book
            {
                price += price * 0.05; // Increase price by 5%
            }
            else if (duration > 0) // Identifying cassette
            {
                price += price * 0.04; // Increase price by 4%
            }
        }

        public void DisplayBook()
        {
            Console.WriteLine("\nBook Details:");
            Console.WriteLine("ID: " + itno );
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author );
            Console.WriteLine("Pages: " + nopages);
            Console.WriteLine("Price: " + price);
        }

        public void DisplayCassette()
        {
            Console.WriteLine("\nCassette Details:");
            Console.WriteLine("ID: " + itno + ", Title: " + title + ", Singer: " + singer + ", Duration: " + duration + " minutes, Price: " + price);
        }

        public void Discount()
        {
            price -= price * 0.02; // Reduce price by 2%
        }

        public double Commission()
        {
            return price * 0.03; // Return 3% of price
        }
    }

    class Test
    {
        public static void SellBook(Media obj)
        {
            Book b = obj;
            b.GetBook();
            b.Calculate();
            b.Discount();
            b.DisplayBook();
        }

        public static void SellCassette(Media obj)
        {
            Cassette c = obj;
            c.GetCassette();
            c.Calculate();
            Console.WriteLine("Commission: " + c.Commission());
            c.DisplayCassette();
        }

        public static void Main()
        {
            Media obj = new Media();

            Console.WriteLine("1. Sell Book");
            Console.WriteLine("2. Sell Cassette");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                SellBook(obj);
            }
            else if (choice == 2)
            {
                SellCassette(obj);
            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            }
        }
    }

}



