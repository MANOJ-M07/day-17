using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodsExample
{
    internal class Program
    {
        public delegate void WelDel(string name);
        static void Main(string[] args)
        {
            //anonymous method
            /*WelDel objdel = delegate (string name)
            {
                Console.WriteLine("Welcome to Anonymous method" + name);
            };
            objdel("Ravi kumar garg");*/

            //noraml call
            //WelDel welDel = new WelDel(ourMethod);
            //objdel("normal method")

            //lamda
            WelDel objdel = (string name) => Console.WriteLine("welcome to lamdas"+name);
            objdel("rishi");

            Console.ReadKey();  
           
        }
    }
}
