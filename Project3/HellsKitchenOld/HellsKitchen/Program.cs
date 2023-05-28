namespace HellsKitchen
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hell's Kitchen!\n");

            RawMaterial potato = new Vegetable("Potato", "kg");
            RawMaterial onion = new Vegetable("Onion", "kg");
            RawMaterial garlic = new Vegetable("Garlic", "kg");
            RawMaterial salt = new Spice("Salt", "g");
            RawMaterial pepper = new Spice("Pepper", "g");

            var recipeSearchTree = new RecipeSearchTree();

            Recipe mashedPotatoes = new Recipe("Mashed Potatoes", new Dictionary<RawMaterial, int> { { potato, 2}, { salt, 1}, { pepper, 1} });
            Recipe roastedPotatoes = new Recipe("Roasted Potatoes", new Dictionary<RawMaterial, int> { { potato, 3}, { onion, 1}, { garlic, 2}, { salt, 1}, { pepper, 1} });
            Recipe frechFries = new Recipe("Frech Fries", new Dictionary<RawMaterial, int> { { potato, 4}, { salt, 1} });
            Recipe potatoSoup = new Recipe("Potato Soup", new Dictionary<RawMaterial, int> { { potato, 2}, { onion, 1}, { garlic, 1}, { salt, 1}, {pepper, 1} });
            Recipe mashedSweetPotatoes = new Recipe("Mashed Sweet Potatoes", new Dictionary<RawMaterial, int> { { potato, 2}, { salt, 1}, { pepper, 1} });

            recipeSearchTree.Insert(mashedPotatoes);
            recipeSearchTree.Insert(roastedPotatoes);
            recipeSearchTree.Insert(frechFries);
            recipeSearchTree.Insert(potatoSoup);
            recipeSearchTree.Insert(mashedSweetPotatoes);

            Chef chef1 = new Chef("Alice", new List<RawMaterial>());
            Chef chef2 = new Chef("Bob", new List<RawMaterial>());
            Chef chef3 = new Chef("Charlie", new List<RawMaterial>());
            Chef chef4 = new Chef("Dave", new List<RawMaterial>());
            Chef chef5 = new Chef("Jake", new List<RawMaterial>());
            Chef chef6 = new Chef("Paul", new List<RawMaterial>());
            List<Chef> redTeam = new List<Chef> { chef1, chef2, chef3 };
            List<Chef> blueTeam = new List<Chef> { chef4, chef5, chef6 };

            Competition competition = new Competition(redTeam, blueTeam, recipeSearchTree);

            competition.Start();

            /*Console.WriteLine("\nRed Team");
            foreach (Chef chef in redTeam)
            {
                Console.WriteLine(chef.Name + ": ");
                foreach (Recipe recipe in chef.CreatedDishes)
                {
                    Console.WriteLine(" " + recipe.Name);
                }
            }
            Console.WriteLine("\nBlue Team");
            foreach (Chef chef in blueTeam)
            {
                Console.WriteLine(chef.Name + ": ");
                foreach (Recipe recipe in chef.CreatedDishes)
                {
                    Console.WriteLine(" " + recipe.Name);
                }
            }*/

            Console.ReadKey();
        }
    }
}