using CshOOPPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Using.DI.Interface;

namespace Using.DI
{
    public class UsingDI
    {
        public static void MainDI()
        {
            PaymentProcessor processPay = new PaymentProcessor(new UPIPayment());
            processPay.ProcessPayment(100);
        }
    }

    class PaymentProcessor
    {
        private IPayment iPay;

        public PaymentProcessor(IPayment IPay)  //Ijecting through Constructor
        {
            iPay = IPay;
        }

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

//Created an interface (IPayment)
//Both CreditCardPayment and UPIPayment implement this interface.
//Now PaymentProcessor depends on the abstraction (IPayment), not on a concrete class.
//PaymentProcessor doesn’t create its own UPIPayment or CreditCardPayment.
//Instead, it receives whatever implementation is passed from the outside (new UPIPayment() in Main).


//Benefits You Achieved
//-----------------------------
//Loose coupling → PaymentProcessor no longer tied to one payment type.
//Flexibility → Easy to swap payment methods.
//Maintainability → Add new payment types(e.g., NetBankingPayment) without touching existing code.
//Testability → You can inject a mock IPayment class for unit tests.