using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterfaces
{
    public class Loan : IPayment, IHasOwner
    {
        public int Amount { get; private set; } = 0;
        public int Limit { get; set; } = int.MaxValue;
        public string Owner { get; }
        private int counter = 1;

        public bool Pay(int cost)
        {
            counter++;
            int[] amounts = new int[counter];
            for (int i = 0; i < counter; i++)
            {
                amounts[i] = cost;
            }
            Console.WriteLine($"Loan is {amounts.Sum()}USD");    //?
            return true;
        }
    }
}