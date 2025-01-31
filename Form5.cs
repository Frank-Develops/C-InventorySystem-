﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem_Frank_Bishop
{
    public partial class Form5 : Form
    {
        BindingList<Part> partsAssociatedAdd = new BindingList<Part>();
        int productIndex = 0;
        Product productModify;

        public Form5(int productID)
        {
            InitializeComponent();


            partsProductGridM.DataSource = Inventory.AllParts;
            partsAssociatedGridM.DataSource = partsAssociatedAdd;

            partsAssociatedGridM.ReadOnly = true;
            partsProductGridM.ReadOnly = true;
            partsAssociatedGridM.MultiSelect = false;
            partsProductGridM.MultiSelect = false;
            partsAssociatedGridM.AllowUserToAddRows = false;
            partsProductGridM.AllowUserToAddRows = false;
            partsAssociatedGridM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsProductGridM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (Product p in Inventory.Products)
            {
                if (p.ProductID == productID)
                {
                    productModify = p;
                    productIndex = Inventory.Products.IndexOf(p);
                    textBox2.Text = productModify.ProductID.ToString();
                    textBox3.Text = productModify.Name.ToString();
                    textBox4.Text = productModify.InStock.ToString();
                    textBox5.Text = productModify.Price.ToString();
                    textBox6.Text = productModify.Max.ToString();
                    textBox7.Text = productModify.Min.ToString();

                    foreach (Part pa in productModify.AssociatedParts)
                    {
                        partsAssociatedAdd.Add(pa);
                    }

                }
            }


        }



        private void addToProduct_Click(object sender, EventArgs e)
        {
            string lookUps = partsProductGridM.SelectedRows[0].Cells[0].Value.ToString();
            int lookUp = int.Parse(lookUps);
            Part addedPart = productModify.lookupAssociatedPart(lookUp);
            partsAssociatedAdd.Add(addedPart);
        }



        private void cancelModify_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void saveModifyProduct_Click(object sender, EventArgs e)

        {
            int productID;
            decimal price;
            int inventory;
            int max;
            int min;

            try
            {
                productID = int.Parse(textBox2.Text);

                price = decimal.Parse(textBox5.Text);
                inventory = int.Parse(textBox4.Text);
                max = int.Parse(textBox6.Text);
                min = int.Parse(textBox7.Text);
            }
            catch
            {
                MessageBox.Show("Product ID, Price, Inventory, Max and Min must all be numbers");
                return;
            }

            productID = int.Parse(textBox2.Text);
            string productName = textBox3.Text;
            inventory = int.Parse(textBox4.Text);
            price = decimal.Parse(textBox5.Text);
            max = int.Parse(textBox6.Text);
            min = int.Parse(textBox7.Text);

            if (min > max)
            {
                MessageBox.Show("min must be smaller than max");
                return;
            }

            if (inventory < min || inventory > max)
            {
                MessageBox.Show("Inventory number must be between min and max");
                return;
            }

            Product modifyProduct = new Product(productID, productName, price, inventory, min, max);
            foreach (Product p in Inventory.Products)
            {

                if (p.ProductID == productID)
                {
                    productIndex = Inventory.Products.IndexOf(p);
                }
            }

            foreach (Part pa in partsAssociatedAdd)
            {
                modifyProduct.AssociatedParts.Add(pa);
            }
            Inventory.updateProduct(productIndex, modifyProduct);
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();


        }

        private void deleteFromProduct_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {

                foreach (DataGridViewRow partsRow in partsAssociatedGridM.SelectedRows)
                {
                    partsAssociatedGridM.Rows.RemoveAt(partsRow.Index);
                    productModify.removeAssociatedPart(0);
                }
            }
            else
            {
                return;
            }

        }

        private void searchModify_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            try
            {
                int searchInt = int.Parse(search);
                Part searchPart = Inventory.lookupPart(searchInt);
                if (searchPart == null)
                {
                    MessageBox.Show("No Part Found");
                    return;
                }
                foreach (DataGridViewRow partRow in partsProductGridM.Rows)
                {

                    string partIDString = partRow.Cells[0].Value.ToString();
                    int partID = int.Parse(partIDString);

                    if (partID == searchPart.PartID)
                    {
                        partRow.Selected = true;

                        break;
                    }
                }

            }
            catch
            {

                foreach (DataGridViewRow partRow in partsProductGridM.Rows)
                {


                    string partName = partRow.Cells[1].Value.ToString();



                    if (partName == search)
                    {
                        partRow.Selected = true;

                        return;
                    }
                }
                MessageBox.Show("No Part Found");

            }
        }
    }
}
