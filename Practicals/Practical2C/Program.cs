using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical2C
{
    public delegate string MyDel(string str);
	
    class EventProgram {
        event MyDel MyEvent;
		
        public EventProgram() {
            this.MyEvent = this.MyEvent+ new MyDel(this.WelcomeUser);
        }
        public string WelcomeUser(string username) {
            return "Welcome " + username;
        }
        static void Main(string[] args) {
            EventProgram obj1 = new EventProgram();
            Console.Write("Enter your Name : ");
            string result = obj1.MyEvent(Console.ReadLine());
            Console.WriteLine(result);
            Console.WriteLine("Press any key to exist...");
            Console.ReadKey();
         }
    }
}