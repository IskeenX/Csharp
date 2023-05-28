using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellsKitchen
{
    public class RecipeSearchTreeNode
    {
        public Recipe Recipe { get; set; }
        public RecipeSearchTreeNode Left { get; set; }
        public RecipeSearchTreeNode Right { get; set; }

        public RecipeSearchTreeNode(Recipe recipe)
        {
            Recipe = recipe;
            Left = null;
            Right = null;
        }
    }
}
