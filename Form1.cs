using System.Windows.Forms;

namespace InventorySystem_Frank_Bishop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            Form3 modifyParts = new Form3();
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
    }
}
