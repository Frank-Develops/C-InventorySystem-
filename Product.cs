using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem_Frank_Bishop
{
    internal class Product
    {
        public List<Part> AssociatedParts;
        public int ProductID;
        public String Name;
        public decimal Price;
        public int InStock;
        public int Min;
        public int Max;
        public void addAssociatedPart(Part p)
        {
            Console.WriteLine("this is a test");
        }
        public bool removeAssociatedPart(int i)
        {

        }
        public Part lookupAssociatedPart(int i)
        {

        }
    }
}
