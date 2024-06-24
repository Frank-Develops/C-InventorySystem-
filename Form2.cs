﻿using System;
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

        bool checkedRadio = true;

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
           


            if (checkedRadio == true)
            {
                string machineID = textBox5.Text;
                Inventory.addPart(partID, name, price, inventory, max, min, machineID, checkedRadio);
            }
            else
            {
                string companyName = textBox5.Text;
                Inventory.addPart(partID, name, price, inventory, max, min, companyName, checkedRadio);
            }

            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkedRadio = false;
            textBox5.Hide();
            textBox8.Show();
            label8.Text = "Company Name";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkedRadio = true;
            textBox5.Show();
            textBox8.Hide();
            label8.Text = "Machine ID";
        }
    }
}

