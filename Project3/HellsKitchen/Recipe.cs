using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellsKitchen
{
    public class Recipe
    {
        public string Name { get; set; }
        public Dictionary<RawMaterial, int> Ingredients { get; set; }

        public Recipe(string name)
        {
            Name = name;
            Ingredients = new Dictionary<RawMaterial, int>();
        }
    }
}