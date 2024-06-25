using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem_Frank_Bishop
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }
        //this is the issue, change this to fix save issue
        //bool checkedRadio = true;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int partID = int.Parse(textBox1.Text);
            string name = textBox2.Text;
            decimal price = decimal.Parse(textBox4.Text);
            int inventory = int.Parse(textBox3.Text);
            int max = int.Parse(textBox6.Text);
            int min = int.Parse(textBox7.Text);
            
           


            if (radioButton1.Checked)
            {
                string machineID = textBox5.Text;
                int machineIDnum = int.Parse(machineID);
                Part newPart = new Inhouse(partID, name, price, inventory, min, max, machineIDnum);
                Inventory.addPart(newPart);
            }
            else
            {
                string companyName = textBox5.Text;
                Part newPart = new Outsourced(partID, name, price, inventory, min, max, companyName);
                Inventory.addPart(newPart);
            }

            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //checkedRadio = false;
           
            label8.Text = "Company Name";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //checkedRadio = true;
            
            label8.Text = "Machine ID";
        }
    }
}

