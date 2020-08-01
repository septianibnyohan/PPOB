using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPOB.Class.Model
{
    public class Topup
    {
        public string product_code { get; set; }
        public string ProductCode { get { return product_code; } }
        public string phone_number { get; set; }
        public string PhoneNumber { get { return phone_number; } }
        public long waktu { get; set; }
        public string SN { get; set; }
        //public int Nominal { get; set; }
        public string Ref { get; set; }
        public string Keterangan { get; set; }
        public int saldo_terpotong { get; set; }
        public int SaldoTerpotong { get { return saldo_terpotong; } }
        public int sisa_saldo { get; set; }
        public int SisaSaldo { get { return sisa_saldo; } }
    }
}
