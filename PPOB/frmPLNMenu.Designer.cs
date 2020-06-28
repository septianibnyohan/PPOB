namespace PPOB
{
    partial class frmPLNMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPLNMenu));
            this.button3 = new System.Windows.Forms.Button();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.btnTagihan = new System.Windows.Forms.Button();
            this.btnToken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(285, 35);
            this.button3.TabIndex = 32;
            this.button3.Text = " Report";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.FlatAppearance.BorderSize = 0;
            this.btnBackMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackMenu.ForeColor = System.Drawing.Color.White;
            this.btnBackMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnBackMenu.Image")));
            this.btnBackMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackMenu.Location = new System.Drawing.Point(3, 126);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(285, 35);
            this.btnBackMenu.TabIndex = 31;
            this.btnBackMenu.Text = " Kembali Menu Utama";
            this.btnBackMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackMenu.UseVisualStyleBackColor = true;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // btnTagihan
            // 
            this.btnTagihan.FlatAppearance.BorderSize = 0;
            this.btnTagihan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTagihan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTagihan.ForeColor = System.Drawing.Color.White;
            this.btnTagihan.Image = ((System.Drawing.Image)(resources.GetObject("btnTagihan.Image")));
            this.btnTagihan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTagihan.Location = new System.Drawing.Point(6, 44);
            this.btnTagihan.Name = "btnTagihan";
            this.btnTagihan.Size = new System.Drawing.Size(285, 35);
            this.btnTagihan.TabIndex = 30;
            this.btnTagihan.Text = "  PLN Tagihan";
            this.btnTagihan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTagihan.UseVisualStyleBackColor = true;
            this.btnTagihan.Click += new System.EventHandler(this.btnTagihan_Click);
            // 
            // btnToken
            // 
            this.btnToken.FlatAppearance.BorderSize = 0;
            this.btnToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToken.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToken.ForeColor = System.Drawing.Color.White;
            this.btnToken.Image = ((System.Drawing.Image)(resources.GetObject("btnToken.Image")));
            this.btnToken.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToken.Location = new System.Drawing.Point(3, 3);
            this.btnToken.Name = "btnToken";
            this.btnToken.Size = new System.Drawing.Size(285, 35);
            this.btnToken.TabIndex = 29;
            this.btnToken.Text = " PLN Token";
            this.btnToken.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnToken.UseVisualStyleBackColor = true;
            this.btnToken.Click += new System.EventHandler(this.btnToken_Click);
            // 
            // frmPLNMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(291, 419);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBackMenu);
            this.Controls.Add(this.btnTagihan);
            this.Controls.Add(this.btnToken);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPLNMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.Button btnTagihan;
        private System.Windows.Forms.Button btnToken;
    }
}