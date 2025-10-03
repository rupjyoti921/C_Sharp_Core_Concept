using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CshOOPPractice._16MultiThread
{
    public class ThreadClassPractice
    {
        public void PrintNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"numbers : {i}");
                Thread.Sleep(100);
            }
        }

        public void PrintMsg()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("This is message");
                Thread.Sleep(100);
            }
        }

        public static void MainTC()
        {
            ThreadClassPractice tc  = new ThreadClassPractice();

            //Background Thread
            Thread tb = new Thread(() =>
            {
                while (true)
                {
                    Console.WriteLine("Background Thread running");
                    Thread.Sleep(100);
                }
            });
            tb.IsBackground = true;
            tb.Start();


            Thread t1 = new Thread(tc.PrintNumbers);
            t1.Start();
            //t1 = new Thread (tc.PrintMsg);   //using same reference but with new object will override the prev obj.
            //t1.Start();    // we can use the same reference 
            //t1.Join();   // will stop the current thread or calling thread.
            Thread t2 = new Thread(tc.PrintMsg);
            t2.Start();

            Thread t3 = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Arrow Method");
                    Thread.Sleep(100);
                }
            });
            t3.Start();

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("Hello");
                Thread.Sleep(100);
            }

            Thread.Sleep(5000);

        }
    }
}
