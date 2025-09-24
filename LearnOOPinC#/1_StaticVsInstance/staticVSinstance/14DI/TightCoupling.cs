using CshOOPPractice._14DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice._14DI
{
    internal class TightCoupling
    {
        public static void MainTC()
        {
            PaymentProcessor processPay = new PaymentProcessor();
            processPay.ProcessPayment(100);
        }
    }
    class PaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            //CreditCardPayment cc = new CreditCardPayment();
            //cc.Pay(amount);

            UPIPayment upi = new UPIPayment();
            upi.Pay(amount);

        }
    }




    class CreditCardPayment
    {
        public void Pay(double amount)
        {
            double inteRate = 10;
            double charges = amount *( inteRate/100);
            double TotalBill = amount + charges;
            Console.WriteLine($"Credit Card Payment Success!!\n..\n...\nAmount : {amount} + Charges : {charges}% = Total : {TotalBill}");
        }
    }

    class UPIPayment
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

//Why it’s Tightly Coupled?

//In PaymentProcessor.ProcessPayment() you are directly creating an object (UPIPayment or CreditCardPayment).

//UPIPayment upi = new UPIPayment();
//upi.Pay(amount);


//👉 This means PaymentProcessor is locked to that specific payment type.

//If tomorrow you want to support NetBankingPayment, you must open PaymentProcessor and edit code → that breaks the Open/Closed Principle (OCP from SOLID).

//PaymentProcessor depends on concrete classes (UPIPayment, CreditCardPayment) instead of depending on an abstraction (IPayment).
