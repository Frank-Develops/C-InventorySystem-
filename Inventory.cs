﻿using InventorySystem_Frank_Bishop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
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
            AllParts.Add(new Inhouse()
            {
                PartID = 1,
                Name = "Part 1",
                Price = 35.67m,
                InStock = 10,
                Min = 1,
                Max = 20,
                MachineID = 3
            });

            AllParts.Add(new Outsourced()
            {
                PartID = 2,
                Name = "Part 2",
                Price = 40.67M,
                InStock = 5,
                Min = 1,
                Max = 6,
                CompanyName = "The Test"
            });

            AllParts.Add(new Outsourced()
            {
                PartID = 3,
                Name = "Part 3",
                Price = 40.67M,
                InStock = 5,
                Min = 1,
                Max = 6,
                CompanyName = "The Test"
            });

            Products.Add(new Product()
            {
                ProductID = 1,
                Name = "Product 2",
                Price = 70.67M,
                InStock = 4,
                Min = 1,
                Max = 5

            });

            Products.Add(new Product()
            {
                ProductID = 2,
                Name = "Product 3",
                Price = 70.67M,
                InStock = 4,
                Min = 1,
                Max = 5

            });

            Products.Add(new Product()
            {
                ProductID = 3,
                Name = "Product 5",
                Price = 80.67M,
                InStock = 9,
                Min = 1,
                Max = 10

            });

        }
        public static void addProduct(Product p)
        {
            Products.Add(p);
        }
        public static bool removeProduct(int i)
        {
            foreach (Product p in Products)
            {
                if (p.ProductID == i)
                {
                    int remove = Inventory.Products.IndexOf(p);
                    remove = Math.Abs(remove);
                    Inventory.Products.RemoveAt(remove);
                    break;
                }
            }

            return true;
        }

        public static Product lookupProduct(int i)
        {
            foreach (Product p in Inventory.Products)
            {
                if (p.ProductID == i)
                {

                    return p;
                }
            }

            Product noProduct = null;
            return noProduct;
        }

        public static void updateProduct(int i, Product p)
        {
            Inventory.Products[i] = p;
        }

        public static void addPart(Part p)
        {

            AllParts.Add(p);

        }

        static public bool deletePart(Part p)
        {
            foreach (Part pa in Inventory.AllParts)
            {
                if (pa.PartID == p.PartID)
                {

                    int remove = Inventory.AllParts.IndexOf(pa);
                    remove = Math.Abs(remove);
                    Inventory.AllParts.RemoveAt(remove);

                    return true;
                }




            }
            return false;

        }
        public static Part lookupPart(int i)
        {
            foreach (Part p in Inventory.AllParts)
            {
                if (p.PartID == i)
                {

                    return p;
                }
            }

            Part noPart = null;
            return noPart;


        }

        static public void updatePart(int i, Part p)
        {
            AllParts[i] = p;
        }
    }


}





