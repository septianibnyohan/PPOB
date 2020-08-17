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
    public partial class frmPLNMenu : Form
    {
        private MainForm mainForm = null;
        public frmPLNMenu(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
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

        private void btnToken_Click(object sender, EventArgs e)
        {
            frmPLN frm = new frmPLN(null);
            frmPLNPraNominal frmNominal = new frmPLNPraNominal(frm);
            
            // Add panel plnpranominal
            frmNominal.TopLevel = false;
            frm.lblTitle.Text = "PLN PRA BAYAR (TOKEN)";
            frm.pnlNominal.Controls.Clear();
            frm.pnlNominal.Controls.Add(frmNominal);
            frm.pnlNominal.Visible = true;
            
            frmNominal.BringToFront();
            frmNominal.Show();

            // add panel pln
            frm.type = "PRA";
            frm.TopLevel = false;
            mainForm.pnlForm.Controls.Clear();
            mainForm.pnlForm.Controls.Add(frm);
            frm.BringToFront();
           
            frm.Show();
        }

        private void btnTagihan_Click(object sender, EventArgs e)
        {
            frmPLNPascaNominal frmNominal = new frmPLNPascaNominal();
            frmPLN frm = new frmPLN(frmNominal);
            frm.type = "PASCA";
            frm.lblTitle.Text = "PLN PASCA BAYAR";
            frm.TopLevel = false;
            //frm.pnlNominal.Visible = true;
            mainForm.pnlForm.Controls.Clear();
            mainForm.pnlForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            
            frmNominal.TopLevel = false;
            frm.pnlNominal.Controls.Add(frmNominal);
            frmNominal.BringToFront();
            frmNominal.Show();
        }
    }
}
