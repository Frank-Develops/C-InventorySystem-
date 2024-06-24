namespace InventorySystem_Frank_Bishop
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        private void InitializeComponent()
        {
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "Modify Part";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F);
            radioButton1.Location = new Point(261, 28);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(91, 25);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "In-House";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F);
            radioButton2.Location = new Point(405, 28);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(109, 25);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Outsourced";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(472, 454);
            button1.Name = "button1";
            button1.Size = new Size(95, 75);
            button1.TabIndex = 3;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(611, 454);
            button2.Name = "button2";
            button2.Size = new Size(95, 75);
            button2.TabIndex = 4;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(395, 401);
            textBox5.MinimumSize = new Size(1, 1);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(224, 23);
            textBox5.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(363, 98);
            textBox1.MinimumSize = new Size(1, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(363, 161);
            textBox2.MinimumSize = new Size(1, 1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(363, 226);
            textBox3.MinimumSize = new Size(1, 1);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(224, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(363, 296);
            textBox4.MinimumSize = new Size(1, 1);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(224, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(363, 353);
            textBox6.MinimumSize = new Size(1, 1);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(134, 23);
            textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(593, 353);
            textBox7.MinimumSize = new Size(1, 1);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(134, 23);
            textBox7.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(270, 100);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 16;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(270, 163);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 17;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(270, 228);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 18;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(270, 298);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 19;
            label5.Text = "Price/Cost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(270, 355);
            label6.Name = "label6";
            label6.Size = new Size(39, 21);
            label6.TabIndex = 20;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(542, 355);
            label7.Name = "label7";
            label7.Size = new Size(37, 21);
            label7.TabIndex = 21;
            label7.Text = "Min";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(270, 399);
            label8.Name = "label8";
            label8.Size = new Size(88, 21);
            label8.TabIndex = 22;
            label8.Text = "Machine ID";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(739, 561);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Modify Part";
            ResumeLayout(false);
            PerformLayout();
        }

        //#endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
        private TextBox textBox5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    //private void InitializeComponent()
    //    {
    //        SuspendLayout();
    //        // 
    //        // Form3
    //        // 
    //        AutoScaleDimensions = new SizeF(7F, 15F);
    //        AutoScaleMode = AutoScaleMode.Font;
    //        BackColor = SystemColors.ActiveBorder;
    //        ClientSize = new Size(800, 450);
    //        Name = "Form3";
    //        Text = "Form3";
    //        ResumeLayout(false);
    //    }

        #endregion
    }
