using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellsKitchen
{
    public class DishNode
    {
        public Recipe Recipe { get; set; }
        public DishNode Next { get; set; }
    }
}