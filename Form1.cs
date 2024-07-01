using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace InventorySystem_Frank_Bishop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            partsGrid.DataSource = Inventory.AllParts;
            productsGrid.DataSource = Inventory.Products;
            partsGrid.ReadOnly = true;
            productsGrid.ReadOnly = true;
            partsGrid.MultiSelect = false;
            productsGrid.MultiSelect = false;
            partsGrid.AllowUserToAddRows = false;
            productsGrid.AllowUserToAddRows = false;
            partsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void searchButton_Click(object sender, EventArgs e)
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
                foreach (DataGridViewRow partRow in partsGrid.Rows)
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

                foreach (DataGridViewRow partRow in partsGrid.Rows)
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

        private void addPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 addParts = new Form2();
            addParts.Show();
        }

        private void modifyPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            string partIDString = partsGrid.SelectedRows[0].Cells[0].Value.ToString();
            int partID = int.Parse(partIDString);
            Form3 modifyParts = new Form3(partID);
            modifyParts.Show();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 addProduct = new Form4();
            addProduct.Show();
        }

        private void modifyProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productIDString = productsGrid.SelectedRows[0].Cells[0].Value.ToString();
            int productID = int.Parse(productIDString);
            Form5 modifyProduct = new Form5(productID);
            modifyProduct.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deletePart_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this part?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                string partIDString = partsGrid.SelectedRows[0].Cells[0].Value.ToString();
                int partID = int.Parse(partIDString);
                Part deletePart = Inventory.lookupPart(partID);

                foreach (Product pr in Inventory.Products)
                {
                    foreach (Part pa in pr.AssociatedParts)
                        if (pa.PartID == partID)
                        {
                            MessageBox.Show("cannot delete part since it is associated with a product");
                            return;
                        }
                }
                Inventory.deletePart(deletePart);
                partsGrid.Update();
                partsGrid.Refresh();
            }
            else
            {
                return;
            }
        }


        private void deleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {

                string productIDString = productsGrid.SelectedRows[0].Cells[0].Value.ToString();
                int productID = int.Parse(productIDString);
                Inventory.removeProduct(productID);
            }
            else
            {
                return;
            }
        }

        private void searchButton2_Click(object sender, EventArgs e)
        {
            int search = int.Parse(textBox2.Text);
            Product searchProduct = Inventory.lookupProduct(search);

            foreach (DataGridViewRow productRow in productsGrid.Rows)
            {

                string productIDString = productRow.Cells[0].Value.ToString();
                int productID = int.Parse(productIDString);


                if (productID == searchProduct.ProductID)
                {
                    productRow.Selected = true;

                    break;
                }
            }




        }
    }
}
