using MyCompany.Employess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice._13PartialClass
{
    public class MyCompany
    {
        public static void Main13()
        {
            MyCompanyEmployes mce = new MyCompanyEmployes
            {
                Name="Rupjyoti",
                EmpId=1001
            };
            mce.ProvideOfferLetter();
            MyCompanyEmployes mce2 = new MyCompanyEmployes
            {
                Name = "Dukani",
                EmpId = 1089
            };
            mce2.ProvideLastLetter();
        }
    }
}
