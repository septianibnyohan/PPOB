using PPOB.Class;
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
            //if (txtUser.Text == "dummy" && txtPass.Text == "dummy")
            //{
                
            //}

            if (ApiHelper.Login(txtUser.Text, txtPass.Text))
            {
                MessageBox.Show("Welcome " + Session.UserName + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm frm = new MainForm();
                this.Hide();
                frm.Show();
                var dec = string.Format("{0:#,##0.00}", Session.Deposite).Split(',');
                frm.lblSaldo.Text = dec[0];
                frm.lblName.Text = Session.UserName;
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
