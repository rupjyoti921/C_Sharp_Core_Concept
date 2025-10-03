using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice
{

    internal class RevOut
    {
        public static void CallByValue(int a)
        {
            a += 5;
        }

        public static void CallByRef(ref int a)
        {
            a += 5;
        }

        public static void CallByOut(out int a)
        {
            a = 0;
            a += 10;
        }
        public static void Main3()
        {
            int a = 20;

            CallByValue(a);
            Console.WriteLine($"Call by Value. Value of a is : {a}");
            CallByRef(ref a);
            Console.WriteLine($"Call by Ref. Value of a is : {a}");
            CallByOut(out a);
            Console.WriteLine($"Call by Out. Value of a is : {a}");
        }
    }
}
