using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterfaces
{
    public class CreditCard : PlasticCard, IPayment
    {
        private int _balance;
        int Balance { get { return _balance; } }     //?
        public int Limit { get; set; } = 100;
        private string owner;

        public CreditCard(string owner, int balance) : base(owner)
        {
            this.owner = owner;
            _balance = balance;
        }

        private void LimitChange(int limit)
        {
            if (limit >= 0 && limit <= Limit + (Limit/2))
            {
                Limit = limit;
            }
            else
            {
                Console.WriteLine("Increasing is only allowed by at most 50% of its current value. Minimum value is 0");
            }
        }

        public virtual bool Pay(int cost)
        {
            Console.WriteLine("CreditCard: " + owner + "\n-------------");
            Console.WriteLine($"Your balance is {_balance}USD");
            Console.WriteLine($"Charging of {cost}USD");

            Console.WriteLine($"Your limit is {Limit}USD. Press <Spacebar> to change.");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Spacebar)
            {
                LimitChange(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine($"Limit has been set to {Limit}USD");
            }

            if (Limit >= cost && cost <= _balance)
            {
                _balance -= cost;
                Console.WriteLine("Payment was successful!\n\n");
                return true;
            }
            else
            {
                Console.WriteLine("Something wrong with payment!\n\n");
                return false;
            }
        }
    }
}