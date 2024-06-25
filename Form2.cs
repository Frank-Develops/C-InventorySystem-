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
using System.Xml.Linq;

namespace InventorySystem_Frank_Bishop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int partID;
            decimal price;
            int inventory;
            int max;
            int min;

            try
            {
                partID = int.Parse(textBox1.Text);
                price = decimal.Parse(textBox4.Text);
                inventory = int.Parse(textBox3.Text);
                max = int.Parse(textBox6.Text);
                min = int.Parse(textBox7.Text);
            } catch {

                MessageBox.Show("Part ID, Price, Inventory, Max and Min must all be numbers");
                return;
            }
            partID = int.Parse(textBox1.Text);
            string name = textBox2.Text;
            price = decimal.Parse(textBox4.Text);
            inventory = int.Parse(textBox3.Text);
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

            if (radioButton1.Checked)
            {
                string machineID = textBox5.Text;
                int machineIDnum = int.Parse(machineID);
                Part newPart = new Inhouse(partID, name, price, inventory, min, max, machineIDnum);
                Inventory.addPart(newPart);
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();
            }
            else
            {
                
                string companyName = textBox8.Text;
                Part newPart = new Outsourced(partID, name, price, inventory, min, max, companyName);
                Inventory.addPart(newPart);
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
         
            textBox5.Hide();
            textBox8.Show();
            label8.Text = "Company Name";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
       
            textBox5.Show();
            textBox8.Hide();
            label8.Text = "Machine ID";
        }
    }
}

