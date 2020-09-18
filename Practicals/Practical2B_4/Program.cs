/*
 * Practical No 2:
 * B] Create simple appliaction to demostrate use of the following Concept
 * 1] Function Overloading
 * 2] Inheritance
 * 3] Constructor Overloading
 * 4] Interfaces 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical2B_4
{
    public interface IDemo
    {
        
        void getLB();
        int product();
    }
    public class Demo : IDemo
    {
        public int length;
        public int breadth;

        public void getLB()
        {
            Console.Write("Enter Length : ");
            this.length = int.Parse(Console.ReadLine());
            Console.Write("Enter Breadth : ");
            this.breadth = int.Parse(Console.ReadLine());
        }

        public int product()
        {
            return this.length * this.breadth;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 4] Interfaces

            Console.WriteLine("Demo Interface");
            Demo d = new Demo();
            d.getLB();
            Console.WriteLine("Length = " + d.length + "\nBreadth = " + d.breadth);
            Console.WriteLine("Area = " + d.product());

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(); 
        }
    }
}
