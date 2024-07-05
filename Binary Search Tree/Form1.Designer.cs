namespace Excercise2
{
    partial class Form1
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
            this.BtnInt = new System.Windows.Forms.Button();
            this.BtnCustomer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.treeSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integerTreeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.customerTreeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnInt
            // 
            this.BtnInt.BackColor = System.Drawing.Color.LightPink;
            this.BtnInt.FlatAppearance.BorderSize = 0;
            this.BtnInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInt.Location = new System.Drawing.Point(52, 226);
            this.BtnInt.Name = "BtnInt";
            this.BtnInt.Size = new System.Drawing.Size(208, 65);
            this.BtnInt.TabIndex = 0;
            this.BtnInt.Text = "Integer Binary Search Tree";
            this.BtnInt.UseVisualStyleBackColor = false;
            this.BtnInt.Click += new System.EventHandler(this.BtnInt_Click);
            // 
            // BtnCustomer
            // 
            this.BtnCustomer.BackColor = System.Drawing.Color.LightPink;
            this.BtnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomer.Location = new System.Drawing.Point(52, 105);
            this.BtnCustomer.Name = "BtnCustomer";
            this.BtnCustomer.Size = new System.Drawing.Size(208, 72);
            this.BtnCustomer.TabIndex = 1;
            this.BtnCustomer.Text = "Customer Binary Search Tree";
            this.BtnCustomer.UseVisualStyleBackColor = false;
            this.BtnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treeSearchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(425, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // treeSearchToolStripMenuItem
            // 
            this.treeSearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integerTreeMenu,
            this.customerTreeMenu});
            this.treeSearchToolStripMenuItem.Name = "treeSearchToolStripMenuItem";
            this.treeSearchToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.treeSearchToolStripMenuItem.Text = "Tree Search";
            // 
            // integerTreeMenu
            // 
            this.integerTreeMenu.Name = "integerTreeMenu";
            this.integerTreeMenu.Size = new System.Drawing.Size(180, 22);
            this.integerTreeMenu.Text = "Integer Tree";
            this.integerTreeMenu.Click += new System.EventHandler(this.integerTreeMenu_Click);
            // 
            // customerTreeMenu
            // 
            this.customerTreeMenu.Name = "customerTreeMenu";
            this.customerTreeMenu.Size = new System.Drawing.Size(180, 22);
            this.customerTreeMenu.Text = "Customer Tree";
            this.customerTreeMenu.Click += new System.EventHandler(this.customerTreeMenu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.BtnCustomer);
            this.groupBox1.Controls.Add(this.BtnInt);
            this.groupBox1.Location = new System.Drawing.Point(28, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 420);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Binary";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 40);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(425, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Binary Tree Search";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInt;
        private System.Windows.Forms.Button BtnCustomer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem treeSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integerTreeMenu;
        private System.Windows.Forms.ToolStripMenuItem customerTreeMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

