using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace HellsKitchen
{
    public class RecipeSearchTree
    {
        public RecipeSearchTreeNode Root { get; set; }

        public RecipeSearchTree()
        {
            Root = null;
        }

        public void Insert(Recipe recipe)
        {
            if (Root == null)
            {
                Root = new RecipeSearchTreeNode(recipe);
                return;
            }

            RecipeSearchTreeNode current = Root;
            while (current != null)
            {
                if(string.Compare(recipe.Name, current.Recipe.Name) < 0)
                {
                    if(current.Left == null)
                    {
                        current.Left = new RecipeSearchTreeNode(recipe);
                        return;
                    }
                    current = current.Left;
                }
                else
                {
                    if(current.Right == null)
                    {
                        current.Right = new RecipeSearchTreeNode(recipe);
                        return;
                    }
                    current = current.Right;
                }
            }
        }
    }
}