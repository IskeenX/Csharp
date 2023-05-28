using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellsKitchen
{
    public class BinarySearchTree
    {
        private class Node
        {
            public int Key { get; set; }
            public List<Recipe> Recipes { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }

        private Node root;

        public void Insert(Recipe recipe, int key)
        {
            Node newNode = new Node { Key = key, Recipes = new List<Recipe> { recipe }, Left = null, Right = null };

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                InsertNode(root, newNode);
            }
        }

        private void InsertNode(Node currentNode, Node newNode)
        {
            if (newNode.Key < currentNode.Key)
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = newNode;
                }
                else
                {
                    InsertNode(currentNode.Left, newNode);
                }
            }
            else if (newNode.Key > currentNode.Key)
            {
                if (currentNode.Right == null)
                {
                    currentNode.Right = newNode;
                }
                else
                {
                    InsertNode(currentNode.Right, newNode);
                }
            }
            else
            {
                currentNode.Recipes.Add(newNode.Recipes[0]);
            }
        }

        public List<Recipe> GetAllRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();
            GetAllRecipes(root, recipes);
            return recipes;
        }

        private void GetAllRecipes(Node currentNode, List<Recipe> recipes)
        {
            if (currentNode != null)
            {
                recipes.AddRange(currentNode.Recipes);
                GetAllRecipes(currentNode.Left, recipes);
                GetAllRecipes(currentNode.Right, recipes);
            }
        }
    }
}