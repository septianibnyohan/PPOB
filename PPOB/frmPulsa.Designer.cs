namespace PPOB
{
    partial class frmPulsa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPulsa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picOperatorLogo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.pnlKeterangan = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlNominal = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBuy = new PPOB.Component.RoundedButton();
            this.lblNominal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOperatorLogo)).BeginInit();
            this.pnlKeterangan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 40);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(859, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pulsa dan Paket Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nomor Telepon";
            // 
            // txbPhone
            // 
            this.txbPhone.BackColor = System.Drawing.Color.White;
            this.txbPhone.Location = new System.Drawing.Point(7, 72);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(870, 26);
            this.txbPhone.TabIndex = 12;
            this.txbPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPhone_KeyDown);
            this.txbPhone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbPhone_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nominal";
            // 
            // picOperatorLogo
            // 
            this.picOperatorLogo.Location = new System.Drawing.Point(806, 72);
            this.picOperatorLogo.Name = "picOperatorLogo";
            this.picOperatorLogo.Size = new System.Drawing.Size(64, 24);
            this.picOperatorLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOperatorLogo.TabIndex = 15;
            this.picOperatorLogo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Harga";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.Location = new System.Drawing.Point(5, 564);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(43, 32);
            this.lblHarga.TabIndex = 18;
            this.lblHarga.Text = "Rp";
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
            this.pnlKeterangan.TabIndex = 21;
            this.pnlKeterangan.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKeterangan_Paint);
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
            // pnlNominal
            // 
            this.pnlNominal.AutoScroll = true;
            this.pnlNominal.Location = new System.Drawing.Point(7, 138);
            this.pnlNominal.Name = "pnlNominal";
            this.pnlNominal.Size = new System.Drawing.Size(882, 257);
            this.pnlNominal.TabIndex = 23;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(89)))), ((int)(((byte)(29)))));
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(643, 532);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(234, 48);
            this.btnBuy.TabIndex = 22;
            this.btnBuy.Text = "Beli";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Visible = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblNominal
            // 
            this.lblNominal.AutoSize = true;
            this.lblNominal.Location = new System.Drawing.Point(6, 116);
            this.lblNominal.Name = "lblNominal";
            this.lblNominal.Size = new System.Drawing.Size(60, 19);
            this.lblNominal.TabIndex = 24;
            this.lblNominal.Text = "Nominal";
            // 
            // frmPulsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 647);
            this.ControlBox = false;
            this.Controls.Add(this.lblNominal);
            this.Controls.Add(this.pnlNominal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.pnlKeterangan);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picOperatorLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPulsa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPulsa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOperatorLogo)).EndInit();
            this.pnlKeterangan.ResumeLayout(false);
            this.pnlKeterangan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picOperatorLogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label label7;
        private Component.RoundedButton btnBuy;
        public System.Windows.Forms.TextBox txtKeterangan;
        public System.Windows.Forms.Panel pnlKeterangan;
        public System.Windows.Forms.FlowLayoutPanel pnlNominal;
        public System.Windows.Forms.Label lblNominal;
    }
}