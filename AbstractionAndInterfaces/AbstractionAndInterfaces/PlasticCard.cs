using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterfaces
{
    public class PlasticCard : IHasOwner
    {
        public string Owner { get; private set; }
        public PlasticCard(string owner) 
        {
            Owner = owner;
        }
    }
}