/*
 * Practical No 2:
 * B] Create simple appliaction to demostrate use of the following Concept
 * 1] Function Overloading
 * 2] Inheritance
 * 3] Constructor Overloading
 * 4] Interfaces [Done in Multiple Inheritance {Practical2B_2}]
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical2B_3
{
    public class AreaOfRectangle
    {
        public int product;
        public AreaOfRectangle(int a, int b)
        {
            this.product = a * b;
        }
        public AreaOfRectangle(int a)
        {
            this.product = a * a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 3] Constructor Overloading
            Console.WriteLine("---- Constructor Overloading ----");
            AreaOfRectangle demo1 = new AreaOfRectangle(2);
            Console.WriteLine("demo1 : " + demo1.product);
            Console.WriteLine();
            AreaOfRectangle demo2 = new AreaOfRectangle(3,5);
            Console.WriteLine("demo2 : " + demo2.product);
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); 
        }
    }
}
