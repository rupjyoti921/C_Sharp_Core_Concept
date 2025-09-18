using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CshOOPPractice
{
    delegate void Calculation(int a,int b);
    internal class DelegatesLearnign
    {
        public void Sum(int a,int b)
        {
            Console.WriteLine($"Sum of {a} and {b} is {a+b} ");
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine($"Subtraction of {a} and {b} is {a - b}");
        }

        public void Mul(int a, int b)
        {
            Console.WriteLine($"Multiplication of {a} and {b} is {a * b} ");
        }
    }

    public class Program2()
    {
        public static void Main8()
        {
            DelegatesLearnign dlObj = new DelegatesLearnign();
            Calculation cal = new Calculation(dlObj.Sum);
            cal+=dlObj.Sub;
            //cal-=dlObj.Sum;
            cal += dlObj.Mul;
            //cal-=dlObj.Mul;
            cal(2, 3);   //cal.Invoke(2, 3);

        }
    }
}
