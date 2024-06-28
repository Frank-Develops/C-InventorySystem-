using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem_Frank_Bishop
{
    abstract class Part
    {
        public int PartID { get; set; }

        public static int partIDNum = 4;
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        public Part() { }
        public Part(int partID, string name, decimal price, int inStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
    }
}


