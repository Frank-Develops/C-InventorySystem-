﻿namespace InventorySystem_Frank_Bishop
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            modifyPart = new Button();
            deletePart = new Button();
            addProduct = new Button();
            addPart = new Button();
            modifyProduct = new Button();
            deleteProduct = new Button();
            button7 = new Button();
            searchButton = new Button();
            searchButton2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            partsGrid = new DataGridView();
            partID = new DataGridViewTextBoxColumn();
            partName = new DataGridViewTextBoxColumn();
            partInventory = new DataGridViewTextBoxColumn();
            partPrice = new DataGridViewTextBoxColumn();
            partMin = new DataGridViewTextBoxColumn();
            partMax = new DataGridViewTextBoxColumn();
            productsGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)partsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsGrid).BeginInit();
            SuspendLayout();
            // 
            // modifyPart
            // 
            modifyPart.Location = new Point(360, 356);
            modifyPart.Name = "modifyPart";
            modifyPart.Size = new Size(97, 78);
            modifyPart.TabIndex = 0;
            modifyPart.Text = "Modify";
            modifyPart.UseVisualStyleBackColor = true;
            modifyPart.Click += modifyPart_Click;
            // 
            // deletePart
            // 
            deletePart.Location = new Point(475, 356);
            deletePart.Name = "deletePart";
            deletePart.Size = new Size(97, 78);
            deletePart.TabIndex = 1;
            deletePart.Text = "Delete";
            deletePart.UseVisualStyleBackColor = true;
            deletePart.Click += deletePart_Click;
            // 
            // addProduct
            // 
            addProduct.Location = new Point(775, 356);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(97, 78);
            addProduct.TabIndex = 2;
            addProduct.Text = "Add";
            addProduct.UseVisualStyleBackColor = true;
            addProduct.Click += addProduct_Click;
            // 
            // addPart
            // 
            addPart.Location = new Point(245, 356);
            addPart.Name = "addPart";
            addPart.Size = new Size(97, 78);
            addPart.TabIndex = 3;
            addPart.Text = "Add";
            addPart.UseVisualStyleBackColor = true;
            addPart.Click += addPart_Click;
            // 
            // modifyProduct
            // 
            modifyProduct.Location = new Point(887, 356);
            modifyProduct.Name = "modifyProduct";
            modifyProduct.Size = new Size(97, 78);
            modifyProduct.TabIndex = 4;
            modifyProduct.Text = "Modify";
            modifyProduct.UseVisualStyleBackColor = true;
            modifyProduct.Click += modifyProduct_Click;
            // 
            // deleteProduct
            // 
            deleteProduct.Location = new Point(1001, 356);
            deleteProduct.Name = "deleteProduct";
            deleteProduct.Size = new Size(97, 78);
            deleteProduct.TabIndex = 5;
            deleteProduct.Text = "Delete";
            deleteProduct.UseVisualStyleBackColor = true;
            deleteProduct.Click += deleteProduct_Click;
            // 
            // button7
            // 
            button7.Location = new Point(1001, 486);
            button7.Name = "button7";
            button7.Size = new Size(123, 62);
            button7.TabIndex = 6;
            button7.Text = "Exit";
            button7.UseVisualStyleBackColor = true;
            button7.Click += exit_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(283, 28);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(107, 67);
            searchButton.TabIndex = 7;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchButton2
            // 
            searchButton2.Location = new Point(812, 28);
            searchButton2.Name = "searchButton2";
            searchButton2.Size = new Size(107, 67);
            searchButton2.TabIndex = 8;
            searchButton2.Text = "Search";
            searchButton2.UseVisualStyleBackColor = true;
            searchButton2.Click += searchButton2_Click;
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
            // partsGrid
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            partsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            partsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsGrid.Columns.AddRange(new DataGridViewColumn[] { partID, partName, partInventory, partPrice, partMin, partMax });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            partsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            partsGrid.Location = new Point(37, 145);
            partsGrid.Name = "partsGrid";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            partsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            partsGrid.RowHeadersVisible = false;
            partsGrid.ScrollBars = ScrollBars.Vertical;
            partsGrid.Size = new Size(580, 188);
            partsGrid.TabIndex = 24;
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
            // productsGrid
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            productsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            productsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            productsGrid.DefaultCellStyle = dataGridViewCellStyle5;
            productsGrid.Location = new Point(636, 145);
            productsGrid.Name = "productsGrid";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            productsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            productsGrid.RowHeadersVisible = false;
            productsGrid.ScrollBars = ScrollBars.Vertical;
            productsGrid.Size = new Size(580, 188);
            productsGrid.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            dataGridViewTextBoxColumn1.HeaderText = "Product ID";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1228, 568);
            Controls.Add(productsGrid);
            Controls.Add(partsGrid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(searchButton2);
            Controls.Add(searchButton);
            Controls.Add(button7);
            Controls.Add(deleteProduct);
            Controls.Add(modifyProduct);
            Controls.Add(addPart);
            Controls.Add(addProduct);
            Controls.Add(deletePart);
            Controls.Add(modifyPart);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            Text = "Main ";
            ((System.ComponentModel.ISupportInitialize)partsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addPart;
        private Button modifyPart;
        private Button deletePart;
        private Button addProduct;
        private Button modifyProduct;
        private Button deleteProduct;
        private Button button7;
        private Button searchButton;
        private Button searchButton2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView partsGrid;
        private DataGridView productsGrid;
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
