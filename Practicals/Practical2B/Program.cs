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

namespace Practical2B
{
    public class FunctionOverloading
    {
        public int AreaOfRectangle(int length, int breadth)
        {
            return length * breadth;
        }

        public int AreaOfRectangle(int length)
        {
            return length * length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1] Function Overloading
            Console.WriteLine("---- Function Overloading Demo ----");
            FunctionOverloading demo = new FunctionOverloading();
            Console.WriteLine("Area of Rectange 2 * 2 : " + demo.AreaOfRectangle(2 * 2));
            Console.WriteLine("Area of Square of side = 2  : " + demo.AreaOfRectangle(2));
            Console.WriteLine();
        }
    }
}
