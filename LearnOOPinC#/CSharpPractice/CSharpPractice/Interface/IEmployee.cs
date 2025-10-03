using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice.Interface
{
    interface IEmployee
    {
        int age { get; set; }
       public abstract void CalculateSalary();
    }
}
