using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CshOOPPractice.Interface;

namespace CshOOPPractice
{
    internal class _6Employee:IEmployee   //Abstraction Interface
    {
        int BP; //Encapsulation 
        int HA; //Encapsulation 
        string Name; //Encapsulation 
        public int age { get; set; }
        public _6Employee(int bp, int ha, string name)
        {
            BP = bp;
            Name = name;
            this.HA = ha;
        }

        void GetSalary()   //Encapsulation 
        {
            int totalSalary = BP + HA + (BP / 100 * 30) + (BP / 100 * 10);
            Console.WriteLine($"Total Salary of {Name} is {totalSalary}");

        }

        public void CalculateSalary()   //Abstraction
        {
            GetSalary();
        }
        
    }


    public class MainEmployee
    {
        public static void Main6(string[] args)
        {

            _6Employee emp = new _6Employee(25000, 5000, "Rupjyoit Barman");
            emp.CalculateSalary();
        }
    }
}
