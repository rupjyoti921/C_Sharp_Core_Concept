using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice
{
    internal class OperatorOverloading
    {
        int real, img;
        public OperatorOverloading(int r, int i) { 
            real = r;
            img = i;
        }

        public static OperatorOverloading operator +(OperatorOverloading obj1, OperatorOverloading obj2)
        {
            return new OperatorOverloading(obj1.real+obj2.real, obj1.img+obj2.img);
        }

        public void Display()
        {
            Console.WriteLine($"Real : {real} and Imag : {img}");
        }

        public static void Main4()
        {
            OperatorOverloading op1=new OperatorOverloading(2,4);
            OperatorOverloading op2 =new OperatorOverloading(4,2);
            OperatorOverloading op3 = op1 + op2;
            op3.Display();
        }
    }
}
