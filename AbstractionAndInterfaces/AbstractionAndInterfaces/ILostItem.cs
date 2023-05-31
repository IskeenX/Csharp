using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterfaces
{
    interface ILostItem : IHasOwner
    {
        DateTime DateOfLoss { get; }
    }
}