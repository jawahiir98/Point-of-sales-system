
namespace Point_Of_Sales_System.Presentation_Layer
{
    partial class EditProduct
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
            this.BackButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchProductIdTextBox = new System.Windows.Forms.TextBox();
            this.EditProductCIDComboBox = new System.Windows.Forms.ComboBox();
            this.EditProductQuantityTextBox = new System.Windows.Forms.TextBox();
            this.EditProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.EditProductNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Linen;
            this.BackButton.Image = global::Point_Of_Sales_System.Properties.Resources.Arrows_Left_icon;
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(43, 30);
            this.BackButton.TabIndex = 12;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Gold;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(0, 194);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(102, 32);
            this.EditButton.TabIndex = 18;
            this.EditButton.Text = "Update";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchProductIdTextBox);
            this.groupBox1.Controls.Add(this.EditProductCIDComboBox);
            this.groupBox1.Controls.Add(this.EditProductQuantityTextBox);
            this.groupBox1.Controls.Add(this.EditProductPriceTextBox);
            this.groupBox1.Controls.Add(this.EditProductNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(124, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 150);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // SearchProductIdTextBox
            // 
            this.SearchProductIdTextBox.Location = new System.Drawing.Point(0, 2);
            this.SearchProductIdTextBox.Name = "SearchProductIdTextBox";
            this.SearchProductIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.SearchProductIdTextBox.TabIndex = 4;
            // 
            // EditProductCIDComboBox
            // 
            this.EditProductCIDComboBox.FormattingEnabled = true;
            this.EditProductCIDComboBox.Location = new System.Drawing.Point(0, 117);
            this.EditProductCIDComboBox.Name = "EditProductCIDComboBox";
            this.EditProductCIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.EditProductCIDComboBox.TabIndex = 3;
            // 
            // EditProductQuantityTextBox
            // 
            this.EditProductQuantityTextBox.Location = new System.Drawing.Point(0, 85);
            this.EditProductQuantityTextBox.Name = "EditProductQuantityTextBox";
            this.EditProductQuantityTextBox.Size = new System.Drawing.Size(121, 20);
            this.EditProductQuantityTextBox.TabIndex = 2;
            // 
            // EditProductPriceTextBox
            // 
            this.EditProductPriceTextBox.Location = new System.Drawing.Point(0, 59);
            this.EditProductPriceTextBox.Name = "EditProductPriceTextBox";
            this.EditProductPriceTextBox.Size = new System.Drawing.Size(121, 20);
            this.EditProductPriceTextBox.TabIndex = 1;
            // 
            // EditProductNameTextBox
            // 
            this.EditProductNameTextBox.Location = new System.Drawing.Point(0, 28);
            this.EditProductNameTextBox.Name = "EditProductNameTextBox";
            this.EditProductNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.EditProductNameTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Category ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantity: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Product ID: ";
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(263, 229);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Name = "EditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditProduct_FormClosing);
            this.Load += new System.EventHandler(this.EditProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox EditProductCIDComboBox;
        private System.Windows.Forms.TextBox EditProductQuantityTextBox;
        private System.Windows.Forms.TextBox EditProductPriceTextBox;
        private System.Windows.Forms.TextBox EditProductNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchProductIdTextBox;
        private System.Windows.Forms.Label label5;
    }
}