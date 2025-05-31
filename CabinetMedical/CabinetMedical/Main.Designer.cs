namespace CabinetMedical
{
    partial class Main
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
            this.nAVIGATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rETETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cABINETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEDICIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pACIENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nAVIGATEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nAVIGATEToolStripMenuItem
            // 
            this.nAVIGATEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rETETEToolStripMenuItem,
            this.cABINETToolStripMenuItem,
            this.mEDICIToolStripMenuItem,
            this.pACIENTToolStripMenuItem});
            this.nAVIGATEToolStripMenuItem.Name = "nAVIGATEToolStripMenuItem";
            this.nAVIGATEToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.nAVIGATEToolStripMenuItem.Text = "NAVIGATE";
            // 
            // rETETEToolStripMenuItem
            // 
            this.rETETEToolStripMenuItem.Name = "rETETEToolStripMenuItem";
            this.rETETEToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.rETETEToolStripMenuItem.Text = "RETETE";
            this.rETETEToolStripMenuItem.Click += new System.EventHandler(this.rETETEToolStripMenuItem_Click);
            // 
            // cABINETToolStripMenuItem
            // 
            this.cABINETToolStripMenuItem.Name = "cABINETToolStripMenuItem";
            this.cABINETToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.cABINETToolStripMenuItem.Text = "CABINET";
            this.cABINETToolStripMenuItem.Click += new System.EventHandler(this.cABINETToolStripMenuItem_Click);
            // 
            // mEDICIToolStripMenuItem
            // 
            this.mEDICIToolStripMenuItem.Name = "mEDICIToolStripMenuItem";
            this.mEDICIToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.mEDICIToolStripMenuItem.Text = "MEDICI";
            this.mEDICIToolStripMenuItem.Click += new System.EventHandler(this.mEDICIToolStripMenuItem_Click);
            // 
            // pACIENTToolStripMenuItem
            // 
            this.pACIENTToolStripMenuItem.Name = "pACIENTToolStripMenuItem";
            this.pACIENTToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.pACIENTToolStripMenuItem.Text = "PACIENT";
            this.pACIENTToolStripMenuItem.Click += new System.EventHandler(this.pACIENTToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1362, 608);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nAVIGATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rETETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cABINETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEDICIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pACIENTToolStripMenuItem;
    }
}