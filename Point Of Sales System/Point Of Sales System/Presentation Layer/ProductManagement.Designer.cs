
namespace Point_Of_Sales_System.Presentation_Layer
{
    partial class ProductManagement
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ProductListDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.SearchProductTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Gold;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(12, 200);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(76, 39);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Gold;
            this.EditButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(12, 159);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(76, 35);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "EDIT";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Gold;
            this.AddButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(12, 118);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(76, 35);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Gold;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(100, 45);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(76, 28);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(293, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProductListDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(94, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 166);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product List";
            // 
            // ProductListDataGridView
            // 
            this.ProductListDataGridView.AllowUserToAddRows = false;
            this.ProductListDataGridView.AllowUserToDeleteRows = false;
            this.ProductListDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductListDataGridView.Location = new System.Drawing.Point(6, 19);
            this.ProductListDataGridView.Name = "ProductListDataGridView";
            this.ProductListDataGridView.ReadOnly = true;
            this.ProductListDataGridView.Size = new System.Drawing.Size(341, 144);
            this.ProductListDataGridView.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Linen;
            this.BackButton.Image = global::Point_Of_Sales_System.Properties.Resources.Arrows_Left_icon;
            this.BackButton.Location = new System.Drawing.Point(-2, -2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(43, 30);
            this.BackButton.TabIndex = 10;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SearchProductTextBox
            // 
            this.SearchProductTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.SearchProductTextBox.Location = new System.Drawing.Point(182, 48);
            this.SearchProductTextBox.Name = "SearchProductTextBox";
            this.SearchProductTextBox.Size = new System.Drawing.Size(259, 25);
            this.SearchProductTextBox.TabIndex = 11;
            this.SearchProductTextBox.TextChanged += new System.EventHandler(this.SearchProductTextBox_TextChanged);
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(459, 251);
            this.Controls.Add(this.SearchProductTextBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Name = "ProductManagement";
            this.Text = "ProductManagement";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView ProductListDataGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox SearchProductTextBox;
    }
}