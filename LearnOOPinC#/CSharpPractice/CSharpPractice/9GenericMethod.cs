using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice
{
    internal class GM
    {
        public static void Sum<x>(x[] arr)
        {
            foreach(var item in arr) {
                Console.WriteLine(item);
            }
        }
    }
    class ProgramGeneric
    {
        public static void Main9()
        {
            int[] arr =new int[] { 2, 3, 4, 5 };
            double[] arr2 = new double[] { 2.2, 3, 4.0, 5.4 };
            GM.Sum(arr);
            Console.WriteLine("\n");
            GM.Sum(arr2);
        }
    }
}
