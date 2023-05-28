namespace HellsKitchen
{
    public class Program
    {
        public static void Main()
        {
            Competition competition = new Competition();

            Chef chef1 = new Chef("Chef 1");
            Chef chef2 = new Chef("Chef 2");
            Chef chef3 = new Chef("Chef 3");
            Chef chef4 = new Chef("Chef 4");
            Chef chef5 = new Chef("Chef 5");
            Chef chef6 = new Chef("Chef 6");
            Chef chef7 = new Chef("Chef 7");
            Chef chef8 = new Chef("Chef 8");
            Chef chef9 = new Chef("Chef 9");
            Chef chef10 = new Chef("Chef 10");

            competition.AddChefToRedTeam(chef1);
            competition.AddChefToRedTeam(chef2);
            competition.AddChefToRedTeam(chef3);
            competition.AddChefToRedTeam(chef4);
            competition.AddChefToRedTeam(chef5);
            competition.AddChefToBlueTeam(chef6);
            competition.AddChefToBlueTeam(chef7);
            competition.AddChefToBlueTeam(chef8);
            competition.AddChefToBlueTeam(chef9);
            competition.AddChefToBlueTeam(chef10);

            /*Vegetable potato = new Vegetable { Name = "Potato" };
            Vegetable tomato = new Vegetable { Name = "Tomato" };
            Vegetable onion = new Vegetable { Name = "Onion" };
            Spice cinnamon = new Spice { Name = "Cinnamon" };
            Spice garlic = new Spice { Name = "Garlic" };
            Spice ginger = new Spice { Name = "Ginger" };
            competition.AddIngredientToStorage(potato, 5);
            competition.AddIngredientToStorage(tomato, 5);
            competition.AddIngredientToStorage(onion, 5);
            competition.AddIngredientToStorage(cinnamon, 5);
            competition.AddIngredientToStorage(garlic, 5);
            competition.AddIngredientToStorage(ginger, 5);*/

            Vegetable parsley = new Vegetable { Name = "Parsley" };
            Vegetable beets = new Vegetable { Name = "Beets" };
            Vegetable zucchini = new Vegetable { Name = "Zucchini" };
            Spice oregano = new Spice { Name = "Oregano" };
            Spice pepper = new Spice { Name = "Pepper" };
            Spice coriander = new Spice { Name = "Coriander" };

            competition.AddIngredientToStorage(parsley, 5);
            competition.AddIngredientToStorage(beets, 5);
            competition.AddIngredientToStorage(zucchini, 5);
            competition.AddIngredientToStorage(oregano, 5);
            competition.AddIngredientToStorage(pepper, 5);
            competition.AddIngredientToStorage(coriander, 5);

            Recipe recipe1 = new Recipe("Recipe1");
            recipe1.Ingredients.Add(parsley, 2);
            recipe1.Ingredients.Add(beets, 3);
            recipe1.Ingredients.Add(oregano, 1);

            Recipe recipe2 = new Recipe("Recipe2");
            recipe2.Ingredients.Add(zucchini, 1);
            recipe2.Ingredients.Add(pepper, 2);
            recipe2.Ingredients.Add(coriander, 1);

            Recipe recipe3 = new Recipe("Recipe3");
            recipe3.Ingredients.Add(parsley, 1);
            recipe3.Ingredients.Add(zucchini, 2);
            recipe3.Ingredients.Add(oregano, 1);
            recipe3.Ingredients.Add(coriander, 1);

            competition.AddRecipeToTree(recipe1, 3);
            competition.AddRecipeToTree(recipe2, 2);
            competition.AddRecipeToTree(recipe3, 4);

            competition.StartCompetition();
            Console.ReadKey();
        }
    }
}