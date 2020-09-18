/*
 * Practical No 1:
 * B] Create an application to demostrate string operations.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical1B
{
    class Program
    {
        static void Main(string[] args)
        {
            string user_str;

            // Getting String
            Console.Write("Enter String : ");
            user_str = Console.ReadLine();

            // Length of user_string
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("[Length] of String : " + user_str.Length);
            
            // ToUpper of user_string
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("[ToUpper] of String : " + user_str.ToUpper());

            // ToLower of user_string
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("[ToLower] of String : " + user_str.ToLower());
            
            // ToList of user_string
            List<char> user_str_list = user_str.ToList();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("[ToList] of String : " );
            Console.WriteLine("  |-> Traversal of List: ");
            foreach (char ele in user_str_list)
            {
                Console.WriteLine("   |-> Elements : " + ele);
            }

            //  Compare
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("[Compare] of String : ");
            Console.WriteLine("  |-> First String : " + user_str);
            Console.WriteLine("  |-> Second String : Rahul");
            Console.WriteLine("  |-> Compare First and Second String : " + string.Compare(user_str, "Rahul"));

            // Concat
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("[Concat] of String : ");
            Console.WriteLine("  |-> First String : " + user_str);
            Console.WriteLine("  |-> Second String : Developing C# program");
            Console.WriteLine("  |-> New String : " + string.Concat(user_str, " Developing C# program"));

            // Contains
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("[Contains] of String : ");
            Console.WriteLine("  |-> First String : " + user_str);
            Console.WriteLine("  |-> Second String : Rahul");
            Console.WriteLine("  |-> Result : " + user_str.Contains("Rahul"));
            
            // Insert
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("[Insert]");
            string new_str = "Learning c #";
            Console.WriteLine("String : " + new_str);
            Console.WriteLine("  |-> StartIndex : " + (new_str.Length-1));
            Console.WriteLine("  |-> Insert String : and ASP.NET.");
            Console.WriteLine("  |-> New STring : " + new_str.Insert(new_str.Length - 1, "and ASP.NET."));

            // Trim
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("[Trim]");
            string str = "    Practicals     ";
            Console.WriteLine("String : '" + str + "'");
            Console.WriteLine("Trime : " + str.Trim());

            // Replace
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("[Replace] of String : ");
            new_str = "My name is Rahul";
            Console.WriteLine("String : "+new_str);
            Console.WriteLine("  |-> Replace : 'Rahul' To 'Samar'");
            new_str = new_str.Replace("Rahul", "Samar");
            Console.WriteLine("  |-> New String : " + new_str);
            Console.WriteLine("String : "+new_str);
            Console.WriteLine("  |-> Replace : 'Samar' To 'Ankush'");
            new_str = new_str.Replace("Samar", "Ankush");
            Console.WriteLine("  |-> New String : " + new_str);
            Console.WriteLine("String : "+new_str);
            Console.WriteLine("  |-> Replace : 'Ankush' To 'Juje'");
            new_str = new_str.Replace("Ankush", "Juje");
            Console.WriteLine("  |-> New String : " + new_str);
            Console.WriteLine("String : "+new_str);
            Console.WriteLine("  |-> Replace : 'Juje' To 'Jay Prakash'");
            new_str = new_str.Replace("Juje", "Jay Prakash");
            Console.WriteLine("  |-> New String : " + new_str);
            

            // Remove
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("[Remove] of String : ");
            new_str = "1234567890";
            Console.WriteLine("String : " + new_str);
            Console.WriteLine("  |-> Remove Start Index : 0");
            Console.WriteLine("  |-> Remove Count : 2");
            Console.WriteLine("  |-> New String : " + new_str.Remove(0, 2));


            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Enter any Key to exit...");
            Console.ReadKey();

        }
    }
}
