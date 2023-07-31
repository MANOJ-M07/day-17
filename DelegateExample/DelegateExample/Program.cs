using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    //delegate can represent instance method
    //and static method but the signature must watch

    public delegate void OurDelegate(string name);
    internal class Program
    {
        public static void Welcome(string n)
        {
            Console.WriteLine("welcome to delegate" + n);
        }

        public void MyMethod(string msg)
        {
            Console.WriteLine("Message for you" + msg);
        }
        static void Main(string[] args)
        {
            OurDelegate ourDelegate = new OurDelegate(Welcome);
            ourDelegate("Rajiv Kumar");
            Program obj = new Program();
            OurDelegate ourDelegate1 = new OurDelegate(obj.MyMethod);
            ourDelegate1("let us begin");
            Console.ReadKey();
        }
    }
}
