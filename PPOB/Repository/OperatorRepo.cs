using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PPOB.Repository
{
    public class OperatorRepo
    {
        public static Dictionary<string, Bitmap> Data { get; set; }


        public static void Load()
        {
            Data = GetBitmap();
        }

        private static Dictionary<string, Bitmap> GetBitmap()
        {
            //Loading Bitmap
            var bitmap = new Dictionary<string, Bitmap>()
            {
                // Telkomsel
                { "0811", Properties.Resources.simpati_2},
                { "0812", Properties.Resources.simpati_2},
                { "0813", Properties.Resources.simpati_2},
                { "0821", Properties.Resources.simpati_2},
                { "0822", Properties.Resources.simpati_2},
                { "0852", Properties.Resources.simpati_2},
                { "0853", Properties.Resources.simpati_2},
                { "0823", Properties.Resources.simpati_2},
                { "0851", Properties.Resources.simpati_2},

                // INDOSAT
                { "0814", Properties.Resources.im3_2},
                { "0815", Properties.Resources.im3_2},
                { "0816", Properties.Resources.im3_2},
                { "0855", Properties.Resources.im3_2},
                { "0856", Properties.Resources.im3_2},
                { "0857", Properties.Resources.im3_2},
                { "0858", Properties.Resources.im3_2},

                // XL
                { "0817", Properties.Resources.xl_3},
                { "0818", Properties.Resources.xl_3},
                { "0819", Properties.Resources.xl_3},
                { "0859", Properties.Resources.xl_3},
                { "0877", Properties.Resources.xl_3},
                { "0878", Properties.Resources.xl_3},

                // AXIS
                { "0838", Properties.Resources.axis_2},
                { "0831", Properties.Resources.axis_2},
                { "0832", Properties.Resources.axis_2},
                { "0833", Properties.Resources.axis_2},

                // THREE
                { "0895", Properties.Resources.tri_2},
                { "0896", Properties.Resources.tri_2},
                { "0897", Properties.Resources.tri_2},
                { "0898", Properties.Resources.tri_2},
                { "0899", Properties.Resources.tri_2},

                // SMARTFREN
                { "0881", Properties.Resources.smartfren_3},
                { "0882", Properties.Resources.smartfren_3},
                { "0883", Properties.Resources.smartfren_3},
                { "0884", Properties.Resources.smartfren_3},
                { "0885", Properties.Resources.smartfren_3},
                { "0886", Properties.Resources.smartfren_3},
                { "0887", Properties.Resources.smartfren_3},
                { "0888", Properties.Resources.smartfren_3},
                { "0889", Properties.Resources.smartfren_3},
            };

            return bitmap;
        }
    }
}
