using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CshOOPPractice
{
    internal class Employee
    {
        public void Display()
        {
            Console.WriteLine("This is Parent Class");
        }
    }

    internal class ContractualEmployee: Employee
    {
        public new void Display()
        {
            Console.WriteLine("This is Contractual Employee");
        }
    }

    public class MethHiding
    {
        public static void Mainx()
        {
            ContractualEmployee ce = new ContractualEmployee();
            ce.Display();
        }

    }
}

