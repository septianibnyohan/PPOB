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
        public frmPulsa()
        {
            InitializeComponent();
        }

        private void frmPulsa_Load(object sender, EventArgs e)
        {
            txbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txbPhone.AutoSize = false;
            txbPhone.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });

            initialColorButton();
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

            var btn_text = button.Text.Replace("\r\n","\n").Split('\n');

            lblHarga.Text = btn_text[1];
        }
    }
}
