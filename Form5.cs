using System;
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
    public partial class Form5 : Form
    {
        BindingList<Part> partsAssociatedAdd = new BindingList<Part>();
        public Form5(int productID)
        {
            InitializeComponent();

            int productIndex = 0;

            Product productModify;

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
            //this is where to put modify product function 
        }
    }
}
