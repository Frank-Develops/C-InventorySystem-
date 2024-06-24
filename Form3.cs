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
    public partial class Form3 : Form
    {
        public Form3(int partID)
        {
            InitializeComponent();
            int partListID = partID;
            Part partModify = Inventory.AllParts[0];

            foreach (Part p in Inventory.AllParts)
            {
                if (p.PartID == partListID)
                {
                    partModify = p;
                    break;
                }
            }

            textBox1.Text = partModify.PartID.ToString();
            textBox2.Text = partModify.Name.ToString();
            textBox3.Text = partModify.InStock.ToString();
            textBox4.Text = partModify.Price.ToString();
            textBox6.Text = partModify.Max.ToString();
            textBox7.Text = partModify.Min.ToString();
            //textBox6.Text = partModify.MachineID.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }
    }
}
