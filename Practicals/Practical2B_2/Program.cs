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
    public class SingleA
    {
        public string sayHi()
        {
            return "Hi";
        }
    }
    public class SingleB : SingleA
    {
        public string sayHello()
        {
            return "Hello";
        }
    }

    public class MutliLevelC : SingleB
    {
        public string sayHelloWorld()
        {
            return sayHello() + " world!!";
        }
    }

    public class HierarchicalD : SingleB
    {
        public string sayHelloHi()
        {
            return sayHello() + sayHi();
        }
    }

    public interface IMultipalA
    {
        int setA();
    }

    public interface IMultipalB
    {
        int setB();
    }
    public class MultipleC : IMultipalA, IMultipalB
    {
        public int setA()
        {
            return 2;
        }
        public int setB()
        {
            return 2;
        }
        public int product(int A, int B)
        {
            return A * B;
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            // 2] Inheritance
            Console.WriteLine("---- Inheritance Demo ----");
            Console.WriteLine("1] Single");
            SingleB B = new SingleB();
            Console.WriteLine("sayHello : " + B.sayHello());
            Console.WriteLine("sayHi : " + B.sayHi());
            Console.WriteLine();

            Console.WriteLine("2] MultiLevel");
            MutliLevelC C = new MutliLevelC();
            Console.WriteLine("sayHelloWorld : " + C.sayHelloWorld());
            Console.WriteLine("sayHello : " + C.sayHello());
            Console.WriteLine("sayHi : " + C.sayHi());
            Console.WriteLine();

            Console.WriteLine("3] Hierarchical");
            HierarchicalD D = new HierarchicalD();
            Console.WriteLine("sayHello : " + D.sayHello());
            Console.WriteLine("sayHi : " + D.sayHi());
            Console.WriteLine();


            Console.WriteLine("4] Multiple");
            MultipleC MultiC = new MultipleC();
            Console.WriteLine("Demo : " + MultiC.product(MultiC.setA(), MultiC.setB()));
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();            
        }
    }
}
