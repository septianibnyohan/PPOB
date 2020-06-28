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
        }
    }
}
