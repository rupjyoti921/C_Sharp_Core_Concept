using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice.constPractice
{
    public class ConstantKeyW
    {
        public const int a = 20;
    }

    public class ProgramConst
    {
        public static void Main14()
        {
            Console.WriteLine($"{ConstantKeyW.a}");
        }
    }
}