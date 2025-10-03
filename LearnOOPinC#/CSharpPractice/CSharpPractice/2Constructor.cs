using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CshOOPPractice
{
    internal class Constructor
    {
        public Constructor(int a)
        {
            Console.WriteLine($"Base Class Constructor: value of parameter: {a}");
        }
    }

    class Child : Constructor
    {
        public Child() : base(10)
        {
            Console.WriteLine("Derived CLass COnstructor");
        }

        public static void Main2(string[] args)
        {
            Child ch1 = new Child();
        }
    }
}
