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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox1.Text = Inventory.AllParts[0].PartID.ToString();
            textBox2.Text = Inventory.AllParts[1].PartID.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }
    }
}
