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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadMenu()
        {
            frmMainMenu frm = new frmMainMenu(this);
            frm.TopLevel = false;
            pnlMenu.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void rdbTagihan_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdbTagihan.Checked)
            //{
            //    pnlNominal.Visible = false;
            //}
            //else
            //{
            //    pnlNominal.Visible = true;
            //}
        }

        private void btnPLN_Click(object sender, EventArgs e)
        {
            frmPLN frm = new frmPLN();
            frm.TopLevel = false;
            pnlForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPulsa frm = new frmPulsa();
            frm.TopLevel = false;
            pnlForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMenu();
        }
    }
}
