namespace Excercise2
{
    partial class Integer_Form
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
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_inOrder = new System.Windows.Forms.Button();
            this.btn_PostOrder = new System.Windows.Forms.Button();
            this.btn_PreOrder = new System.Windows.Forms.Button();
            this.TxtPreOrder = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPostOrder = new System.Windows.Forms.TextBox();
            this.TxtInOrder = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNumber
            // 
            this.TxtNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumber.Location = new System.Drawing.Point(138, 88);
            this.TxtNumber.Multiline = true;
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(125, 44);
            this.TxtNumber.TabIndex = 0;
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.Color.LightPink;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Insert.Location = new System.Drawing.Point(284, 87);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(183, 45);
            this.btn_Insert.TabIndex = 1;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(51, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number";
            // 
            // btn_inOrder
            // 
            this.btn_inOrder.BackColor = System.Drawing.Color.LightPink;
            this.btn_inOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_inOrder.Location = new System.Drawing.Point(55, 161);
            this.btn_inOrder.Name = "btn_InOrder";
            this.btn_inOrder.Size = new System.Drawing.Size(128, 47);
            this.btn_inOrder.TabIndex = 3;
            this.btn_inOrder.Text = "InOrder";
            this.btn_inOrder.UseVisualStyleBackColor = false;
            this.btn_inOrder.Click += new System.EventHandler(this.btn_InOrder_Click);
            // 
            // btn_PostOrder
            // 
            this.btn_PostOrder.BackColor = System.Drawing.Color.LightPink;
            this.btn_PostOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PostOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PostOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_PostOrder.Location = new System.Drawing.Point(55, 241);
            this.btn_PostOrder.Name = "btn_PostOrder";
            this.btn_PostOrder.Size = new System.Drawing.Size(128, 51);
            this.btn_PostOrder.TabIndex = 4;
            this.btn_PostOrder.Text = "PostOrder";
            this.btn_PostOrder.UseVisualStyleBackColor = false;
            this.btn_PostOrder.Click += new System.EventHandler(this.btn_PostOrder_Click);
            // 
            // btn_PreOrder
            // 
            this.btn_PreOrder.BackColor = System.Drawing.Color.LightPink;
            this.btn_PreOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PreOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PreOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_PreOrder.Location = new System.Drawing.Point(55, 83);
            this.btn_PreOrder.Name = "btn_PreOrder";
            this.btn_PreOrder.Size = new System.Drawing.Size(128, 50);
            this.btn_PreOrder.TabIndex = 5;
            this.btn_PreOrder.Text = "PreOrder";
            this.btn_PreOrder.UseVisualStyleBackColor = false;
            this.btn_PreOrder.Click += new System.EventHandler(this.btn_PreOrder_Click);
            // 
            // TxtPreOrder
            // 
            this.TxtPreOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPreOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPreOrder.Location = new System.Drawing.Point(231, 83);
            this.TxtPreOrder.Multiline = true;
            this.TxtPreOrder.Name = "TxtPreOrder";
            this.TxtPreOrder.Size = new System.Drawing.Size(250, 50);
            this.TxtPreOrder.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.TxtPostOrder);
            this.groupBox1.Controls.Add(this.TxtInOrder);
            this.groupBox1.Controls.Add(this.btn_PreOrder);
            this.groupBox1.Controls.Add(this.btn_PostOrder);
            this.groupBox1.Controls.Add(this.btn_inOrder);
            this.groupBox1.Controls.Add(this.TxtPreOrder);
            this.groupBox1.Location = new System.Drawing.Point(73, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 343);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.LightPink;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 46);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(146, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Result";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 0;
            // 
            // TxtPostOrder
            // 
            this.TxtPostOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPostOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPostOrder.Location = new System.Drawing.Point(231, 241);
            this.TxtPostOrder.Multiline = true;
            this.TxtPostOrder.Name = "TxtPostOrder";
            this.TxtPostOrder.Size = new System.Drawing.Size(250, 51);
            this.TxtPostOrder.TabIndex = 8;
            // 
            // TxtInOrder
            // 
            this.TxtInOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInOrder.Location = new System.Drawing.Point(231, 161);
            this.TxtInOrder.Multiline = true;
            this.TxtInOrder.Name = "TxtInOrder";
            this.TxtInOrder.Size = new System.Drawing.Size(250, 47);
            this.TxtInOrder.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.lblCount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_Insert);
            this.groupBox2.Controls.Add(this.TxtNumber);
            this.groupBox2.Location = new System.Drawing.Point(73, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 203);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCount.Location = new System.Drawing.Point(248, 155);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(18, 20);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(51, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of Items in Tree : ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Location = new System.Drawing.Point(73, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 43);
            this.panel1.TabIndex = 5;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataSource = typeof(Exercise2.Customer);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Exercise2.Customer);
            // 
            // nodeBindingSource
            // 
            this.nodeBindingSource.DataSource = typeof(Exercise2.IntegerNode);
            // 
            // Integer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(630, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Integer_Form";
            this.Text = "Integer BTS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_inOrder;
        private System.Windows.Forms.Button btn_PostOrder;
        private System.Windows.Forms.Button btn_PreOrder;
        private System.Windows.Forms.TextBox TxtPreOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtPostOrder;
        private System.Windows.Forms.TextBox TxtInOrder;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource nodeBindingSource;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}