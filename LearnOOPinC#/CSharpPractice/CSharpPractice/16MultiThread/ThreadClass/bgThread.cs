using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice._16MultiThread.ThreadClass.BgThread
{
    public class bgThread
    {
        public void PrintForegroundIndifinite()
        {
            while (true)  // Even tho Main Thread Finished the Child Thread will continue indifinite and the process will active. for this we can use BackGround Thread
            {
                Console.WriteLine("Child Thread");
                Thread.Sleep(100);
            }
            Console.WriteLine("Chile Thread End ###########");  //for Bckg thread also it will not execute as Main will finish this thread will killed so hhe outside loop it won't execute anything. 
        }
        public void PrintBackgroundIndifinite()
        {
            while (true)  // It will Complete or terminate once the Main Thread will complete
            {
                Console.WriteLine("Child Thread");
                Thread.Sleep(100);
            }
            Console.WriteLine("Chile Thread End ###########");
        }


        public static void MainBT()
        {
            bgThread bgt = new bgThread();

            //Thread t1 = new Thread(bgt.PrintForegroundIndifinite);
            //t1.Start();

            Thread t2 = new Thread(bgt.PrintBackgroundIndifinite);
            t2.IsBackground = true;
            t2.Start();

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Main Thread");
                Thread.Sleep(100);
            }

            Console.WriteLine("Main Thread End **********");
        }
    }
}
