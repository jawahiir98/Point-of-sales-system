
namespace Point_Of_Sales_System.Presentation_Layer
{
    partial class CategoryManagement
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CategoryListDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.EditButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Location = new System.Drawing.Point(25, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Gold;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(33, 93);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(76, 39);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Gold;
            this.EditButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(33, 52);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(76, 35);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "EDIT";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Gold;
            this.AddButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(33, 11);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(76, 35);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CategoryListDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(140, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 171);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category List ";
            // 
            // CategoryListDataGridView
            // 
            this.CategoryListDataGridView.AllowUserToAddRows = false;
            this.CategoryListDataGridView.AllowUserToDeleteRows = false;
            this.CategoryListDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.CategoryListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryListDataGridView.Location = new System.Drawing.Point(6, 24);
            this.CategoryListDataGridView.Name = "CategoryListDataGridView";
            this.CategoryListDataGridView.ReadOnly = true;
            this.CategoryListDataGridView.Size = new System.Drawing.Size(325, 144);
            this.CategoryListDataGridView.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Gold;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(140, 29);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(76, 24);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchCategoryComboBox
            // 
            this.SearchCategoryComboBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCategoryComboBox.FormattingEnabled = true;
            this.SearchCategoryComboBox.Location = new System.Drawing.Point(222, 29);
            this.SearchCategoryComboBox.Name = "SearchCategoryComboBox";
            this.SearchCategoryComboBox.Size = new System.Drawing.Size(249, 24);
            this.SearchCategoryComboBox.TabIndex = 9;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Linen;
            this.BackButton.Image = global::Point_Of_Sales_System.Properties.Resources.Arrows_Left_icon;
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(43, 30);
            this.BackButton.TabIndex = 1;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(484, 241);
            this.Controls.Add(this.SearchCategoryComboBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CategoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoryManagement_FormClosing);
            this.Load += new System.EventHandler(this.CategoryManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView CategoryListDataGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox SearchCategoryComboBox;
    }
}