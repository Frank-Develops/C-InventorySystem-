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
        public BindingList<Part> partsAssociated= new BindingList<Part>();
        public int ProductID { get; set; }
        public String Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public void addAssociatedPart(Part p)
        {
                
            partsAssociated.Add(p);
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
        //public bool removeAssociatedPart(int i)
        //{
        //    Console.WriteLine("this is a test");

        //    return true;
        //}
        //public Part lookupAssociatedPart(int i)
        //{

        //}
    }
}
