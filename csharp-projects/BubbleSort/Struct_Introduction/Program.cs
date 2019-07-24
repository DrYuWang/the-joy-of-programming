using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Introduction
{
    class Program
    {
        // Define a struct type called 'Point'
        struct Point
        {
            public double x;
            public double y;
            public double z;
        }
        // Define a struct type called 'Book'
        public struct Book
        {
            public decimal Price; // decimal type is used for money. It's more accurate for financial calculations.
            public string Title;
            public string Author;
        }
        static void Main(string[] args)
        {
            // -------Example of using 'Point' struct---------
            // Create a variable whose type is Point.
            Point p = new Point();
            p.x = 1;
            p.y = 2;
            p.z = 3;
            Console.WriteLine($"point coordinates are x = {p.x}, y = {p.y}, z = {p.z}.");
            double length = calculateLength(p);
            Console.WriteLine($"The distance of the point to the origin is {length}.");

            // Example of using 'Book' struct
            Book godDelusion = new Book();
            godDelusion.Title = "The God Delusoin";
            godDelusion.Author = "Richard Dawkins";
            godDelusion.Price = 20m; // 'm' signifies decimal.
            printBook(godDelusion);
        }

        static double calculateLength(Point p)
        {
            return Math.Sqrt(p.x * p.x + p.y * p.y + p.z * p.z);
        }

        static void printBook(Book book)
        {
            Console.WriteLine($"Book Title: {book.Title}");
            Console.WriteLine($"Book Author: {book.Author}");
            Console.WriteLine($"Book price: {book.Price} CAD");
        }

    }
}
