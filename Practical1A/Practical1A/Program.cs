using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64[] numbers = new Int64[4];
            Int64 result = 1;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter Number "+(i+1)+" : ");
                try
                {
                    numbers[i] = Int64.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Given input is Not a Number");
                    goto Exit;
                }
            }

            foreach (Int64 n in numbers)
            {
                result *= n;
            }

            Console.WriteLine("Result = " + result);

            Exit:
            Console.WriteLine("Enter any key to exit...");
            Console.ReadLine();
            
        }
    }
}
