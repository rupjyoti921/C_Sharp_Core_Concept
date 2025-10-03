using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Numerics;

namespace CshOOPPractice._16MultiThread
{
    public class TaskThread
    {
        public int printAndReturnInt()
        {
            int total=0;
            for(int i = 0; i < 10; i++)
            {
                total += i;
            }
            Thread.Sleep(5000);

            return total;
        }

        public void printMsg()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Msg got Printed : {i}");
                Thread.Sleep(40);
            }
        }

        public static void MainTT()
        {
            TaskThread tt = new TaskThread();

            Task t = Task.Run(tt.printMsg);

            Task<int> t2 = Task.Run(tt.printAndReturnInt);
            Console.WriteLine($"Result is : {t2.Result}");  // here t2.Result will stop the thread until the result returned

            //t.Wait();   // will wait to complete t
            //Task.WhenAny(t, t2).Wait();  //will wait any one to complete as t complete first then Main got complete and t got terminate
            //Task.WhenAll(t, t2).Wait(); // wait for both to complete
            Console.WriteLine("\n\n******Main End*******\n\n");
        }
    }
}
