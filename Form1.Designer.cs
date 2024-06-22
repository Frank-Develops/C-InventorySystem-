namespace InventorySystem_Frank_Bishop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            listView1 = new ListView();
            Part_ID = new ColumnHeader();
            partName = new ColumnHeader();
            partInventory = new ColumnHeader();
            partMin = new ColumnHeader();
            partMax = new ColumnHeader();
            listView2 = new ListView();
            productID = new ColumnHeader();
            productName = new ColumnHeader();
            productInventory = new ColumnHeader();
            productMin = new ColumnHeader();
            productMax = new ColumnHeader();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(360, 356);
            button2.Name = "button2";
            button2.Size = new Size(97, 78);
            button2.TabIndex = 0;
            button2.Text = "Modify";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(475, 356);
            button3.Name = "button3";
            button3.Size = new Size(97, 78);
            button3.TabIndex = 1;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(775, 356);
            button4.Name = "button4";
            button4.Size = new Size(97, 78);
            button4.TabIndex = 2;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(245, 356);
            button1.Name = "button1";
            button1.Size = new Size(97, 78);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(887, 356);
            button5.Name = "button5";
            button5.Size = new Size(97, 78);
            button5.TabIndex = 4;
            button5.Text = "Modify";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(1001, 356);
            button6.Name = "button6";
            button6.Size = new Size(97, 78);
            button6.TabIndex = 5;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(1001, 486);
            button7.Name = "button7";
            button7.Size = new Size(123, 62);
            button7.TabIndex = 6;
            button7.Text = "Exit";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(283, 28);
            button8.Name = "button8";
            button8.Size = new Size(107, 67);
            button8.TabIndex = 7;
            button8.Text = "Search";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(812, 28);
            button9.Name = "button9";
            button9.Size = new Size(107, 67);
            button9.TabIndex = 8;
            button9.Text = "Search";
            button9.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Part_ID, partName, partInventory, partMin, partMax });
            listView1.Location = new Point(11, 101);
            listView1.Name = "listView1";
            listView1.Size = new Size(592, 249);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Part_ID
            // 
            Part_ID.Text = "Part ID";
            Part_ID.Width = 120;
            // 
            // partName
            // 
            partName.Text = "Name";
            partName.Width = 120;
            // 
            // partInventory
            // 
            partInventory.Text = "Inventory";
            partInventory.Width = 120;
            // 
            // partMin
            // 
            partMin.Text = "Min";
            partMin.Width = 120;
            // 
            // partMax
            // 
            partMax.Text = "Max";
            partMax.Width = 120;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { productID, productName, productInventory, productMin, productMax });
            listView2.Location = new Point(625, 101);
            listView2.Name = "listView2";
            listView2.Size = new Size(591, 249);
            listView2.TabIndex = 10;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // productID
            // 
            productID.Text = "Product ID";
            productID.Width = 120;
            // 
            // productName
            // 
            productName.Text = "Name";
            productName.Width = 120;
            // 
            // productInventory
            // 
            productInventory.Text = "Inventory";
            productInventory.Width = 120;
            // 
            // productMin
            // 
            productMin.Text = "Min";
            productMin.Width = 120;
            // 
            // productMax
            // 
            productMax.Text = "Max";
            productMax.Width = 120;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(396, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(925, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 23);
            textBox2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 21);
            label1.TabIndex = 13;
            label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(24, 70);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 14;
            label2.Text = "Parts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(644, 70);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 15;
            label3.Text = "Products";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1228, 568);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            Text = "Main ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private ListView listView1;
        private ColumnHeader Part_ID;
        private ColumnHeader partName;
        private ColumnHeader partInventory;
        private ColumnHeader partMin;
        private ColumnHeader partMax;
        private ListView listView2;
        private ColumnHeader productID;
        private ColumnHeader productName;
        private ColumnHeader productInventory;
        private ColumnHeader productMin;
        private ColumnHeader productMax;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
