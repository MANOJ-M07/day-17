using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    delegate void OrderEventHandler();

    class Order
    {
        public event OrderEventHandler OnCreated;

        public void Create()
        {
            Console.WriteLine("order created");
            if (OnCreated != null)
            {
                OnCreated();
            }
        }
    }

    class Email
    {
        public static void Send()
        {
            Console.WriteLine($"Send email");
        }
    }

    class SMS
    {
        public static void Send()
        {
            Console.WriteLine($"Send SMS");
        }
    }
    
    
     class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.OnCreated += Email.Send;
            order.OnCreated -= Email.Send;

            order.Create();
            Console.ReadKey();
        }
    }
}
