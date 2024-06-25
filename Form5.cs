using System;
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
        //the problem is how I add the associated parts, since it adds them for all item
        //I need to make it so they get linked only to the Product, and still populate in the DataGrid
        int productIndex = 0;
        Product productModify;
        //Product productModify = Inventory.lookupProduct(int.Parse(textBox2.Text));
        public Form5(int productID)
        {
            InitializeComponent();

            //partsAssociatedAdd.Clear();
            //something is happening causing modify product not to get all fields, maybe I need to use lookup product
            //and populate the fields using that
            //also company name not saving with Add
            //associated parts not saving with initial add 

            //Product productModify;

            partsProductGridM.DataSource = Inventory.AllParts;
            //partsAssociatedGridM.DataSource = partsAssociatedAdd;
            //try this
            productModify = Inventory.lookupProduct(productID);
            textBox2.Text = productModify.ProductID.ToString();

            partsAssociatedGridM.DataSource = productModify.partsAssociated;
            //maybe add the rows with a foreach


            partsAssociatedGridM.ReadOnly = true;
            partsProductGridM.ReadOnly = true;
            partsAssociatedGridM.MultiSelect = false;
            partsProductGridM.MultiSelect = false;
            partsAssociatedGridM.AllowUserToAddRows = false;
            partsProductGridM.AllowUserToAddRows = false;
            partsAssociatedGridM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsProductGridM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //foreach (Product p in Inventory.Products)
            //{
            //    if (p.ProductID == productID)
            //    {
            //        productModify = p;
            //        productIndex = Inventory.Products.IndexOf(p);
            //        textBox2.Text = productModify.ProductID.ToString();
            //        textBox3.Text = productModify.Name.ToString();
            //        textBox4.Text = productModify.InStock.ToString();
            //        textBox5.Text = productModify.Price.ToString();
            //        textBox6.Text = productModify.Max.ToString();
            //        textBox7.Text = productModify.Min.ToString();

            //        foreach (Part pa in productModify.partsAssociated)
            //        {
            //            //productModify.addAssociatedPart(pa);
            //            partsAssociatedAdd.Add(pa);
            //        }

            //    }
            //}


        }



        private void button3_Click(object sender, EventArgs e)
        {
            Part associatedPart = (Part)partsProductGridM.CurrentRow.DataBoundItem;
            partsAssociatedAdd.Add(associatedPart);
        }



        private void button4_Click(object sender, EventArgs e)
        {
            //partsAssociatedAdd.Clear();
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
            //partsAssociatedAdd.Clear();
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int partID = int.Parse(partsAssociatedGridM.SelectedRows[0].Cells[0].Value.ToString());
            
            Product removePartP = Inventory.lookupProduct(int.Parse(textBox2.Text));
            
            foreach (Part p in removePartP.partsAssociated.ToList())
            {
                if (p.PartID == partID) {
                    MessageBox.Show(p.PartID.ToString());
                    int pRemove = removePartP.partsAssociated.IndexOf(p);
                    removePartP.removeAssociatedPart(pRemove);
                }

            }
            //int removePart = int.Parse(partsAssociatedGrid.SelectedRows[0].Cells[0].Value.ToString());
            //Part removePartp = Inventory.lookupPart(removePart);



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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
