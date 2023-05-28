using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellsKitchen
{
    public class DishLinkedList
    {
        private DishLinkedListNode head;

        public bool IsEmpty()
        {
            return head == null;
        }

        public void Add(Recipe recipe)
        {
            DishLinkedListNode newNode = new DishLinkedListNode { Recipe = recipe, Next = null };

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                DishLinkedListNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public int GetDishCount()
        {
            int count = 0;
            DishLinkedListNode current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
    }
}