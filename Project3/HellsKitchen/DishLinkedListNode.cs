using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellsKitchen
{
    public class DishLinkedListNode
    {
        public Recipe Recipe { get; set; }
        public DishLinkedListNode Next { get; set; }
    }
}