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
                //BindingList<Part> partsAssociatedAdd = new BindingList<Part>();


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
                        foreach (Part pa in partsAssociatedAdd)
                    {
                        productModify.addAssociatedPart(pa);
                    }

                }
                }
            
            partsProductGrid.DataSource = Inventory.AllParts;
            //check this line
            partsAssociatedGrid.DataSource = Product.partsAssociated;
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
        
                

        private void button3_Click(object sender, EventArgs e)
        {
            Part associatedPart = (Part)partsProductGrid.CurrentRow.DataBoundItem;
            partsAssociatedAdd.Add(associatedPart);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }
    }
}
