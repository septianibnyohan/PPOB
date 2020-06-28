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
    public partial class frmMainMenu : Form
    {
        private Form1 mainForm = null;
        public frmMainMenu(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void btnPLN_Click(object sender, EventArgs e)
        {
            this.mainForm.pnlMenu.Controls.Clear();
            frmPLNMenu frm = new frmPLNMenu(mainForm);
            frm.TopLevel = false;
            this.mainForm.pnlMenu.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnPulsaGroup_Click(object sender, EventArgs e)
        {
            this.mainForm.pnlMenu.Controls.Clear();
            frmPulsaMenu frm = new frmPulsaMenu(mainForm);
            frm.TopLevel = false;
            this.mainForm.pnlMenu.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
