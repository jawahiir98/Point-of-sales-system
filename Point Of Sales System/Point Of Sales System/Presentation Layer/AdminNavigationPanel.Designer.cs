
namespace Point_Of_Sales_System.Presentation_Layer
{
    partial class AdminNavigationPanel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAllInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.OrangeRed;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.userAllInformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(500, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 12F);
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // userAllInformationToolStripMenuItem
            // 
            this.userAllInformationToolStripMenuItem.BackColor = System.Drawing.Color.OrangeRed;
            this.userAllInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StuffToolStripMenuItem,
            this.billingInformationToolStripMenuItem});
            this.userAllInformationToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAllInformationToolStripMenuItem.Name = "userAllInformationToolStripMenuItem";
            this.userAllInformationToolStripMenuItem.Size = new System.Drawing.Size(150, 23);
            this.userAllInformationToolStripMenuItem.Text = "Admin Page View";
            // 
            // StuffToolStripMenuItem
            // 
            this.StuffToolStripMenuItem.Name = "StuffToolStripMenuItem";
            this.StuffToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.StuffToolStripMenuItem.Text = "Manage Stuff";
            this.StuffToolStripMenuItem.Click += new System.EventHandler(this.StuffToolStripMenuItem_Click);
            // 
            // billingInformationToolStripMenuItem
            // 
            this.billingInformationToolStripMenuItem.Name = "billingInformationToolStripMenuItem";
            this.billingInformationToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.billingInformationToolStripMenuItem.Text = "Billing Information";
            this.billingInformationToolStripMenuItem.Click += new System.EventHandler(this.billingInformationToolStripMenuItem_Click);
            // 
            // AdminNavigationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(500, 245);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AdminNavigationPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Navigation Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminNavigationPanel_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAllInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StuffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingInformationToolStripMenuItem;
    }
}