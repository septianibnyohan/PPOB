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
    public partial class frmPLN : Form
    {
        frmPLNPascaNominal frmNominal;
        public string type;
        public string current_nominal;
        bool isCheck;
        public frmPLN(frmPLNPascaNominal frmNominal)
        {
            InitializeComponent();
            this.frmNominal = frmNominal;
            isCheck = true;
        }

        private void frmPLN_Load(object sender, EventArgs e)
        {
            txtPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtPelanggan.AutoSize = false;
            txtPelanggan.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });

            if (type == "PRA")
            {
                btnCheckBuy.Text = "Beli";
            }
        }

        private void CheckTagihan()
        {
            var idpel = txtPelanggan.Text.Trim();

            dynamic obj_data = new
            {
                idpel = idpel
            };

            var res = ApiHelper.Inquiry(obj_data);

            if (res.status == "fail")
            {
                MessageBox.Show(res.data.KET.ToString());
            }
            else
            {
                frmNominal.lblIdPel.Text = res.IDPEL1.ToString();
                frmNominal.lblNama.Text = res.NAMA_PELANGGAN.ToString();
                frmNominal.lblTotalBayar.Text = "Rp. " + Converter.ToRupiah(Convert.ToInt32(res.SALDO_TERPOTONG));

                var list_tagihan = res.PERIODE.ToString().Split(',');

                frmNominal.lblTotalTagihan.Text = list_tagihan.Length + " BULAN";
                frmNominal.lblBlTh.Text = res.PERIODE;
                frmNominal.lblRpTagPln.Text = "Rp. " + Converter.ToRupiah(Convert.ToInt32(res.NOMINAL));
                frmNominal.lblAdminBank.Text = "Rp. " + Converter.ToRupiah(Convert.ToInt32(res.ADMIN));

                pnlNominal.Visible = true;
                pnlNominal.Refresh();

                lblHarga.Text = "Rp. " + Converter.ToRupiah(Convert.ToInt32(res.SALDO_TERPOTONG));
                frmNominal.lblRef2.Text = res.REF2.ToString();

                MessageBox.Show(res.KET.ToString());

                isCheck = false;
                btnCheckBuy.Text = "Bayar";
                txtKeterangan.Text = "Check tagihan " + idpel + " berhasil";
            }
        }

        private void btnCheckBuy_Click(object sender, EventArgs e)
        {
            btnCheckBuy.Enabled = false;
            btnCheckBuy.Refresh();

            if (type == "PASCA")
            {
                if (isCheck)
                {
                    CheckTagihan();
                }
                else
                {
                    var idpel = txtPelanggan.Text;
                    //int nominal = Converter.ToAngka(lblHarga.Text);
                    int nominal = Converter.ToAngka(frmNominal.lblRpTagPln.Text);
                    int admin = Converter.ToAngka(frmNominal.lblAdminBank.Text);
                    string ref2 = frmNominal.lblRef2.Text;

                    var res = ApiHelper.PayDetail(frmNominal.lblIdPel.Text, nominal, ref2);

                    if (res.status == "success")
                    {
                        MessageBox.Show(res.Data.keterangan.ToString());

                        MainForm.lblSaldo.Text = Converter.Rupiah(Convert.ToInt32(res.Data.SISA_SALDO));

                        txtPelanggan.Clear();
                        pnlNominal.Visible = false;
                        btnCheckBuy.Text = "Check Tagihan";
                        txtKeterangan.Text = "Pembayaran " + idpel + " sebesar " + lblHarga.Text + " berhasil";
                        lblHarga.Text = "Rp";

                        string sisa_saldo = Converter.ToRupiah(Convert.ToInt32(res.Data.sisa_saldo));//string.Format("{0:#,##0.00}", Convert.ToInt32(res.sisa_saldo)).Split(',');
                        MainForm.lblSaldo.Text = sisa_saldo;
                    }
                    else
                    {
                        MessageBox.Show(res.Data.keterangan.ToString());
                        txtPelanggan.Clear();
                        pnlNominal.Visible = false;
                        btnCheckBuy.Text = "Check Tagihan";
                        txtKeterangan.Text = res.Data.keterangan;
                        lblHarga.Text = "Rp";
                        string sisa_saldo = Converter.ToRupiah(Convert.ToInt32(res.Data.sisa_saldo));//string.Format("{0:#,##0.00}", Convert.ToInt32(res.sisa_saldo)).Split(',');
                        MainForm.lblSaldo.Text = sisa_saldo;
                    }

                    
                }
            }
            else if (type == "PRA")
            {
                var idpel = txtPelanggan.Text;
                var product_code = "PLNPRAH";
                var nominal = current_nominal;

                if (idpel.Trim().Length == 0)
                {
                    MessageBox.Show("ID Pelanggan tidak boleh kosong", "IDPEL KOSONG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnCheckBuy.Enabled = true;
                    return;
                }

                var res = ApiHelper.Buy(idpel, nominal, product_code);

                var frmKet = new frmPLNPraKeterangan();
                frmKet.TopLevel = false;
                pnlNominal.Controls.Clear();
                pnlNominal.Controls.Add(frmKet);
                frmKet.BringToFront();
                frmKet.Show();

                frmKet.lblIdPel.Text = res.IDPEL1.ToString();
                frmKet.lblNama.Text = res.NAMA_PELANGGAN.ToString();
                frmKet.lblWaktu.Text = res.WAKTU.ToString();
                frmKet.lblNominal.Text = res.NOMINAL.ToString();
                frmKet.lblAdmin.Text = res.ADMIN.ToString();
                frmKet.txtToken.Text = res.REF3.ToString();
                frmKet.lblSubscriber.Text = res.DETAIL.SUBSCRIBERSEGMENTATION.ToString();
                frmKet.lblPowerConsuming.Text = res.DETAIL.POWERCONSUMINGCATEGORY.ToString();
                frmKet.lblPowerPurchase.Text = res.DETAIL.POWERPURCHASE.ToString();
                frmKet.lblMino.Text = res.DETAIL.MINORUNITOFPOWERPURCHASE.ToString();
                frmKet.lblPurchased.Text = res.DETAIL.PURCHASEDKWHUNIT.ToString();
                frmKet.lblMino2.Text = res.DETAIL.MINORUNITOFPURCHASEDKWHUNIT.ToString();

                MessageBox.Show(res.keterangan.ToString());
                txtPelanggan.Clear();
                btnCheckBuy.Visible = false;
                txtKeterangan.Text = "Pembelian Token Listrik " + idpel + " sebesar " + nominal + " berhasil";
                lblHarga.Text = "Rp";

                string sisa_saldo = Converter.ToRupiah(Convert.ToInt32(res.sisa_saldo));//string.Format("{0:#,##0.00}", Convert.ToInt32(res.sisa_saldo)).Split(',');
                MainForm.lblSaldo.Text = sisa_saldo;
                //MessageBox.Show("This is Pra Bayar");
            }

            
            btnCheckBuy.Enabled = true;
        }

        private void txtPelanggan_TextChanged(object sender, EventArgs e)
        {
            if (type == "PASCA")
            {
                isCheck = true;
                btnCheckBuy.Visible = txtPelanggan.Text.Trim().Length > 0;
                pnlNominal.Visible = false;
                btnCheckBuy.Text = "Check Tagihan";
            }
        }
    }
}
