using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice
{
    public class Publisher
    {
        //Declaring an Event
        public event EventHandler ifSomethingHappen;
        public void DoingSomething(int num)
        {
            Console.WriteLine("Doint Something...");
            if (num >= 5 && num <= 10) 
            {
                onSomethingHappen();
            }
            else
            {
                Console.WriteLine("Event Not trigger!");
            }

        }

        protected virtual void onSomethingHappen()
        {
            ifSomethingHappen?.Invoke(this, EventArgs.Empty); // Fire the event safely
        }
    }

    public class Subscriber
    {
        public void Respond(object sender, EventArgs e)
        {
            Console.WriteLine("Subscriber received event notification!");
        }
    }

    public class EventPractice
    {
        public static void MainEv1()
        {
            Publisher pub = new Publisher();
            Subscriber sub = new Subscriber();
            
            //Subscriber to the event
            pub.ifSomethingHappen += sub.Respond;

            Console.WriteLine("Enter a number between 5-10 to trigger the Event : ");
            int num = int.Parse(Console.ReadLine());
            pub.DoingSomething(num);
        }
    }
}
