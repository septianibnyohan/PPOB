using PPOB.Helper;
using PPOB.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PPOB
{
    public partial class frmPulsa : Form
    {
        private bool listrigger = false;
        private string current_product_code;
        private string current_operator;
        public frmPulsa()
        {
            InitializeComponent();
            //pictureBox3.Image = Properties.Resources.smartfren_3;
        }

        private void frmPulsa_Load(object sender, EventArgs e)
        {
            txbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txbPhone.AutoSize = false;
            txbPhone.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });

            initialColorButton();
        }

        private void AddButton()
        {
            var products = ApiHelper.GetListProduct(current_operator);

            foreach (var product in products)
            {
                Button b = new Button();
                b.FlatStyle = FlatStyle.Flat;
                b.BackColor = Color.FromArgb(249, 249, 249);
                b.FlatAppearance.BorderColor = Color.FromArgb(212, 212, 212);
                b.FlatAppearance.MouseOverBackColor = b.BackColor;
                b.BackColorChanged += (s, e) => {
                     b.FlatAppearance.MouseOverBackColor = b.BackColor;
                 };

                var product_price = string.Format("{0:#,##0.00}", product.Price).Split(',');
                b.Text = product.Description + " - Rp " + product_price[0];
                b.Name = "btn" + product.ProductCode;
                Font f = new Font("Open Sans", 9, FontStyle.Regular);
                b.Font = f;
                b.Width = 165;
                b.Height = 63;

                b.Click += btnNominal_Click;

                pnlNominal.Controls.Add(b);
            }
        }

        private void initialColorButton()
        {
            foreach (Control c in ((Control)pnlNominal).Controls)
            {
                if (c is Button)
                {
                    ((Button)c).FlatStyle = FlatStyle.Flat;
                    ((Button)c).BackColor = Color.FromArgb(249, 249, 249);
                    ((Button)c).FlatAppearance.BorderColor = Color.FromArgb(212, 212, 212);
                    ((Button)c).FlatAppearance.MouseOverBackColor = ((Button)c).BackColor;
                    ((Button)c).BackColorChanged += (s, e) => {
                        ((Button)c).FlatAppearance.MouseOverBackColor = ((Button)c).BackColor;
                    };
                }
            }
        }

        private void pnlKeterangan_Paint(object sender, PaintEventArgs e)
        {
            Color greenCustom = new Color();
            greenCustom = Color.FromArgb(66, 181, 73);

            ControlPaint.DrawBorder(e.Graphics, pnlKeterangan.ClientRectangle,
            greenCustom, 1/2, ButtonBorderStyle.Solid, // left
            greenCustom, 1/2, ButtonBorderStyle.Solid, // top
            greenCustom, 1/2, ButtonBorderStyle.Solid, // right
            greenCustom, 1/2, ButtonBorderStyle.Solid);// bottom
        }

        private void btnNominal_Click(object sender, EventArgs e)
        {
            foreach (Control c in ((Control)pnlNominal).Controls)
            {
                if (c is Button)
                {
                    ((Button)c).BackColor = Color.FromArgb(249, 249, 249);
                    ((Button)c).FlatAppearance.BorderColor = Color.FromArgb(212, 212, 212);
                    ((Button)c).FlatStyle = FlatStyle.Flat;
                }
            }

            Color white = new Color();
            white = Color.FromArgb(255, 255, 255);

            Color greenCustom = new Color();
            greenCustom = Color.FromArgb(66, 181, 73);

            var button = (Button)sender;
            button.BackColor = white;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = greenCustom;

            //var btn_text = button.Text.Replace("\r\n","\n").Split('-');
            var btnID = button.Name;

            current_product_code = btnID.Replace("btn", "");

            
            btnBuy.Visible = true;

            var product_info = ApiHelper.GetProductInfo(current_product_code);
            txtKeterangan.Text = product_info.Product;
            var product_price = string.Format("{0:#,##0.00}", product_info.Price).Split(',');
            lblHarga.Text = "Rp " + product_price[0];
            
            //lblHarga.Text = btn_text[btn_text.Count() - 1];
        }

        private void txbPhone_KeyDown(object sender, KeyEventArgs e)
        {
            //var phone = txbPhone.Text;


            //if (phone.Length >= 4)
            //{
            //    var prefix_phone = phone.Substring(0, 4);
            //    picOperatorLogo.Image = OperatorRepo.Data[prefix_phone];
            //}

            
        }

        private void txbPhone_KeyUp(object sender, KeyEventArgs e)
        {
            var phone = txbPhone.Text;


            if (phone.Length >= 4)
            {
                var prefix_phone = phone.Substring(0, 4);

                if (OperatorRepo.Data.ContainsKey(prefix_phone))
                {
                    picOperatorLogo.Image = OperatorRepo.Data[prefix_phone];
                    current_operator = OperatorRepo.Code[prefix_phone];

                    if (!listrigger)
                    {
                        AddButton();
                        listrigger = true;
                    }                    
                }
            }
            else
            {
                picOperatorLogo.Image = null;

                while (pnlNominal.Controls.Count > 0)
                {
                    pnlNominal.Controls.RemoveAt(0);
                }
                btnBuy.Visible = false;
                listrigger = false;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var product_code = current_product_code;
            var phone_number = txbPhone.Text;

            var res = ApiHelper.TopupPulsa(product_code, phone_number);

            var saldo = string.Format("{0:#,##0.00}", res.SisaSaldo).Split(',');

            MainForm.lblSaldo.Text = saldo[0];

            MessageBox.Show(res.Keterangan + ".");
        }
    }
}
