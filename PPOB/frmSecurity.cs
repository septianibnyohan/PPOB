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
    public partial class frmSecurity : Form
    {
        public frmSecurity()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "dummy" && txtPass.Text == "dummy")
            {
                MainForm frm = new MainForm();
                this.Hide();
                frm.Show();
            }
        }
    }
}
