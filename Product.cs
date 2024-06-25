using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem_Frank_Bishop
{
    internal class Product
    {
        public BindingList<Part> AssociatedParts= new BindingList<Part>();
        public int ProductID { get; set; }
        public String Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public void addAssociatedPart(Part p)
        {

            AssociatedParts.Add(p);
        }

        public Product() { }

        public Product(int productID, String name, decimal price, int inStock, int min, int max) {

            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;

        }
        public bool removeAssociatedPart(int i)
        {

            if (i == 0)
            {
                return true;

            }
            return false;
        }

        public Part lookupAssociatedPart(int i)
        {
            foreach (Part p in Inventory.AllParts)
            {
                if(p.PartID == i) {
                    return p;
                }
            }
            Part noPart = null;
            return noPart;

        }
    }
}
