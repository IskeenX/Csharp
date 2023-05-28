using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellsKitchen
{
    public class Competition
    {
        public List<Chef> RedTeam { get; set; }
        public List<Chef> BlueTeam { get; set; }
        public RecipeSearchTree RecipeSearchTree { get; set; }

        public Competition(List<Chef> redTeam, List<Chef> blueTeam, RecipeSearchTree recipeSearchTree)
        {
            RedTeam = redTeam;
            BlueTeam = blueTeam;
            RecipeSearchTree = recipeSearchTree;
        }

        //For shuffling a list
        private static void Shuffle<T>(List<T> list)
        {
            Random random = new Random();
            int n = list.Count;
            while(n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        //For getting all recipes in the tree
        private static void GetAllRecipes(RecipeSearchTree recipeSearchTree, List<Recipe> allRecipes)
        {
            //Same iteration as i did before
            if(recipeSearchTree != null)
            {
                allRecipes.Add(recipeSearchTree.Recipe);
                GetAllRecipes(recipeSearchTree.Left, allRecipes);
                GetAllRecipes(recipeSearchTree.Right, allRecipes);
            }
        }

        //Start the competition
        public void Start()
        {
            //Assign ingredients to each chef
            List<RawMaterial> allIngredients = new List<RawMaterial>();
            foreach (KeyValuePair<RawMaterial, int> ingredient in RecipeSearchTree.Recipe.Ingredients)
            {
                for (int i = 0; i < ingredient.Value; i++)
                {
                    allIngredients.Add(ingredient.Key);
                }
            }
            Shuffle(allIngredients);
            int numIngredientsPerChef = allIngredients.Count / (RedTeam.Count + BlueTeam.Count);
            foreach (Chef chef in RedTeam)
            {
                chef.Ingredients = allIngredients.Take(numIngredientsPerChef).ToList();
                allIngredients.RemoveRange(0, numIngredientsPerChef);
            }
            foreach (Chef chef in BlueTeam)
            {
                chef.Ingredients = allIngredients.Take(numIngredientsPerChef).ToList();
                allIngredients.RemoveRange(0, numIngredientsPerChef);
            }

            //Randomly assigning recipes to each chef
            List<Recipe> allRecipes = new List<Recipe>();
            GetAllRecipes(RecipeSearchTree, allRecipes);
            Shuffle(allRecipes);
            int numRecipesPerChef = allRecipes.Count / (RedTeam.Count + BlueTeam.Count);
            foreach (Chef chef in RedTeam)
            {
                chef.CreatedDishes.Clear();
                for (int i = 0; i < numRecipesPerChef; i++)
                {
                    chef.CreatedDishes.AddLast(allRecipes[i]);
                }
            }
            foreach (Chef chef in BlueTeam)
            {
                chef.CreatedDishes.Clear();
                for (int i = 0; i < numRecipesPerChef; i++)
                {
                    chef.CreatedDishes.AddLast(allRecipes[i + numRecipesPerChef]);
                }
            }

            //Ask each chef to create dishes from given ingredients
            foreach (Chef chef in RedTeam)
            {
                chef.CreateDishes(RecipeSearchTree);
                if(chef.CreatedDishes.Count == 0)
                {
                    chef.OnEliminated();
                }
            }
            foreach (Chef chef in BlueTeam)
            {
                chef.CreateDishes(RecipeSearchTree);
                if (chef.CreatedDishes.Count == 0)
                {
                    chef.OnEliminated();
                }
            }

            //Find the winner
            int redTeamDishes = RedTeam.Sum(chef => chef.CreatedDishes.Count);
            int blueTeamDishes = BlueTeam.Sum(chef => chef.CreatedDishes.Count);
            if(redTeamDishes > blueTeamDishes)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Red team wins with " + redTeamDishes + " dishes prepared!");
            }
            else if (redTeamDishes < blueTeamDishes)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Blue team wins with " + blueTeamDishes + " dishes prepared!");
            }
            else
            {
                Console.WriteLine("It's tie with " + blueTeamDishes + " dishes prepared!");
            }
        }
    }
}