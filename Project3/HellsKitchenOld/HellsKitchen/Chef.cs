using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellsKitchen
{
    public class Chef
    {
        //Event when a chef is eliminated from the competition
        public delegate void EliminationEventHandler(object sender, EventArgs e);
        public event EliminationEventHandler Eliminated;

        public string Name { get; set; }
        public List<RawMaterial> Ingredients { get; set; }
        public LinkedList<Recipe> CreatedDishes { get; set; }

        public Chef(string name, List<RawMaterial> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
            CreatedDishes = new LinkedList<Recipe>();
        }

        public void OnEliminated()
        {
            Eliminated?.Invoke(this, EventArgs.Empty);
        }

        public void CreateDishes(RecipeSearchTree recipeSearchTree)
        {
            //Iterates through all recipes in the tree
            if(recipeSearchTree != null)
            {
                //Checking if the chef has enough ingredients
                bool hasEnoughIngredients = true;
                foreach  (KeyValuePair<RawMaterial, int> ingredient in recipeSearchTree.Recipe.Ingredients)
                {
                    if(!Ingredients.Contains(ingredient.Key) || Ingredients.Count(i => i == ingredient.Key) < ingredient.Value)
                    {
                        hasEnoughIngredients = false;
                        break;
                    }
                }

                //If has, create a dish and add it to their list of created dishes
                if(hasEnoughIngredients)
                {
                    CreatedDishes.AddLast(recipeSearchTree.Recipe);

                    //Remove the used ingredients
                    foreach (KeyValuePair<RawMaterial, int> ingredient in recipeSearchTree.Recipe.Ingredients)
                    {
                        for (int i = 0; i < ingredient.Value; i++)
                        {
                            Ingredients.Remove(ingredient.Key);
                        }
                    }
                }

                //Checking the left and right subtrees
                CreateDishes(recipeSearchTree.Left);
                CreateDishes(recipeSearchTree.Right);
            }
        }
    }
}