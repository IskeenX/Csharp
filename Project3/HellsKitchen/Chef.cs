using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellsKitchen
{
    public class Chef
    {
        public string Name { get; set; }
        public Dictionary<RawMaterial, int> Ingredients { get; set; }
        public DishLinkedList DishList { get; set; }

        public Chef(string name)
        {
            Name = name;
            Ingredients = new Dictionary<RawMaterial, int>();
            DishList = new DishLinkedList();
        }
    }
}