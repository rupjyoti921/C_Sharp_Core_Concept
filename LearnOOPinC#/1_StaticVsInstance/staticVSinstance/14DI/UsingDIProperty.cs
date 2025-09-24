using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Using.DI.Interface;

namespace Using.DI.Property
{
    public class UsingDI
    {
        public static void MainDIProp()
        {
            PaymentProcessor processPay = new PaymentProcessor();
            processPay.iPay = new UPIPayment(); //Ijecting Through Public Property
            processPay.ProcessPayment(100);
        }
    }

    class PaymentProcessor
    {
        public IPayment iPay { get; set; }

        public void ProcessPayment(double amount)
        {
            iPay.Pay(amount);

            //CreditCardPayment cc = new CreditCardPayment();
            //cc.Pay(amount);

            //UPIPayment upi = new UPIPayment();
            //upi.Pay(amount);

        }
    }



    class CreditCardPayment:IPayment
    {
        public void Pay(double amount)
        {
            double inteRate = 10;
            double charges = amount * (inteRate / 100);
            double TotalBill = amount + charges;
            Console.WriteLine($"Credit Card Payment Success!!\n..\n...\nAmount : {amount} + Charges : {charges}% = Total : {TotalBill}");
        }
    }

    class UPIPayment:IPayment
    {
        public void Pay(double amount)
        {
            double inteRate = 5;
            double charges = amount * (inteRate / 100);
            double TotalBill = amount + charges;
            Console.WriteLine($"UPI Payment Success!!\n..\n...\nAmount : {amount} + Charges : {charges}% = Total : {TotalBill}");
        }
    }
}
