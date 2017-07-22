using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAndEnums
{
    public struct Books
    {
        private string title;
        private string author;
        private string subject;

        public void GetValues(string t, string a, string s)
        { title = t; author = a; subject = s; }

        public void Display()
        {
            Console.WriteLine("This book's title is: {0}", title);
            Console.WriteLine("This book's author is: {0}", author);
            Console.WriteLine("This book's subject is: {0}", subject);
        }
    }

    public enum DaysOfWeek { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    class Program
    {
        static void Print<T>(T input)
        {
            Console.WriteLine("Value of input is: {0}", input);
        }

        static void Main(string[] args)
        {
            Books HarryPotter = new Books();
            HarryPotter.GetValues("Harry Potter and the Sorcerer's Stone", "JK Rowling", "Fiction");
            HarryPotter.Display();
            Print<dynamic>("hello");

            Console.ReadKey();
        }
    }
}
