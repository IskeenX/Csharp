using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterfaces
{
    public interface IPayment
    {
        int Limit { get; set; }

        bool Pay(int cost);
    }
}