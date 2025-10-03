using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice
{
    internal class GC<T>
    {
        T Box;
        public T Name { get; set; }
        public GC(T box)
        {
            Box = box;
        }
        public T GetBox()
        {
            return Box;
        }
    }

    public class MainClass
    {
        public static void Main10(string[] args)
        {
            GC<int> gc = new GC<int>(3);
            GC<string> gc1 = new GC<string>("Rup");
            gc.Name = 22;
            gc1.Name = "Barman";
            Console.WriteLine(gc.GetBox());
            Console.WriteLine(gc1.GetBox());
            Console.WriteLine(gc.Name);
            Console.WriteLine(gc1.Name);
        }
    }
}
