﻿namespace InventorySystem_Frank_Bishop
{
    partial class Form4
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            saveProduct = new Button();
            deletePartProduct = new Button();
            addPartProduct = new Button();
            cancelProduct = new Button();
            label8 = new Label();
            label9 = new Label();
            searchAdd = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            partsProductGrid = new DataGridView();
            partID = new DataGridViewTextBoxColumn();
            partName = new DataGridViewTextBoxColumn();
            partInventory = new DataGridViewTextBoxColumn();
            partPrice = new DataGridViewTextBoxColumn();
            partMin = new DataGridViewTextBoxColumn();
            partMax = new DataGridViewTextBoxColumn();
            partsAssociatedGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)partsProductGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partsAssociatedGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(22, 195);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(22, 244);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(22, 308);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 3;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(22, 365);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 4;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(22, 425);
            label6.Name = "label6";
            label6.Size = new Size(39, 21);
            label6.TabIndex = 5;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(220, 425);
            label7.Name = "label7";
            label7.Size = new Size(37, 21);
            label7.TabIndex = 6;
            label7.Text = "Min";
            // 
            // saveProduct
            // 
            saveProduct.Font = new Font("Segoe UI", 12F);
            saveProduct.Location = new Point(804, 594);
            saveProduct.Name = "saveProduct";
            saveProduct.Size = new Size(79, 43);
            saveProduct.TabIndex = 7;
            saveProduct.Text = "Save";
            saveProduct.UseVisualStyleBackColor = true;
            saveProduct.Click += saveProduct_Click;
            // 
            // deletePartProduct
            // 
            deletePartProduct.Font = new Font("Segoe UI", 12F);
            deletePartProduct.Location = new Point(917, 538);
            deletePartProduct.Name = "deletePartProduct";
            deletePartProduct.Size = new Size(73, 50);
            deletePartProduct.TabIndex = 8;
            deletePartProduct.Text = "Delete";
            deletePartProduct.UseVisualStyleBackColor = true;
            deletePartProduct.Click += deletePartProduct_Click;
            // 
            // addPartProduct
            // 
            addPartProduct.Font = new Font("Segoe UI", 12F);
            addPartProduct.Location = new Point(917, 273);
            addPartProduct.Name = "addPartProduct";
            addPartProduct.Size = new Size(73, 51);
            addPartProduct.TabIndex = 9;
            addPartProduct.Text = "Add";
            addPartProduct.UseVisualStyleBackColor = true;
            addPartProduct.Click += addPartProduct_Click;
            // 
            // cancelProduct
            // 
            cancelProduct.Font = new Font("Segoe UI", 12F);
            cancelProduct.Location = new Point(901, 594);
            cancelProduct.Name = "cancelProduct";
            cancelProduct.Size = new Size(89, 43);
            cancelProduct.TabIndex = 10;
            cancelProduct.Text = "Cancel";
            cancelProduct.UseVisualStyleBackColor = true;
            cancelProduct.Click += cancelProduct_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(395, 308);
            label8.Name = "label8";
            label8.Size = new Size(238, 21);
            label8.TabIndex = 13;
            label8.Text = "Parts associated with the product";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(395, 39);
            label9.Name = "label9";
            label9.Size = new Size(140, 21);
            label9.TabIndex = 14;
            label9.Text = "All Candidate Parts";
            // 
            // searchAdd
            // 
            searchAdd.Location = new Point(646, 12);
            searchAdd.Name = "searchAdd";
            searchAdd.Size = new Size(75, 23);
            searchAdd.TabIndex = 15;
            searchAdd.Text = "Search";
            searchAdd.UseVisualStyleBackColor = true;
            searchAdd.Click += searchAdd_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(746, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 23);
            textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 197);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(206, 23);
            textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(122, 246);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(206, 23);
            textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(122, 308);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(206, 23);
            textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(122, 367);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(206, 23);
            textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(95, 423);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(88, 23);
            textBox6.TabIndex = 21;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(274, 423);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(88, 23);
            textBox7.TabIndex = 22;
            // 
            // partsProductGrid
            // 
            partsProductGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsProductGrid.Columns.AddRange(new DataGridViewColumn[] { partID, partName, partInventory, partPrice, partMin, partMax });
            partsProductGrid.Location = new Point(393, 79);
            partsProductGrid.Name = "partsProductGrid";
            partsProductGrid.RowHeadersVisible = false;
            partsProductGrid.ScrollBars = ScrollBars.Vertical;
            partsProductGrid.Size = new Size(603, 188);
            partsProductGrid.TabIndex = 23;
            // 
            // partID
            // 
            partID.DataPropertyName = "PartID";
            partID.HeaderText = "Part ID";
            partID.Name = "partID";
            // 
            // partName
            // 
            partName.DataPropertyName = "Name";
            partName.HeaderText = "Name";
            partName.Name = "partName";
            // 
            // partInventory
            // 
            partInventory.DataPropertyName = "InStock";
            partInventory.HeaderText = "Inventory";
            partInventory.Name = "partInventory";
            // 
            // partPrice
            // 
            partPrice.DataPropertyName = "Price";
            partPrice.HeaderText = "Price";
            partPrice.Name = "partPrice";
            // 
            // partMin
            // 
            partMin.DataPropertyName = "Min";
            partMin.HeaderText = "Min";
            partMin.Name = "partMin";
            // 
            // partMax
            // 
            partMax.DataPropertyName = "Max";
            partMax.HeaderText = "Max";
            partMax.Name = "partMax";
            // 
            // partsAssociatedGrid
            // 
            partsAssociatedGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsAssociatedGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            partsAssociatedGrid.Location = new Point(393, 344);
            partsAssociatedGrid.Name = "partsAssociatedGrid";
            partsAssociatedGrid.RowHeadersVisible = false;
            partsAssociatedGrid.ScrollBars = ScrollBars.Vertical;
            partsAssociatedGrid.Size = new Size(603, 188);
            partsAssociatedGrid.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "PartID";
            dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "InStock";
            dataGridViewTextBoxColumn3.HeaderText = "Inventory";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            dataGridViewTextBoxColumn4.HeaderText = "Price";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Min";
            dataGridViewTextBoxColumn5.HeaderText = "Min";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Max";
            dataGridViewTextBoxColumn6.HeaderText = "Max";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1063, 643);
            Controls.Add(partsAssociatedGrid);
            Controls.Add(partsProductGrid);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(searchAdd);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(cancelProduct);
            Controls.Add(addPartProduct);
            Controls.Add(deletePartProduct);
            Controls.Add(saveProduct);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)partsProductGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)partsAssociatedGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button saveProduct;
        private Button deletePartProduct;
        private Button addPartProduct;
        private Button cancelProduct;
        private Label label8;
        private Label label9;
        private Button searchAdd;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private DataGridView partsProductGrid;
        private DataGridView partsAssociatedGrid;
        private DataGridViewTextBoxColumn partID;
        private DataGridViewTextBoxColumn partName;
        private DataGridViewTextBoxColumn partInventory;
        private DataGridViewTextBoxColumn partPrice;
        private DataGridViewTextBoxColumn partMin;
        private DataGridViewTextBoxColumn partMax;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}