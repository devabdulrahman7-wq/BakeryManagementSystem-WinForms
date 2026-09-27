namespace Bakery_Software
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.nimkoradiobtn = new System.Windows.Forms.RadioButton();
            this.combobox = new System.Windows.Forms.ComboBox();
            this.sweetsradiobtn = new System.Windows.Forms.RadioButton();
            this.pricelbl = new System.Windows.Forms.Label();
            this.quantitylbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.balancetxt = new System.Windows.Forms.TextBox();
            this.paidtxt = new System.Windows.Forms.TextBox();
            this.balancelbl = new System.Windows.Forms.Label();
            this.paidlbl = new System.Windows.Forms.Label();
            this.discounttxt = new System.Windows.Forms.TextBox();
            this.nettxt = new System.Windows.Forms.TextBox();
            this.subtotaltxt = new System.Windows.Forms.TextBox();
            this.netlbl = new System.Windows.Forms.Label();
            this.discountlbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select";
            // 
            // nimkoradiobtn
            // 
            this.nimkoradiobtn.AutoSize = true;
            this.nimkoradiobtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nimkoradiobtn.Location = new System.Drawing.Point(191, 126);
            this.nimkoradiobtn.Name = "nimkoradiobtn";
            this.nimkoradiobtn.Size = new System.Drawing.Size(72, 21);
            this.nimkoradiobtn.TabIndex = 2;
            this.nimkoradiobtn.TabStop = true;
            this.nimkoradiobtn.Text = "Nimko";
            this.nimkoradiobtn.UseVisualStyleBackColor = true;
            this.nimkoradiobtn.CheckedChanged += new System.EventHandler(this.nimkoradiobtn_CheckedChanged);
            // 
            // combobox
            // 
            this.combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox.FormattingEnabled = true;
            this.combobox.Location = new System.Drawing.Point(187, 151);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(207, 24);
            this.combobox.TabIndex = 3;
            this.combobox.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            // 
            // sweetsradiobtn
            // 
            this.sweetsradiobtn.AutoSize = true;
            this.sweetsradiobtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sweetsradiobtn.Location = new System.Drawing.Point(305, 126);
            this.sweetsradiobtn.Name = "sweetsradiobtn";
            this.sweetsradiobtn.Size = new System.Drawing.Size(79, 21);
            this.sweetsradiobtn.TabIndex = 5;
            this.sweetsradiobtn.TabStop = true;
            this.sweetsradiobtn.Text = "Sweets";
            this.sweetsradiobtn.UseVisualStyleBackColor = true;
            this.sweetsradiobtn.CheckedChanged += new System.EventHandler(this.sweetsradiobtn_CheckedChanged);
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.Location = new System.Drawing.Point(58, 196);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(42, 15);
            this.pricelbl.TabIndex = 6;
            this.pricelbl.Text = "Price";
            // 
            // quantitylbl
            // 
            this.quantitylbl.AutoSize = true;
            this.quantitylbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitylbl.Location = new System.Drawing.Point(184, 196);
            this.quantitylbl.Name = "quantitylbl";
            this.quantitylbl.Size = new System.Drawing.Size(62, 15);
            this.quantitylbl.TabIndex = 7;
            this.quantitylbl.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.Location = new System.Drawing.Point(446, 206);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(87, 29);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "Add Items";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(17, 215);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(118, 20);
            this.pricetxt.TabIndex = 10;
            // 
            // totaltxt
            // 
            this.totaltxt.Location = new System.Drawing.Point(305, 214);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(118, 20);
            this.totaltxt.TabIndex = 11;
            this.totaltxt.TextChanged += new System.EventHandler(this.totaltxt_TextChanged);
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(166, 214);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(118, 20);
            this.quantitytxt.TabIndex = 12;
            this.quantitytxt.TextChanged += new System.EventHandler(this.quantitytxt_TextChanged);
            // 
            // balancetxt
            // 
            this.balancetxt.Location = new System.Drawing.Point(446, 523);
            this.balancetxt.Name = "balancetxt";
            this.balancetxt.Size = new System.Drawing.Size(107, 20);
            this.balancetxt.TabIndex = 18;
            this.balancetxt.TextChanged += new System.EventHandler(this.balancetxt_TextChanged);
            // 
            // paidtxt
            // 
            this.paidtxt.Location = new System.Drawing.Point(446, 497);
            this.paidtxt.Name = "paidtxt";
            this.paidtxt.Size = new System.Drawing.Size(107, 20);
            this.paidtxt.TabIndex = 16;
            this.paidtxt.TextChanged += new System.EventHandler(this.paidtxt_TextChanged);
            // 
            // balancelbl
            // 
            this.balancelbl.AutoSize = true;
            this.balancelbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balancelbl.Location = new System.Drawing.Point(385, 528);
            this.balancelbl.Name = "balancelbl";
            this.balancelbl.Size = new System.Drawing.Size(60, 15);
            this.balancelbl.TabIndex = 14;
            this.balancelbl.Text = "Balance";
            // 
            // paidlbl
            // 
            this.paidlbl.AutoSize = true;
            this.paidlbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidlbl.Location = new System.Drawing.Point(385, 502);
            this.paidlbl.Name = "paidlbl";
            this.paidlbl.Size = new System.Drawing.Size(36, 15);
            this.paidlbl.TabIndex = 13;
            this.paidlbl.Text = "Paid";
            // 
            // discounttxt
            // 
            this.discounttxt.Location = new System.Drawing.Point(280, 462);
            this.discounttxt.Name = "discounttxt";
            this.discounttxt.Size = new System.Drawing.Size(85, 20);
            this.discounttxt.TabIndex = 24;
            this.discounttxt.TextChanged += new System.EventHandler(this.discounttxt_TextChanged);
            // 
            // nettxt
            // 
            this.nettxt.Location = new System.Drawing.Point(446, 462);
            this.nettxt.Name = "nettxt";
            this.nettxt.Size = new System.Drawing.Size(107, 20);
            this.nettxt.TabIndex = 23;
            this.nettxt.TextChanged += new System.EventHandler(this.nettxt_TextChanged);
            // 
            // subtotaltxt
            // 
            this.subtotaltxt.Location = new System.Drawing.Point(89, 462);
            this.subtotaltxt.Name = "subtotaltxt";
            this.subtotaltxt.Size = new System.Drawing.Size(87, 20);
            this.subtotaltxt.TabIndex = 22;
            this.subtotaltxt.TextChanged += new System.EventHandler(this.subtotaltxt_TextChanged);
            // 
            // netlbl
            // 
            this.netlbl.AutoSize = true;
            this.netlbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netlbl.Location = new System.Drawing.Point(385, 467);
            this.netlbl.Name = "netlbl";
            this.netlbl.Size = new System.Drawing.Size(30, 15);
            this.netlbl.TabIndex = 21;
            this.netlbl.Text = "Net";
            // 
            // discountlbl
            // 
            this.discountlbl.AutoSize = true;
            this.discountlbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountlbl.Location = new System.Drawing.Point(199, 464);
            this.discountlbl.Name = "discountlbl";
            this.discountlbl.Size = new System.Drawing.Size(65, 15);
            this.discountlbl.TabIndex = 20;
            this.discountlbl.Text = "Discount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Sub Total";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Price,
            this.Column1,
            this.Column2});
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 207);
            this.dataGridView1.TabIndex = 28;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Items Name";
            this.Column3.Name = "Column3";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Quantity";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Total";
            this.Column2.Name = "Column2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(555, 551);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.discounttxt);
            this.Controls.Add(this.nettxt);
            this.Controls.Add(this.subtotaltxt);
            this.Controls.Add(this.netlbl);
            this.Controls.Add(this.discountlbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.balancetxt);
            this.Controls.Add(this.paidtxt);
            this.Controls.Add(this.balancelbl);
            this.Controls.Add(this.paidlbl);
            this.Controls.Add(this.quantitytxt);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quantitylbl);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.sweetsradiobtn);
            this.Controls.Add(this.combobox);
            this.Controls.Add(this.nimkoradiobtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bakery Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton nimkoradiobtn;
        private System.Windows.Forms.ComboBox combobox;
        private System.Windows.Forms.RadioButton sweetsradiobtn;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label quantitylbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.TextBox balancetxt;
        private System.Windows.Forms.TextBox paidtxt;
        private System.Windows.Forms.Label balancelbl;
        private System.Windows.Forms.Label paidlbl;
        private System.Windows.Forms.TextBox discounttxt;
        private System.Windows.Forms.TextBox nettxt;
        private System.Windows.Forms.TextBox subtotaltxt;
        private System.Windows.Forms.Label netlbl;
        private System.Windows.Forms.Label discountlbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

