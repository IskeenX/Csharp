using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace AbstractionAndInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHasOwner[] financial = new IHasOwner[]
            {
                new CreditCard("Mike", 1000),
                new CreditCard("John", 5000),

                new LostCreditCard("Zip", 80),

                new Loan(),
                new Loan()
            };

            foreach(IPayment item in financial)
            {
                item.Pay(150);
            }

            Console.ReadKey();
        }
    }
}