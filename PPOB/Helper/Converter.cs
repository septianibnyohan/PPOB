using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PPOB.Helper
{
    public class Converter
    {
        public static string Rupiah(int nominal)
        {
            var nom = string.Format("{0:#,##0.00}", nominal).Split(',');
            return nom[0];
        }

        public static int Nominal(string rupiah)
        {
            string snominal = rupiah.Replace("Rp", "").Replace(".", "");

            int nominal = Convert.ToInt32(snominal);
            return nominal;
        }

        public static string ToRupiah(int angka)
        {
            var rupiah =  String.Format(CultureInfo.CreateSpecificCulture("id-id"), "{0:N}", angka);
            var rupiahs = rupiah.Split(',');
            return rupiahs[0];
        }
        /**
         * // Usage example: //
         * int angka = 10000000;
         * System.Console.WriteLine(angka.ToRupiah()); // -> Rp. 10.000.000
         */

        public static int ToAngka(string rupiah)
        {
            return int.Parse(Regex.Replace(rupiah, @",.*|\D", ""));
        }
        /**
         * // Usage example: //
         * string rupiah = "Rp 10.000.123,00";
         * System.Console.WriteLine(rupiah.ToAngka()); // -> 10000123
         */
    }
}
