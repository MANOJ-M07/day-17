using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssignmentPart_2
{

    public delegate T Operation<T>(T a, T b);
    class Program
    {
        static T Add<T>(T a, T b) => (dynamic)a + (dynamic)b;
        static T Subtract<T>(T a, T b) => (dynamic)a - (dynamic)b;
        static T Multiply<T>(T a, T b) => (dynamic)a * (dynamic)b;
        static T Divide<T>(T a, T b) => (dynamic)a / (dynamic)b;
        static void PerformOperation<T>(T a, T b, Operation<T> operation)
        {
            T result = operation(a, b);
            Console.WriteLine($"Result: {result}");
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter two values of the same data type:");
                Console.Write("Value 1: ");
                string input1 = Console.ReadLine();
                Console.Write("Value 2: ");
                string input2 = Console.ReadLine();

                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");

                int choice = int.Parse(Console.ReadLine());
            again:
                switch (choice)
                {
                    case 1:
                        PerformOperation(int.Parse(input1), int.Parse(input2), Add);
                        break;
                    case 2:
                        PerformOperation(int.Parse(input1), int.Parse(input2), Subtract);
                        break;
                    case 3:
                        PerformOperation(int.Parse(input1), int.Parse(input2), Multiply);
                        break;
                    case 4:
                        PerformOperation(int.Parse(input1), int.Parse(input2), Divide);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        goto again;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.ReadKey();
            }
        }
    }
}
