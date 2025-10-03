using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CshOOPPractice._16MultiThread.ThreadClass.BgThread;
using CshOOPPractice.Abstract;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CshOOPPractice._16MultiThread.Async
{
    public class AsyncPrac2
    {
        public async Task<string> GetWeatherData()
        {
            Console.WriteLine("Fetching Weather Data...");
            await Task.Delay(3000);
            Console.WriteLine("Datat Found");
            return "Weather: Sunney, 28^C";
        }

        public async Task<string> GetMatchUpdate()
        {
            Console.WriteLine("Fetching Match Data...");
            await Task.Delay(3000);
            Console.WriteLine("Match Datat Found");
            return "Score : 234, Over : 45.6";
        }

        public static async Task Main()
        {
            AsyncPrac2 ap = new AsyncPrac2();
            //Approach 1
            Task<string> t = ap.GetWeatherData();
            Task<string> t2 = ap.GetMatchUpdate();
            Console.WriteLine(t.Result);
            Console.WriteLine(t2.Result);
            //ap.GetWeatherData() starts running(returns a Task immediately).
            //t.Result blocks the current thread until the task finishes(synchronous wait).
            //Only after that is done, t2.Result executes(blocking again).
            //Drawback: This is basically synchronous execution with blocking → you lose the benefits of async programming.

            Console.WriteLine("\n\n");

            //Approach 2
            string wData = await ap.GetWeatherData();
            Console.WriteLine(wData);
            string mData = await ap.GetMatchUpdate();
            Console.WriteLine(mData);
            //await ap.GetWeatherData() 
            //asynchronously waits for weather task.
            //During the wait, the thread is not blocked, it can be used for other work.
            //But still, the second task starts only after the first completes(sequential flow).
            //Better than.Result because no thread blocking → efficient resource usage.

            Console.WriteLine("\n\n");

            //Approach 3
            Task<string> weatherTask = ap.GetWeatherData();
            Task<string> stockTask = ap.GetMatchUpdate();
            var results = await Task.WhenAll(weatherTask, stockTask);
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

            //Both tasks are started at the same time.
            //await Task.WhenAll(...) asynchronously waits until both complete.
            //Results are collected after both finish.
            //Best performance when tasks are independent.
        }
    }
}
