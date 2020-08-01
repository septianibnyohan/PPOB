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
        public static Dictionary<string, string> Code { get; set; }


        public static void Load()
        {
            Data = GetBitmap();
            Code = GetCode();
        }

        private static Dictionary<string, string> GetCode()
        {
            //Loading Bitmap
            var code = new Dictionary<string, string>()
            {
                // Telkomsel
                { "0811", "TELKOMSEL"},
                { "0812", "TELKOMSEL"},
                { "0813", "TELKOMSEL"},
                { "0821", "TELKOMSEL"},
                { "0822", "TELKOMSEL"},
                { "0852", "TELKOMSEL"},
                { "0853", "TELKOMSEL"},
                { "0823", "TELKOMSEL"},
                { "0851", "TELKOMSEL"},

                // INDOSAT
                { "0814", "ISAT"},
                { "0815", "ISAT"},
                { "0816", "ISAT"},
                { "0855", "ISAT"},
                { "0856", "ISAT"},
                { "0857", "ISAT"},
                { "0858", "ISAT"},

                // XL
                { "0817", "AXIS / XL"},
                { "0818", "AXIS / XL"},
                { "0819", "AXIS / XL"},
                { "0859", "AXIS / XL"},
                { "0877", "AXIS / XL"},
                { "0878", "AXIS / XL"},

                // AXIS
                { "0838", "AXIS / XL"},
                { "0831", "AXIS / XL"},
                { "0832", "AXIS / XL"},
                { "0833", "AXIS / XL"},

                // THREE
                { "0895", "KARTU3"},
                { "0896", "KARTU3"},
                { "0897", "KARTU3"},
                { "0898", "KARTU3"},
                { "0899", "KARTU3"},

                // SMARTFREN
                { "0881", "SMART"},
                { "0882", "SMART"},
                { "0883", "SMART"},
                { "0884", "SMART"},
                { "0885", "SMART"},
                { "0886", "SMART"},
                { "0887", "SMART"},
                { "0888", "SMART"},
                { "0889", "SMART"}
            };

            return code;
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
