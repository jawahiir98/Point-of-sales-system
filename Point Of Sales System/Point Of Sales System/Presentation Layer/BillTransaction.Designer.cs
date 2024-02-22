
namespace Point_Of_Sales_System.Presentation_Layer
{
    partial class BillTransaction
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
            this.SearchProductIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductDataListGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CartItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PaidAmountTextBox = new System.Windows.Forms.TextBox();
            this.ChangeAmountTextBox = new System.Windows.Forms.TextBox();
            this.TotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.OkayButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductAmountTextBox = new System.Windows.Forms.TextBox();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PayButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataListGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartItemsDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Page";
            // 
            // SearchProductIdTextBox
            // 
            this.SearchProductIdTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProductIdTextBox.Location = new System.Drawing.Point(121, 52);
            this.SearchProductIdTextBox.Name = "SearchProductIdTextBox";
            this.SearchProductIdTextBox.Size = new System.Drawing.Size(207, 23);
            this.SearchProductIdTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Product ID : ";
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.Gold;
            this.AddProductButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.Location = new System.Drawing.Point(15, 304);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(313, 30);
            this.AddProductButton.TabIndex = 4;
            this.AddProductButton.Text = "Add Product";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductDataListGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product List";
            // 
            // ProductDataListGridView
            // 
            this.ProductDataListGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductDataListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataListGridView.Location = new System.Drawing.Point(0, 18);
            this.ProductDataListGridView.Name = "ProductDataListGridView";
            this.ProductDataListGridView.Size = new System.Drawing.Size(313, 151);
            this.ProductDataListGridView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CartItemsDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(344, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 286);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cart Items List";
            // 
            // CartItemsDataGridView
            // 
            this.CartItemsDataGridView.AllowUserToAddRows = false;
            this.CartItemsDataGridView.AllowUserToDeleteRows = false;
            this.CartItemsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.CartItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartItemsDataGridView.Location = new System.Drawing.Point(6, 24);
            this.CartItemsDataGridView.Name = "CartItemsDataGridView";
            this.CartItemsDataGridView.ReadOnly = true;
            this.CartItemsDataGridView.Size = new System.Drawing.Size(356, 262);
            this.CartItemsDataGridView.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Paid Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(3, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Change Amount";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Bisque;
            this.groupBox3.Controls.Add(this.PaidAmountTextBox);
            this.groupBox3.Controls.Add(this.ChangeAmountTextBox);
            this.groupBox3.Controls.Add(this.TotalAmountTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(717, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 172);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bill ";
            // 
            // PaidAmountTextBox
            // 
            this.PaidAmountTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidAmountTextBox.Location = new System.Drawing.Point(108, 84);
            this.PaidAmountTextBox.Name = "PaidAmountTextBox";
            this.PaidAmountTextBox.Size = new System.Drawing.Size(100, 25);
            this.PaidAmountTextBox.TabIndex = 14;
            // 
            // ChangeAmountTextBox
            // 
            this.ChangeAmountTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeAmountTextBox.Location = new System.Drawing.Point(108, 122);
            this.ChangeAmountTextBox.Name = "ChangeAmountTextBox";
            this.ChangeAmountTextBox.Size = new System.Drawing.Size(100, 25);
            this.ChangeAmountTextBox.TabIndex = 13;
            // 
            // TotalAmountTextBox
            // 
            this.TotalAmountTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountTextBox.Location = new System.Drawing.Point(108, 47);
            this.TotalAmountTextBox.Name = "TotalAmountTextBox";
            this.TotalAmountTextBox.Size = new System.Drawing.Size(100, 25);
            this.TotalAmountTextBox.TabIndex = 12;
            // 
            // OkayButton
            // 
            this.OkayButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.OkayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.OkayButton.Location = new System.Drawing.Point(825, 286);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(100, 30);
            this.OkayButton.TabIndex = 13;
            this.OkayButton.Text = "Done";
            this.OkayButton.UseVisualStyleBackColor = false;
            this.OkayButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Product Amount : ";
            // 
            // ProductAmountTextBox
            // 
            this.ProductAmountTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductAmountTextBox.Location = new System.Drawing.Point(124, 269);
            this.ProductAmountTextBox.Name = "ProductAmountTextBox";
            this.ProductAmountTextBox.Size = new System.Drawing.Size(204, 23);
            this.ProductAmountTextBox.TabIndex = 14;
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.BackColor = System.Drawing.Color.Gold;
            this.ClearCartButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearCartButton.Location = new System.Drawing.Point(350, 340);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(356, 30);
            this.ClearCartButton.TabIndex = 16;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = false;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "Clear ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PayButton
            // 
            this.PayButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.PayButton.Location = new System.Drawing.Point(825, 250);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(100, 30);
            this.PayButton.TabIndex = 18;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = false;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.Image = global::Point_Of_Sales_System.Properties.Resources.Arrows_Left_icon;
            this.BackButton.Location = new System.Drawing.Point(-1, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(43, 30);
            this.BackButton.TabIndex = 19;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BillTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(942, 395);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClearCartButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductAmountTextBox);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchProductIdTextBox);
            this.Controls.Add(this.label1);
            this.Name = "BillTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Transaction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BillTransaction_FormClosing);
            this.Load += new System.EventHandler(this.BillTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataListGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CartItemsDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchProductIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ProductDataListGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView CartItemsDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox PaidAmountTextBox;
        private System.Windows.Forms.TextBox ChangeAmountTextBox;
        private System.Windows.Forms.TextBox TotalAmountTextBox;
        private System.Windows.Forms.Button OkayButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProductAmountTextBox;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Button BackButton;
    }
}