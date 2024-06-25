﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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



            //Product productModify;

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

                    foreach (Part pa in productModify.partsAssociated)
                    {
                        //productModify.addAssociatedPart(pa);
                        partsAssociatedAdd.Add(pa);
                    }

                }
            }


        }



        private void button3_Click(object sender, EventArgs e)
        {
            Part associatedPart = (Part)partsProductGridM.CurrentRow.DataBoundItem;
            partsAssociatedAdd.Add(associatedPart);
        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            int productID = int.Parse(textBox2.Text);
            string productName = textBox3.Text;
            int inventory = int.Parse(textBox4.Text);
            decimal price = decimal.Parse(textBox5.Text);
            int maxNum = int.Parse(textBox6.Text);
            int minNum = int.Parse(textBox7.Text);

            Product modifyProduct = new Product(productID, productName, price, inventory, minNum, maxNum);
            foreach (Part pa in partsAssociatedAdd)
            {
                modifyProduct.partsAssociated.Add(pa);
            }
            Inventory.updateProduct(productIndex, modifyProduct);
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string partIDString = partsAssociatedGridM.SelectedRows[0].Cells[0].Value.ToString();
            int partID = int.Parse(partIDString);
            productModify.removeAssociatedPart(partID);
            //foreach (Part p in productModify.partsAssociated)
            //{
            //    if (p.PartID == partID)
            //    {
            //        int removeIndex = productModify.partsAssociated.IndexOf(p);
            //        productModify.removeAssociatedPart(removeIndex);
            //        partsAssociatedGridM.Update();
            //        partsAssociatedGridM.Refresh();

            //    }
            //}



        }

        private void button5_Click(object sender, EventArgs e)
        {
            int search = int.Parse(textBox1.Text);
            Part searchPart = Inventory.lookupPart(search);

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
    }
}
