using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice._18ProgressCallBack
{
    public class _2PCBManual
    {
        public static void Main3()
        {
            Action<int> progressReport = percent => { Console.Write($"\rPercentage : {percent}%"); };
            UpdateProgress(progressReport);
        }

        public static void UpdateProgress(Action<int> progressReport)
        {
            for(int i=0; i <= 100;)
            {
                Thread.Sleep(500);
                progressReport(i);
                i += 10;
            }

        }
    }
}
