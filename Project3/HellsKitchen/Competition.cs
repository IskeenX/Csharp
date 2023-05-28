using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellsKitchen
{
    public class Competition
    {
        private List<Chef> redTeam;
        private List<Chef> blueTeam;
        private BinarySearchTree recipeTree;
        private Dictionary<RawMaterial, int> ingredientStorage;

        public Competition()
        {
            redTeam = new List<Chef>();
            blueTeam = new List<Chef>();
            recipeTree = new BinarySearchTree();
            ingredientStorage = new Dictionary<RawMaterial, int>();
        }

        public void AddChefToRedTeam(Chef chef)
        {
            redTeam.Add(chef);
        }

        public void AddChefToBlueTeam(Chef chef)
        {
            blueTeam.Add(chef);
        }

        public void AddRecipeToTree(Recipe recipe, int key)
        {
            recipeTree.Insert(recipe, key);
        }

        public void StartCompetition()
        {
            AssignIngredientsToChefs();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red Team:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Chef chef in redTeam.ToList())
            {
                DishLinkedList dishList = new DishLinkedList();
                List<Recipe> selectedRecipes = SelectRandomRecipes(chef);

                StringBuilder successMessage = new StringBuilder($"Chef {chef.Name} created dishes: ");

                foreach (Recipe recipe in selectedRecipes)
                {
                    bool hasIngredients = true;
                    foreach (KeyValuePair<RawMaterial, int> requiredIngredient in recipe.Ingredients)
                    {
                        if (!chef.Ingredients.TryGetValue(requiredIngredient.Key, out int availableUnits) || availableUnits < requiredIngredient.Value)
                        {
                            hasIngredients = false;
                            break;
                        }
                    }
                    if (hasIngredients)
                    {
                        Dictionary<RawMaterial, int> chefIngredientsCopy = new Dictionary<RawMaterial, int>(chef.Ingredients);
                        foreach (KeyValuePair<RawMaterial, int> requiredIngredient in recipe.Ingredients)
                        {
                            chefIngredientsCopy[requiredIngredient.Key] -= requiredIngredient.Value;
                            //chef.Ingredients[requiredIngredient.Key] -= requiredIngredient.Value;
                        }
                        chef.Ingredients = chefIngredientsCopy;
                        dishList.Add(recipe);
                        successMessage.Append($"{recipe.Name}, ");
                    }
                    else
                    {
                        Console.WriteLine($"Chef {chef.Name} does not have enough ingredients to create dish: {recipe.Name}");
                    }
                }
                if (dishList.IsEmpty())
                {
                    EliminateChef(chef);
                    Console.WriteLine($"Chef {chef.Name} has been eliminated from the competition.");
                }
                else
                {
                    Console.Write(successMessage.ToString().TrimEnd(',', ' '));
                    chef.DishList = dishList; //Assign the dishList to the chef
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Blue Team:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Chef chef in blueTeam.ToList())
            {
                DishLinkedList dishList = new DishLinkedList();
                List<Recipe> selectedRecipes = SelectRandomRecipes(chef);

                StringBuilder successMessage = new StringBuilder($"Chef {chef.Name} created dishes: ");

                foreach (Recipe recipe in selectedRecipes)
                {
                    bool hasIngredients = true;
                    foreach (KeyValuePair<RawMaterial, int> requiredIngredient in recipe.Ingredients)
                    {
                        if (!chef.Ingredients.TryGetValue(requiredIngredient.Key, out int availableUnits) || availableUnits < requiredIngredient.Value)
                        {
                            hasIngredients = false;
                            break;
                        }
                    }
                    if (hasIngredients)
                    {
                        Dictionary<RawMaterial, int> chefIngredientsCopy = new Dictionary<RawMaterial, int>(chef.Ingredients);
                        foreach (KeyValuePair<RawMaterial, int> requiredIngredient in recipe.Ingredients)
                        {
                            chefIngredientsCopy[requiredIngredient.Key] -= requiredIngredient.Value;
                            //chef.Ingredients[requiredIngredient.Key] -= requiredIngredient.Value;
                        }
                        chef.Ingredients = chefIngredientsCopy;
                        dishList.Add(recipe);
                        successMessage.Append($"{recipe.Name}, ");
                    }
                    else
                    {
                        Console.WriteLine($"Chef {chef.Name} does not have enough ingredients to create dish: {recipe.Name}");
                    }
                }
                if (dishList.IsEmpty())
                {
                    EliminateChef(chef);
                    Console.WriteLine($"Chef {chef.Name} has been eliminated from the competition.");
                }
                else
                {
                    Console.Write(successMessage.ToString().TrimEnd(',', ' '));
                    chef.DishList = dishList; //Assign the dishList to the chef
                }

                Console.WriteLine();
            }

            int redDishCount = GetDishCount(redTeam);
            int blueDishCount = GetDishCount(blueTeam);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Winner: ");
            if (redDishCount == blueDishCount)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Draw");
            }
            else
            { 
                string winnerTeam = redDishCount > blueDishCount ? "Red Team" : "Blue Team";
                int winningDishCount = Math.Max(redDishCount, blueDishCount);

                if (winnerTeam is "Red Team") Console.ForegroundColor = ConsoleColor.Red;
                else if (winnerTeam is "Blue Team") Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(winnerTeam);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Number of dishes prepared: {winningDishCount}");
            }
        }

        private void AssignIngredientsToChefs()
        {
            int totalUnits = ingredientStorage.Values.Sum();
            int unitsPerIngredient = totalUnits / (redTeam.Count + blueTeam.Count);

            foreach (Chef chef in redTeam.Concat(blueTeam))
            {
                chef.Ingredients.Clear();
                foreach (KeyValuePair<RawMaterial, int> ingredient in ingredientStorage)
                {
                    chef.Ingredients.Add(ingredient.Key, unitsPerIngredient);
                }
            }
        }

        private List<Recipe> SelectRandomRecipes(Chef chef)
        {
            List<Recipe> allRecipes = recipeTree.GetAllRecipes();
            Random random = new Random();
            List<Recipe> selectedRecipes = new List<Recipe>();

            int recipeCount = random.Next(1, allRecipes.Count);
            for (int i = 0; i < recipeCount; i++)
            {
                int index = random.Next(0, allRecipes.Count);
                Recipe recipe = allRecipes[index];
                selectedRecipes.Add(recipe);
                allRecipes.RemoveAt(index);
            }
            return selectedRecipes;
        }

        private void EliminateChef(Chef chef)
        {
            if (redTeam.Contains(chef))
            {
                redTeam.Remove(chef);
            }
            else if (blueTeam.Contains(chef))
            {
                blueTeam.Remove(chef);
            }
        }

        private int GetDishCount(List<Chef> team)
        {
            int dishCount = 0;
            foreach (Chef chef in team)
            {
                dishCount += chef.DishList.GetDishCount();
            }
            return dishCount;
        }

        public void AddIngredientToStorage(RawMaterial ingredient, int quantity)
        {
            if (ingredientStorage.ContainsKey(ingredient))
            {
                ingredientStorage[ingredient] += quantity;
            }
            else
            {
                ingredientStorage.Add(ingredient, quantity);
            }
        }
    }
}