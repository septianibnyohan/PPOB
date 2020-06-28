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
    public partial class frmPLN : Form
    {
        public frmPLN()
        {
            InitializeComponent();
        }

        private void frmPLN_Load(object sender, EventArgs e)
        {
            txbPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txbPelanggan.AutoSize = false;
            txbPelanggan.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
        }
    }
}
