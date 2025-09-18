using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice
{
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("This is parent");
        }
        public virtual void Disp()
        {
            Console.WriteLine("Parent Display");
        }
    }
    public class Derive : Parent
    {
        public Derive()
        {
            Console.WriteLine("This is Child");
        }
        public override void Disp()
        {
            Console.WriteLine("Child Display");
            //base.Disp();
        }
        internal class Overriding
        {
            public static void Main1(string[] args)
            {
                Derive d = new Derive();
                Parent p = d;
                p.Disp();
                d.Disp();
            }

        }
    }
}
