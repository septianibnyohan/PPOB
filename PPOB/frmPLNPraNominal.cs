using PPOB.Helper;
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
    public partial class frmPLNPraNominal : Form
    {
        private string current_product_code;

        frmPLN frmpln;

        public frmPLNPraNominal(frmPLN frm)
        {
            InitializeComponent();
            frmpln = frm;
        }

        private void frmPLNPraNominal_Load(object sender, EventArgs e)
        {
            AddButton();
        }

        public void AddButton()
        {
            var denoms = new int[] { 20000, 50000, 100000, 200000, 500000, 1000000 };

            foreach (var denom in denoms)
            {
                Button b = new Button();
                b.FlatStyle = FlatStyle.Flat;
                b.BackColor = Color.FromArgb(249, 249, 249);
                b.FlatAppearance.BorderColor = Color.FromArgb(212, 212, 212);
                b.FlatAppearance.MouseOverBackColor = b.BackColor;
                b.BackColorChanged += (s, e) => {
                    b.FlatAppearance.MouseOverBackColor = b.BackColor;
                };

                var product_price = string.Format("{0:#,##0.00}", (denom + 500)).Split(',');
                var denom_format = string.Format("{0:#,##0.00}", denom).Split(',')[0];
                b.Text = denom_format + " - Rp " + product_price[0];
                b.Name = "btn" + denom;
                Font f = new Font("Open Sans", 9, FontStyle.Regular);
                b.Font = f;
                b.Width = 165;
                b.Height = 63;

                b.Click += btnNominal_Click;

                pnlNominal.Controls.Add(b);
            }
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

            var btn_text = button.Text.Replace("\r\n","\n").Split('-');
            var btnID = button.Name;

            //current_product_code = btnID.Replace("btn", "");
            frmpln.current_nominal = btnID.Replace("btn", "");


            frmpln.btnCheckBuy.Visible = true;

            //var product_info = ApiHelper.GetProductInfo(current_product_code);
            //frmpln.txtKeterangan.Text = product_info.Product;
            var product_price = string.Format("{0:#,##0.00}", btn_text[1]).Split(',');
            frmpln.lblHarga.Text = product_price[0];

            //lblHarga.Text = btn_text[btn_text.Count() - 1];
        }
    }
}
