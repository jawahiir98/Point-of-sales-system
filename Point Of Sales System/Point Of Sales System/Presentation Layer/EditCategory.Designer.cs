
namespace Point_Of_Sales_System.Presentation_Layer
{
    partial class EditCategory
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CategoryListDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.UpdateCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SearchCategoryIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CategoryListDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(262, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 183);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category List ";
            // 
            // CategoryListDataGridView
            // 
            this.CategoryListDataGridView.AllowUserToAddRows = false;
            this.CategoryListDataGridView.AllowUserToDeleteRows = false;
            this.CategoryListDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.CategoryListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryListDataGridView.Location = new System.Drawing.Point(6, 33);
            this.CategoryListDataGridView.Name = "CategoryListDataGridView";
            this.CategoryListDataGridView.ReadOnly = true;
            this.CategoryListDataGridView.Size = new System.Drawing.Size(253, 144);
            this.CategoryListDataGridView.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Linen;
            this.BackButton.Image = global::Point_Of_Sales_System.Properties.Resources.Arrows_Left_icon;
            this.BackButton.Location = new System.Drawing.Point(-3, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(43, 30);
            this.BackButton.TabIndex = 3;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UpdateCategoryNameTextBox
            // 
            this.UpdateCategoryNameTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCategoryNameTextBox.Location = new System.Drawing.Point(116, 103);
            this.UpdateCategoryNameTextBox.Name = "UpdateCategoryNameTextBox";
            this.UpdateCategoryNameTextBox.Size = new System.Drawing.Size(119, 24);
            this.UpdateCategoryNameTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label4.Location = new System.Drawing.Point(4, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Category Name";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Gold;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.SearchButton.Location = new System.Drawing.Point(157, 57);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(72, 29);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Gold;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(8, 171);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(119, 26);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SearchCategoryIdTextBox
            // 
            this.SearchCategoryIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCategoryIdTextBox.Location = new System.Drawing.Point(91, 62);
            this.SearchCategoryIdTextBox.Name = "SearchCategoryIdTextBox";
            this.SearchCategoryIdTextBox.Size = new System.Drawing.Size(60, 24);
            this.SearchCategoryIdTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label3.Location = new System.Drawing.Point(4, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category Id";
            // 
            // EditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(539, 209);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.UpdateCategoryNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchCategoryIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.groupBox2);
            this.Name = "EditCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Category";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditCategory_FormClosing);
            this.Load += new System.EventHandler(this.EditCategory_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView CategoryListDataGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox UpdateCategoryNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox SearchCategoryIdTextBox;
        private System.Windows.Forms.Label label3;
    }
}