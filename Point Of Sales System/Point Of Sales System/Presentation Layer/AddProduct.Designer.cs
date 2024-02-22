
namespace Point_Of_Sales_System.Presentation_Layer
{
    partial class AddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddProductCategoryIdComboBox = new System.Windows.Forms.ComboBox();
            this.AddProductQuantityTextBox = new System.Windows.Forms.TextBox();
            this.AddProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.AddProductNameTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category ID: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddProductCategoryIdComboBox);
            this.groupBox1.Controls.Add(this.AddProductQuantityTextBox);
            this.groupBox1.Controls.Add(this.AddProductPriceTextBox);
            this.groupBox1.Controls.Add(this.AddProductNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(124, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 148);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // AddProductCategoryIdComboBox
            // 
            this.AddProductCategoryIdComboBox.FormattingEnabled = true;
            this.AddProductCategoryIdComboBox.Location = new System.Drawing.Point(0, 117);
            this.AddProductCategoryIdComboBox.Name = "AddProductCategoryIdComboBox";
            this.AddProductCategoryIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.AddProductCategoryIdComboBox.TabIndex = 3;
            // 
            // AddProductQuantityTextBox
            // 
            this.AddProductQuantityTextBox.Location = new System.Drawing.Point(0, 85);
            this.AddProductQuantityTextBox.Name = "AddProductQuantityTextBox";
            this.AddProductQuantityTextBox.Size = new System.Drawing.Size(121, 20);
            this.AddProductQuantityTextBox.TabIndex = 2;
            // 
            // AddProductPriceTextBox
            // 
            this.AddProductPriceTextBox.Location = new System.Drawing.Point(0, 59);
            this.AddProductPriceTextBox.Name = "AddProductPriceTextBox";
            this.AddProductPriceTextBox.Size = new System.Drawing.Size(121, 20);
            this.AddProductPriceTextBox.TabIndex = 1;
            // 
            // AddProductNameTextBox
            // 
            this.AddProductNameTextBox.Location = new System.Drawing.Point(0, 29);
            this.AddProductNameTextBox.Name = "AddProductNameTextBox";
            this.AddProductNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.AddProductNameTextBox.TabIndex = 0;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.Gold;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(0, 194);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(102, 32);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Linen;
            this.BackButton.Image = global::Point_Of_Sales_System.Properties.Resources.Arrows_Left_icon;
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(43, 30);
            this.BackButton.TabIndex = 11;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(263, 229);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProduct_FormClosing);
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox AddProductCategoryIdComboBox;
        private System.Windows.Forms.TextBox AddProductQuantityTextBox;
        private System.Windows.Forms.TextBox AddProductPriceTextBox;
        private System.Windows.Forms.TextBox AddProductNameTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button BackButton;
    }
}