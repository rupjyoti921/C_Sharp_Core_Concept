using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice._16MultiThread.Async
{
    public class AsyncPrac
    {
        public async Task<int> AddSum(int a)
        {
            int b = 200;
            await Task.Delay(1000);
            b+=a;
            return b;
        }

        //public static void Main()    //*** Non Async Main
        //{
        //    AsyncPrac ap=new AsyncPrac();
        //    Task<int>  t= ap.AddSum(100);
        //    Console.WriteLine($"Sum is : {t.Result}");  //here t.result will block the thread until the result got
        //}

        public static async void MainA()
        {
            AsyncPrac ap = new AsyncPrac();
            int result = await ap.AddSum(100);     //ASynchronous Main
            Console.WriteLine($"Sum is : {result}");
        }

    }
}
