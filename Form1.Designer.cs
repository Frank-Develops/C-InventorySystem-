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
            button8.Location = new Point(320, 28);
            button8.Name = "button8";
            button8.Size = new Size(107, 67);
            button8.TabIndex = 7;
            button8.Text = "Search";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(841, 28);
            button9.Name = "button9";
            button9.Size = new Size(107, 67);
            button9.TabIndex = 8;
            button9.Text = "Search";
            button9.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Part_ID, partName, partInventory, partMin, partMax });
            listView1.Location = new Point(24, 101);
            listView1.Name = "listView1";
            listView1.Size = new Size(605, 249);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1228, 568);
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
            Name = "Form1";
            Text = "Main ";
            ResumeLayout(false);
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
    }
}
