using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice._18ProgressCallBack
{
    public class PCB
    {
        public static async Task Main2()
        {
            var progress = new Progress<int>(percent =>
            {
                Console.Write($"\rProgress is : {percent}%");
            });

            await StartTheTest( progress );
        }

        public static async Task StartTheTest(IProgress<int> progress)
        {
            Console.WriteLine("Test is Running..");
            for (int i = 0; i <= 100; )
            {
                progress?.Report(i);
                await Task.Delay(500);
                i += 10;

            }
            Console.WriteLine("\n------Test Completed-------");
        }


    }
}
