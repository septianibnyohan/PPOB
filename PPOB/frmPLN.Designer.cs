namespace PPOB
{
    partial class frmPLN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPLN));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPelanggan = new System.Windows.Forms.TextBox();
            this.pnlNominal = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlKeterangan = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheckBuy = new PPOB.Component.RoundedButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlKeterangan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "No. Meter/ID Pel";
            // 
            // txtPelanggan
            // 
            this.txtPelanggan.BackColor = System.Drawing.SystemColors.Control;
            this.txtPelanggan.Location = new System.Drawing.Point(7, 72);
            this.txtPelanggan.Name = "txtPelanggan";
            this.txtPelanggan.Size = new System.Drawing.Size(870, 26);
            this.txtPelanggan.TabIndex = 6;
            this.txtPelanggan.TextChanged += new System.EventHandler(this.txtPelanggan_TextChanged);
            // 
            // pnlNominal
            // 
            this.pnlNominal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNominal.Location = new System.Drawing.Point(2, 120);
            this.pnlNominal.Name = "pnlNominal";
            this.pnlNominal.Size = new System.Drawing.Size(882, 257);
            this.pnlNominal.TabIndex = 8;
            this.pnlNominal.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PLN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 40);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(859, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(848, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pnlKeterangan
            // 
            this.pnlKeterangan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.pnlKeterangan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKeterangan.Controls.Add(this.label7);
            this.pnlKeterangan.Controls.Add(this.txtKeterangan);
            this.pnlKeterangan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(181)))), ((int)(((byte)(73)))));
            this.pnlKeterangan.Location = new System.Drawing.Point(7, 401);
            this.pnlKeterangan.Name = "pnlKeterangan";
            this.pnlKeterangan.Size = new System.Drawing.Size(870, 100);
            this.pnlKeterangan.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(181)))), ((int)(((byte)(73)))));
            this.label7.Location = new System.Drawing.Point(8, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Keterangan";
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.txtKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKeterangan.Location = new System.Drawing.Point(7, 44);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.ReadOnly = true;
            this.txtKeterangan.Size = new System.Drawing.Size(855, 51);
            this.txtKeterangan.TabIndex = 0;
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.Location = new System.Drawing.Point(5, 564);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(43, 32);
            this.lblHarga.TabIndex = 24;
            this.lblHarga.Text = "Rp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Harga";
            // 
            // btnCheckBuy
            // 
            this.btnCheckBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(89)))), ((int)(((byte)(29)))));
            this.btnCheckBuy.FlatAppearance.BorderSize = 0;
            this.btnCheckBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckBuy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBuy.ForeColor = System.Drawing.Color.White;
            this.btnCheckBuy.Location = new System.Drawing.Point(643, 532);
            this.btnCheckBuy.Name = "btnCheckBuy";
            this.btnCheckBuy.Size = new System.Drawing.Size(234, 48);
            this.btnCheckBuy.TabIndex = 25;
            this.btnCheckBuy.Text = "Check Tagihan";
            this.btnCheckBuy.UseVisualStyleBackColor = false;
            this.btnCheckBuy.Visible = false;
            this.btnCheckBuy.Click += new System.EventHandler(this.btnCheckBuy_Click);
            // 
            // frmPLN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 647);
            this.ControlBox = false;
            this.Controls.Add(this.btnCheckBuy);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlKeterangan);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNominal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPelanggan);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPLN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPLN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlKeterangan.ResumeLayout(false);
            this.pnlKeterangan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPelanggan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Panel pnlNominal;
        public System.Windows.Forms.Panel pnlKeterangan;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Label label4;
        public Component.RoundedButton btnCheckBuy;
        public System.Windows.Forms.Label lblHarga;
        public System.Windows.Forms.Label lblTitle;
    }
}