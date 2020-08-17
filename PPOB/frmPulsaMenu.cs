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
    public partial class frmPulsaMenu : Form
    {
        private MainForm mainForm = null;
        public frmPulsaMenu(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
        }

        private void btnToken_Click(object sender, EventArgs e)
        {
            //frmPLN frm = new frmPLN();
            //frm.TopLevel = false;
            //mainForm.pnlForm.Controls.Clear();
            //mainForm.pnlForm.Controls.Add(frm);
            //frm.BringToFront();
            //frm.Show();
        }

        private void btnTagihan_Click(object sender, EventArgs e)
        {
            //frmPLN frm = new frmPLN();
            //frm.TopLevel = false;
            //frm.pnlNominal.Visible = false;
            //mainForm.pnlForm.Controls.Clear();
            //mainForm.pnlForm.Controls.Add(frm);
            //frm.BringToFront();
            //frm.Show();
        }

        private void btnPascaBayar_Click(object sender, EventArgs e)
        {
            frmPulsa frm = new frmPulsa();
            frm.TopLevel = false;
            frm.pnlNominal.Visible = false;
            frm.lblNominal.Visible = false;
            mainForm.pnlForm.Controls.Clear();
            mainForm.pnlForm.Controls.Add(frm);
            frm.BringToFront();
            frm.pnlKeterangan.Visible = false;
            frm.Show();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            frmPulsa frm = new frmPulsa();
            frm.TopLevel = false;
            mainForm.pnlForm.Controls.Clear();
            mainForm.pnlForm.Controls.Add(frm);
            frm.BringToFront();
            frm.pnlKeterangan.Visible = true;
            frm.Show();
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu(this.mainForm);
            frm.TopLevel = false;
            this.mainForm.pnlMenu.Controls.Clear();
            this.mainForm.pnlMenu.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
