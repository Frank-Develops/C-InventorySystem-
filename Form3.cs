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
            Part partModify;

            foreach (Part p in Inventory.AllParts)
            {
                if (p.PartID == partListID)
                {
                    partModify = p;               
                    textBox1.Text = partModify.PartID.ToString();
                    textBox2.Text = partModify.Name.ToString();
                    textBox3.Text = partModify.InStock.ToString();
                    textBox4.Text = partModify.Price.ToString();
                    textBox6.Text = partModify.Max.ToString();
                    textBox7.Text = partModify.Min.ToString();
                    
                    if(partModify.GetType() == typeof(Inhouse))
                    {
                        Inhouse ip = (Inhouse)partModify;
                        textBox5.Text = ip.MachineID.ToString();
                    } else if(partModify.GetType() == typeof(Outsourced))
                    {
                        Outsourced op = (Outsourced)partModify;
                        textBox5.Text = op.CompanyName.ToString();
                    }
                    
                    

                }


            }

            //textBox1.Text = partModify.PartID.ToString();
            //textBox2.Text = partModify.Name.ToString();
            //textBox3.Text = partModify.InStock.ToString();
            //textBox4.Text = partModify.Price.ToString();
            //textBox6.Text = partModify.Max.ToString();
            //textBox7.Text = partModify.Min.ToString();

            //maybe do if/else to determine if it is a Inhouse or Outsourced and include textboxes in those 

            //textBox5.Text = partModify.CompanyName.ToString();
            //if(partModify.MachineID)
            //{

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }
    }
}
