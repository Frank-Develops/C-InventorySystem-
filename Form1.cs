using System.Globalization;
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 addParts = new Form2();
            addParts.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            string partIDString = partsGrid.SelectedRows[0].Cells[0].Value.ToString();
            int partID = int.Parse(partIDString);
            Form3 modifyParts = new Form3(partID);
            modifyParts.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 addProduct = new Form4();
            addProduct.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 modifyProduct = new Form5();
            modifyProduct.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(partsGrid.SelectedRows[0].Cells[2].Value.ToString());
            string partIDString = partsGrid.SelectedRows[0].Cells[0].Value.ToString();
            int partID = int.Parse(partIDString);
            string partName = partsGrid.SelectedRows[0].Cells[1].Value.ToString();
            string inventory = partsGrid.SelectedRows[0].Cells[3].Value.ToString();
            int inventoryNum = int.Parse(inventory);
            //string partPrice = partsGrid.SelectedRows[0].Cells[3].Value.ToString();
            decimal price = Convert.ToDecimal(partsGrid.SelectedRows[0].Cells[2].Value.ToString());
            string minP = partsGrid.SelectedRows[0].Cells[4].Value.ToString();
            int minPNum = int.Parse(minP);
            string maxP = partsGrid.SelectedRows[0].Cells[5].Value.ToString();
            int maxPNum = int.Parse(maxP);

            Part deletePart = new Part(partID, partName, price, inventoryNum, minPNum, maxPNum);
            Inventory.deletePart(deletePart);
            partsGrid.Update();
            partsGrid.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string productIDString = productsGrid.SelectedRows[0].Cells[0].Value.ToString();
            int productID = int.Parse(productIDString);
            Inventory.removeProduct(productID);
        }
    }
}
