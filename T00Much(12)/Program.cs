using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much_12_
{

    class Book
    {
        public string author;
        public string title;
        public string publishing;
        public Book(string author, string title, string publishing, BookMassive bc)
        {
            this.author = author;
            this.title = title;
            this.publishing = publishing;
            bc.books.Add(this);
        }
        public static int CompareByTitle(Book b1, Book b2)
        {
            return String.Compare(b1.title, b2.title);
        }
        public static int CompareByAuthor(Book b1, Book b2)
        {
            return String.Compare(b1.author, b2.author);
        }
        public static int CompareByPublishing(Book b1, Book b2)
        {
            return String.Compare(b1.publishing, b2.publishing);
        }
    }

    class BookMassive
    {
        public List<Book> books = new List<Book>();
        public void Sort(Comparison<Book> comparison)
        {
            books.Sort(comparison);
        }
        public void Print()
        {
            foreach (Book b in books)
            {
                Console.WriteLine("{0} - {1} - {2}", b.author, b.title, b.publishing);
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Задание 1");
            BankAcc bankAcc1 = new BankAcc(111, 2);
            BankAcc bankAcc2 = new BankAcc(120, 5);
            Console.WriteLine(bankAcc2==bankAcc1);
            Console.WriteLine(bankAcc2 != bankAcc1);
            Console.WriteLine(bankAcc1.Equals(bankAcc2));
            Console.WriteLine(bankAcc2.ToString());
            

            Console.WriteLine("Задание 2");
            Q q1 = new Q(12,8);
            Q q2 = new Q(20,4);
            Console.WriteLine(q1 == q2);
            Console.WriteLine(q2 != q1);
            Console.WriteLine(q1 > q2);
            Console.WriteLine(q1 >= q2);
            Console.WriteLine(q1 < q2);
            Console.WriteLine(q1 <= q2);
            Console.WriteLine((q1 + q2).ToString());
            Console.WriteLine((q1 - q2).ToString());
            

            Console.WriteLine("Домашнее задание 1");
            C c1 = new C(2, 3);
            C c2 = new C(3, 4);
            Console.WriteLine(c1 == c2);
            Console.WriteLine((c1 + c2).ToString());
            Console.WriteLine((c1 - c2).ToString());
            Console.WriteLine((c1 * c2).ToString());
            

            Console.WriteLine("домашнее задание 2");


            BookMassive arr = new BookMassive();
            Book book1 = new Book("Тумаков", "Проограммирование на языке C#", "КФУ Библиотека", arr);
            Book book2 = new Book("Кудрявцев", "Сборник задач по математическому анализу", "КФУ Библиотека", arr);
            Book book3 = new Book("Карчевский", "Линейная алгебра и аналитическая геометрия", "КФУ Библиотека", arr);
            arr.Sort(Book.CompareByTitle);
            arr.Print();
            Console.WriteLine();
            arr.Sort(Book.CompareByAuthor);
            arr.Print();


            Console.ReadLine();
        }
    }
}
