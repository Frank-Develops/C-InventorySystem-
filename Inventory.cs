using InventorySystem_Frank_Bishop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InventorySystem_Frank_Bishop
{
    internal class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        
        public static BindingList<Part> AllParts = new BindingList<Part>();
        static Inventory()
        {
            AllParts.Add(new Part()
            {
                PartID = 1,
                Name = "Part 1",
                Price = 35.67M,
                InStock = 10,
                Min = 1,
                Max = 2
            });

            AllParts.Add(new Part()
            {
                PartID = 2,
                Name = "Part 2",
                Price = 40.67M,
                InStock = 5,
                Min = 1,
                Max = 5
            });

            Products.Add(new Product()
            {
                ProductID = 3,
                Name = "Product 2",
                Price = 70.67M,
                InStock = 4,
                Min = 1,
                Max = 3

            });

            Products.Add(new Product()
            {
                ProductID = 1,
                Name = "Product 5",
                Price = 80.67M,
                InStock = 9,
                Min = 1,
                Max = 3

            });

        }
        //public void addProduct(Product p)
        //{

        //}
        //public bool removeProduct(int i)
        //{

        //}

        //public Product lookupProduct(int i)
        //{

        //}

        //public void updateProduct(int i, Product p)
        //{

        //}

        //public void addPart(Part p)
        public static void addPart(int partID, string name, decimal price, int inStock, int min, int max, int MachineID)
        {
            AllParts.Add(new Inhouse(partID, name, price, inStock, min, max, MachineID));
        }

        //public bool deletePart(Part p)
        //{

        //}

        //public Part lookupPart(int i)
        //{

        //}

        //public void updatePart(int i, Part p)
        //{

        //}

    }
}



