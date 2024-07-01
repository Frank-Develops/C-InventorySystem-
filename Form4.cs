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
            textBox2.Text = Product.productIDNum.ToString();
        }

        BindingList<Part> partsAssociatedAdd = new BindingList<Part>();


        private void addPartProduct_Click(object sender, EventArgs e)
        {

            Part associatedPart = (Part)partsProductGrid.CurrentRow.DataBoundItem;
            partsAssociatedAdd.Add(associatedPart);

        }

        private void cancelProduct_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void saveProduct_Click(object sender, EventArgs e)
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

            productID = Product.productIDNum++;
            string name = textBox3.Text;
            price = decimal.Parse(textBox5.Text);
            inventory = int.Parse(textBox4.Text);
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
            Product addedProduct = new Product(productID, name, price, inventory, min, max);
            Inventory.addProduct(addedProduct);
            foreach (Part p in partsAssociatedAdd)
            {
                addedProduct.addAssociatedPart(p);
            }
            this.Close();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void deletePartProduct_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                foreach (DataGridViewRow partsRow in partsAssociatedGrid.SelectedRows)
                {
                    partsAssociatedGrid.Rows.RemoveAt(partsRow.Index);
                }
            }
            else
            {
                return;
            }
        }

        private void searchAdd_Click(object sender, EventArgs e)
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
                foreach (DataGridViewRow partRow in partsProductGrid.Rows)
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

                foreach (DataGridViewRow partRow in partsProductGrid.Rows)
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
