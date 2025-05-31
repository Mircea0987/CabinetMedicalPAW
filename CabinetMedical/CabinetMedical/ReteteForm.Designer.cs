namespace CabinetMedical
{
    partial class ReteteForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nAVIGATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gOBACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEDICIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pACIENTIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cABINETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.sALVAREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cITIREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bINToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nAVIGATEToolStripMenuItem,
            this.sALVAREToolStripMenuItem,
            this.cITIREToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1341, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nAVIGATEToolStripMenuItem
            // 
            this.nAVIGATEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gOBACKToolStripMenuItem,
            this.mEDICIToolStripMenuItem,
            this.pACIENTIToolStripMenuItem,
            this.cABINETToolStripMenuItem});
            this.nAVIGATEToolStripMenuItem.Name = "nAVIGATEToolStripMenuItem";
            this.nAVIGATEToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.nAVIGATEToolStripMenuItem.Text = "NAVIGATE";
            // 
            // gOBACKToolStripMenuItem
            // 
            this.gOBACKToolStripMenuItem.Name = "gOBACKToolStripMenuItem";
            this.gOBACKToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gOBACKToolStripMenuItem.Text = "GO BACK";
            this.gOBACKToolStripMenuItem.Click += new System.EventHandler(this.gOBACKToolStripMenuItem_Click);
            // 
            // mEDICIToolStripMenuItem
            // 
            this.mEDICIToolStripMenuItem.Name = "mEDICIToolStripMenuItem";
            this.mEDICIToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mEDICIToolStripMenuItem.Text = "MEDICI";
            this.mEDICIToolStripMenuItem.Click += new System.EventHandler(this.mEDICIToolStripMenuItem_Click);
            // 
            // pACIENTIToolStripMenuItem
            // 
            this.pACIENTIToolStripMenuItem.Name = "pACIENTIToolStripMenuItem";
            this.pACIENTIToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pACIENTIToolStripMenuItem.Text = "PACIENTI";
            this.pACIENTIToolStripMenuItem.Click += new System.EventHandler(this.pACIENTIToolStripMenuItem_Click);
            // 
            // cABINETToolStripMenuItem
            // 
            this.cABINETToolStripMenuItem.Name = "cABINETToolStripMenuItem";
            this.cABINETToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cABINETToolStripMenuItem.Text = "CABINET";
            this.cABINETToolStripMenuItem.Click += new System.EventHandler(this.cABINETToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume Pacientului";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(601, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Emitere";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(563, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medicamente (,)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(563, 270);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 22);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Adauga Reteta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(646, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Afiseaza Reteta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(59, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(346, 302);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date Emitere";
            this.columnHeader2.Width = 122;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Medicamente";
            this.columnHeader3.Width = 121;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // cITIREToolStripMenuItem
            // 
            this.cITIREToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tXTToolStripMenuItem1,
            this.bINToolStripMenuItem1});
            this.cITIREToolStripMenuItem.Name = "cITIREToolStripMenuItem";
            this.cITIREToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.cITIREToolStripMenuItem.Text = "CITIRE";
            // 
            // tXTToolStripMenuItem
            // 
            this.tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tXTToolStripMenuItem.Text = "TXT";
            this.tXTToolStripMenuItem.Click += new System.EventHandler(this.tXTToolStripMenuItem_Click);
            // 
            // bINToolStripMenuItem
            // 
            this.bINToolStripMenuItem.Name = "bINToolStripMenuItem";
            this.bINToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bINToolStripMenuItem.Text = "BIN";
            this.bINToolStripMenuItem.Click += new System.EventHandler(this.bINToolStripMenuItem_Click);
            // 
            // tXTToolStripMenuItem1
            // 
            this.tXTToolStripMenuItem1.Name = "tXTToolStripMenuItem1";
            this.tXTToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.tXTToolStripMenuItem1.Text = "TXT";
            this.tXTToolStripMenuItem1.Click += new System.EventHandler(this.tXTToolStripMenuItem1_Click);
            // 
            // bINToolStripMenuItem1
            // 
            this.bINToolStripMenuItem1.Name = "bINToolStripMenuItem1";
            this.bINToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.bINToolStripMenuItem1.Text = "BIN";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(916, 70);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(392, 302);
            this.textBox3.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ReteteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 533);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReteteForm";
            this.Text = "ReteteForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nAVIGATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gOBACKToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem mEDICIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pACIENTIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cABINETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALVAREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cITIREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bINToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}