using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterfaces
{
    public class LostCreditCard : CreditCard, ILostItem
    {
        public DateTime DateOfLoss { get; set; } = DateTime.Now;
        private string owner;

        public LostCreditCard(string owner, int balance) : base(owner, balance)
        {
            this.owner = owner;
        }

        public override bool Pay(int cost)
        {
            Console.WriteLine("Lost Credit Card: " + owner + "\n-------------");
            Console.WriteLine($"This card has been lost on {DateOfLoss}\n\n");
            return false; 
        }
    }
}