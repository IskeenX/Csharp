using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellsKitchen
{
    public class Recipe
    {
        //Name of dish
        public string Name { get; set; }

        //The ingredients
        public Dictionary<RawMaterial, int> Ingredients { get; set; }

        //Needed quantities
        public int UniqueIngredients { get; set; }

        public Recipe(string name, Dictionary<RawMaterial, int> ingredients) 
        { 
            Name = name;
            Ingredients = ingredients;
            UniqueIngredients = ingredients.Count;
        } 
    }
}