using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Employess
{
    public partial class MyCompanyEmployes
    {
        public string Name { get; set; }
        public int EmpId {  get; set; }

        public void ProvideOfferLetter()
        {
            Console.WriteLine($"Offering Joining Letter to {Name} which Emp ID is {EmpId}\n");
        }
    }
}
