﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem_Frank_Bishop
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            partsProductGrid.DataSource = Inventory.AllParts;
            partsAssociatedGrid.DataSource = partsAssociatedAdd;
            partsProductGrid.ReadOnly = true;
            partsAssociatedGrid.ReadOnly = true;
            partsProductGrid.MultiSelect = false;
            partsAssociatedGrid.MultiSelect = false;
            partsProductGrid.AllowUserToAddRows = false;
            partsAssociatedGrid.AllowUserToAddRows = false;
            partsProductGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsAssociatedGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        BindingList<Part> partsAssociatedAdd = new BindingList<Part>();


        private void button3_Click(object sender, EventArgs e)
        {
           
            Part associatedPart = (Part)partsProductGrid.CurrentRow.DataBoundItem;
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
            string name = textBox3.Text;
            decimal price = decimal.Parse(textBox5.Text);
            int inventory = int.Parse(textBox4.Text);
            int max = int.Parse(textBox6.Text);
            int min = int.Parse(textBox7.Text);
            Product addedProduct = new Product(productID, name, price, inventory, min, max);
            Inventory.addProduct(addedProduct);
            foreach (Part p in partsAssociatedAdd)
            {
                addedProduct.addAssociatedPart(p);
            }
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                foreach (DataGridViewRow partsRow in partsAssociatedGrid.SelectedRows)
                {
                    partsAssociatedGrid.Rows.RemoveAt(partsRow.Index);
                }
            } else
            {
                return;
            }
        }
    }
}
