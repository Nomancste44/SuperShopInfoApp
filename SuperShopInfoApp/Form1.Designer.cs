namespace SuperShopInfoApp
{
    partial class SuperShopForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shopNameTextBox = new System.Windows.Forms.TextBox();
            this.shopAddressTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemIdTextBox = new System.Windows.Forms.TextBox();
            this.itemQuantiyTextBox = new System.Windows.Forms.TextBox();
            this.itemAddButton = new System.Windows.Forms.Button();
            this.showDetailsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.shopAddressTextBox);
            this.groupBox1.Controls.Add(this.shopNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shop Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address";
            // 
            // shopNameTextBox
            // 
            this.shopNameTextBox.Location = new System.Drawing.Point(102, 13);
            this.shopNameTextBox.Name = "shopNameTextBox";
            this.shopNameTextBox.Size = new System.Drawing.Size(178, 20);
            this.shopNameTextBox.TabIndex = 1;
            // 
            // shopAddressTextBox
            // 
            this.shopAddressTextBox.Location = new System.Drawing.Point(102, 49);
            this.shopAddressTextBox.Name = "shopAddressTextBox";
            this.shopAddressTextBox.Size = new System.Drawing.Size(178, 20);
            this.shopAddressTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.itemAddButton);
            this.groupBox2.Controls.Add(this.itemQuantiyTextBox);
            this.groupBox2.Controls.Add(this.itemIdTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(48, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Information";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(205, 75);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product / Item Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity";
            // 
            // itemIdTextBox
            // 
            this.itemIdTextBox.Location = new System.Drawing.Point(102, 9);
            this.itemIdTextBox.Name = "itemIdTextBox";
            this.itemIdTextBox.Size = new System.Drawing.Size(178, 20);
            this.itemIdTextBox.TabIndex = 1;
            // 
            // itemQuantiyTextBox
            // 
            this.itemQuantiyTextBox.Location = new System.Drawing.Point(102, 46);
            this.itemQuantiyTextBox.Name = "itemQuantiyTextBox";
            this.itemQuantiyTextBox.Size = new System.Drawing.Size(178, 20);
            this.itemQuantiyTextBox.TabIndex = 1;
            // 
            // itemAddButton
            // 
            this.itemAddButton.Location = new System.Drawing.Point(205, 72);
            this.itemAddButton.Name = "itemAddButton";
            this.itemAddButton.Size = new System.Drawing.Size(75, 23);
            this.itemAddButton.TabIndex = 2;
            this.itemAddButton.Text = "Add Item";
            this.itemAddButton.UseVisualStyleBackColor = true;
            this.itemAddButton.Click += new System.EventHandler(this.itemAddButton_Click);
            // 
            // showDetailsButton
            // 
            this.showDetailsButton.Cursor = System.Windows.Forms.Cursors.No;
            this.showDetailsButton.Location = new System.Drawing.Point(167, 329);
            this.showDetailsButton.Name = "showDetailsButton";
            this.showDetailsButton.Size = new System.Drawing.Size(139, 23);
            this.showDetailsButton.TabIndex = 2;
            this.showDetailsButton.Text = "Show Detalis";
            this.showDetailsButton.UseVisualStyleBackColor = true;
            this.showDetailsButton.Click += new System.EventHandler(this.showDetailsButton_Click);
            // 
            // SuperShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 393);
            this.Controls.Add(this.showDetailsButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SuperShopForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SuperShopAppUI";
            this.UseWaitCursor = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox shopAddressTextBox;
        private System.Windows.Forms.TextBox shopNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button itemAddButton;
        private System.Windows.Forms.TextBox itemQuantiyTextBox;
        private System.Windows.Forms.TextBox itemIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showDetailsButton;
    }
}

