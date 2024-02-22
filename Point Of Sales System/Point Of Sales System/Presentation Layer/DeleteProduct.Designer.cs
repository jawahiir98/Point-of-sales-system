
namespace Point_Of_Sales_System.Presentation_Layer
{
    partial class DeleteProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteProductTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Linen;
            this.BackButton.Image = global::Point_Of_Sales_System.Properties.Resources.Arrows_Left_icon;
            this.BackButton.Location = new System.Drawing.Point(-4, -1);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(43, 30);
            this.BackButton.TabIndex = 12;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product ID: ";
            // 
            // DeleteProductTextBox
            // 
            this.DeleteProductTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.DeleteProductTextBox.Location = new System.Drawing.Point(101, 66);
            this.DeleteProductTextBox.Name = "DeleteProductTextBox";
            this.DeleteProductTextBox.Size = new System.Drawing.Size(130, 25);
            this.DeleteProductTextBox.TabIndex = 14;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Gold;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.DeleteButton.Location = new System.Drawing.Point(7, 109);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(88, 26);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(263, 148);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DeleteProductTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Name = "DeleteProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteProduct_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeleteProductTextBox;
        private System.Windows.Forms.Button DeleteButton;
    }
}