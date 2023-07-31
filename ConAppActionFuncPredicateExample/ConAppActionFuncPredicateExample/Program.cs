using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppActionFuncPredicateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Action<string, string> printFullName = (fn, ln) =>
            {
                Console.WriteLine("full name is:"+fn+""+ln);
            };
            *//*Action<string, string> printName = (fn, ln) =>
            {

            }*//*
            Console.WriteLine("enter first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("enter second name");
            string lastName = Console.ReadLine();
            printFullName(firstName, lastName);
            Console.ReadKey();*/

           /* Action<double, double, double> printMulti = (n1, n2, n3) =>
            {
                Console.WriteLine("{0} * {1} * {2} = \t{3} : " ,n1,n2,n3,(n1*n2*n3));
            };
            Console.WriteLine("enter first");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("enter second");
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine("enter third");
            double thirdNum = double.Parse(Console.ReadLine());
            printMulti(firstNum, secondNum, thirdNum);
            Console.ReadKey();*/

            //func
           /* Func<double, double, double>multi = (a, b) => a + b;
            Console.WriteLine("enter first number");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            double secondNum = double.Parse(Console.ReadLine());

            double thirdNum = multi(firstNum, secondNum);
            Console.WriteLine("After multiply in {} and {} =\t {2}", firstNum, secondNum, thirdNum);
            Console.ReadKey ();*/

            Predicate<int> isEven = (number) => number % 2 == 0;
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            if (isEven(num))
            {
                Console.WriteLine($"{num}an even number");
            }
            else
            {
                Console.WriteLine($"{num}is odd number");
            }
            Console.ReadKey();


        }
    }
}
