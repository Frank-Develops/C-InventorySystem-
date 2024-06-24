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
                    }
                    else if (partModify.GetType() == typeof(Outsourced))
                    {
                        Outsourced op = (Outsourced)partModify;
                        //change text box
                        textBox5.Text = op.CompanyName.ToString();
                    }



                }


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Part modifiedPart = new Part(

                int.Parse(textBox1.Text), textBox2.Text, decimal.Parse(textBox4.Text), int.Parse(textBox3.Text), int.Parse(textBox6.Text), int.Parse(textBox7.Text)
                
                
                );

            Inventory.updatePart(partIndex, modifiedPart);
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }
    }
}
