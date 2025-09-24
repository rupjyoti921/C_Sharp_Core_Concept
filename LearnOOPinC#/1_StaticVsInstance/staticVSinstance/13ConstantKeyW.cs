using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice.const
{
    public class ConstantKeyW
    {
        public const int a = 20;
    }

    public class ProgramConst
    {
        public static void Main()
        {
            Console.WriteLine($"{ConstantKeyW.a}");
        }
    }
}
