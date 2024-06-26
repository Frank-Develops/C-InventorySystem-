using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventorySystem_Frank_Bishop
{
    public partial class Form3 : Form
    {
        int partIndex = 0;
        public Form3(int partID)
        {
            InitializeComponent();
            int partListID = partID;
            Part partModify;

            foreach (Part p in Inventory.AllParts)
            {
                if (p.PartID == partListID)
                {
                    partModify = p;
                    partIndex = Inventory.AllParts.IndexOf(p);
                    textBox1.Text = partModify.PartID.ToString();
                    textBox2.Text = partModify.Name.ToString();
                    textBox3.Text = partModify.InStock.ToString();
                    textBox4.Text = partModify.Price.ToString();
                    textBox6.Text = partModify.Max.ToString();
                    textBox7.Text = partModify.Min.ToString();

                    if (partModify.GetType() == typeof(Inhouse))
                    {
                        Inhouse ip = (Inhouse)partModify;
                        textBox5.Text = ip.MachineID.ToString();
                        radioButton1.Checked = true;
                    }
                    else if (partModify.GetType() == typeof(Outsourced))
                    {
                        Outsourced op = (Outsourced)partModify;

                        label8.Text = "Company ID";
                        radioButton2.Checked = true;
                        textBox5.Text = op.CompanyName.ToString();
                    }



                }


            }


        }

        private void cancelModifyPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void saveModifyPart_Click(object sender, EventArgs e)
        {

            int partID;
            decimal price;
            int inventory;
            int max;
            int min;
            int partIndex = 0;

            try
            {
                partID = int.Parse(textBox1.Text);
                price = decimal.Parse(textBox4.Text);
                inventory = int.Parse(textBox3.Text);
                max = int.Parse(textBox6.Text);
                min = int.Parse(textBox7.Text);
            }
            catch
            {

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
                foreach (Part p in Inventory.AllParts)
                {

                    if (p.PartID == partID)
                    {
                        partIndex = Inventory.AllParts.IndexOf(p);
                    }
                }
                string machineID = textBox5.Text;
                int machineIDnum = int.Parse(machineID);
                Part newPart = new Inhouse(partID, name, price, inventory, min, max, machineIDnum);
                Inventory.updatePart(partIndex, newPart);
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();
            }
            else
            {
                foreach (Part p in Inventory.AllParts)
                {

                    if (p.PartID == partID)
                    {
                        partIndex = Inventory.AllParts.IndexOf(p);
                    }
                }
                string companyName = textBox5.Text;
                Part newPart = new Outsourced(partID, name, price, inventory, min, max, companyName);
                Inventory.updatePart(partIndex, newPart);
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Machine ID";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Company Name";
        }
    }
}
