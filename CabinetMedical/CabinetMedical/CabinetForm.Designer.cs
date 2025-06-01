namespace CabinetMedical
{
    partial class CabinetForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CabinetForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nAVIGATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gOBACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEDICIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rETETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pACIENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALVAREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cITIREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bINToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nAVIGATEToolStripMenuItem,
            this.sALVAREToolStripMenuItem,
            this.cITIREToolStripMenuItem,
            this.cHARTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1318, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nAVIGATEToolStripMenuItem
            // 
            this.nAVIGATEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gOBACKToolStripMenuItem,
            this.mEDICIToolStripMenuItem,
            this.rETETEToolStripMenuItem,
            this.pACIENTToolStripMenuItem});
            this.nAVIGATEToolStripMenuItem.Name = "nAVIGATEToolStripMenuItem";
            this.nAVIGATEToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.nAVIGATEToolStripMenuItem.Text = "NAVIGATE";
            // 
            // gOBACKToolStripMenuItem
            // 
            this.gOBACKToolStripMenuItem.Name = "gOBACKToolStripMenuItem";
            this.gOBACKToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.gOBACKToolStripMenuItem.Text = "GO BACK";
            this.gOBACKToolStripMenuItem.Click += new System.EventHandler(this.gOBACKToolStripMenuItem_Click);
            // 
            // mEDICIToolStripMenuItem
            // 
            this.mEDICIToolStripMenuItem.Name = "mEDICIToolStripMenuItem";
            this.mEDICIToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.mEDICIToolStripMenuItem.Text = "MEDICI";
            this.mEDICIToolStripMenuItem.Click += new System.EventHandler(this.mEDICIToolStripMenuItem_Click);
            // 
            // rETETEToolStripMenuItem
            // 
            this.rETETEToolStripMenuItem.Name = "rETETEToolStripMenuItem";
            this.rETETEToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.rETETEToolStripMenuItem.Text = "RETETE";
            this.rETETEToolStripMenuItem.Click += new System.EventHandler(this.rETETEToolStripMenuItem_Click);
            // 
            // pACIENTToolStripMenuItem
            // 
            this.pACIENTToolStripMenuItem.Name = "pACIENTToolStripMenuItem";
            this.pACIENTToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.pACIENTToolStripMenuItem.Text = "PACIENT";
            this.pACIENTToolStripMenuItem.Click += new System.EventHandler(this.pACIENTToolStripMenuItem_Click);
            // 
            // sALVAREToolStripMenuItem
            // 
            this.sALVAREToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tXTToolStripMenuItem,
            this.bINToolStripMenuItem});
            this.sALVAREToolStripMenuItem.Name = "sALVAREToolStripMenuItem";
            this.sALVAREToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.sALVAREToolStripMenuItem.Text = "SALVARE";
            // 
            // tXTToolStripMenuItem
            // 
            this.tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.tXTToolStripMenuItem.Text = "TXT";
            this.tXTToolStripMenuItem.Click += new System.EventHandler(this.tXTToolStripMenuItem_Click);
            // 
            // bINToolStripMenuItem
            // 
            this.bINToolStripMenuItem.Name = "bINToolStripMenuItem";
            this.bINToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.bINToolStripMenuItem.Text = "BIN";
            this.bINToolStripMenuItem.Click += new System.EventHandler(this.bINToolStripMenuItem_Click);
            // 
            // cITIREToolStripMenuItem
            // 
            this.cITIREToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tXTToolStripMenuItem1,
            this.bINToolStripMenuItem1});
            this.cITIREToolStripMenuItem.Name = "cITIREToolStripMenuItem";
            this.cITIREToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.cITIREToolStripMenuItem.Text = "CITIRE";
            // 
            // tXTToolStripMenuItem1
            // 
            this.tXTToolStripMenuItem1.Name = "tXTToolStripMenuItem1";
            this.tXTToolStripMenuItem1.Size = new System.Drawing.Size(117, 26);
            this.tXTToolStripMenuItem1.Text = "TXT";
            this.tXTToolStripMenuItem1.Click += new System.EventHandler(this.tXTToolStripMenuItem1_Click);
            // 
            // bINToolStripMenuItem1
            // 
            this.bINToolStripMenuItem1.Name = "bINToolStripMenuItem1";
            this.bINToolStripMenuItem1.Size = new System.Drawing.Size(117, 26);
            this.bINToolStripMenuItem1.Text = "BIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Capacitate";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(594, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(594, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(594, 243);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(594, 304);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "Afiseaza";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(478, 306);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adresa";
            this.columnHeader2.Width = 158;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Capacitate";
            this.columnHeader4.Width = 80;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(864, 83);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(429, 295);
            this.textBox5.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 28);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.dToolStripMenuItem.Text = "Delete all";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // cHARTToolStripMenuItem
            // 
            this.cHARTToolStripMenuItem.Name = "cHARTToolStripMenuItem";
            this.cHARTToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.cHARTToolStripMenuItem.Text = "CHART";
            this.cHARTToolStripMenuItem.Click += new System.EventHandler(this.cHARTToolStripMenuItem_Click);
            // 
            // CabinetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 503);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CabinetForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nAVIGATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gOBACKToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem mEDICIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rETETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pACIENTToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ToolStripMenuItem sALVAREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cITIREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bINToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHARTToolStripMenuItem;
    }
}

