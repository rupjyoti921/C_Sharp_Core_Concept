using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice._17Events
{
    public class CustomEv : EventArgs
    {
        public string Msg {  get; set; }
    }

    public class Publisher
    {
        public event EventHandler<CustomEv> CustomEv;

        public void Count()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Time in seconds : {i}");
                Thread.Sleep(1000);
                if (i > 5)
                {
                    TriggerEvent();
                    break;
                }
            }
        }

        public void TriggerEvent() {
            CustomEv?.Invoke(this, new CustomEv { Msg = "Msg Property set Success!" });
        }
    }
    internal class EventPra
    {
        public static void Subscrb(object recvObj, CustomEv cEv)
        {
            Console.WriteLine($"Event Triger with Parameter MSG : {cEv.Msg}");
        }
        public static void MainEv3()
        {
            Publisher pb= new Publisher();
            pb.CustomEv += EventPra.Subscrb;
            pb.Count();
        }
    }
}
