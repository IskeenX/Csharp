using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellsKitchen
{
    public class Vegetable : RawMaterial
    {
        public Vegetable(string name, string unitOfMeasure)
        {
            Name = name;
            UnitOfMeasure = unitOfMeasure;
        }
    }
}