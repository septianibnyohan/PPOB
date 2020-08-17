using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPOB.Repository
{
    public class ApiRepo
    {
        public static string BASE_URL = Config.IsDev ? "http://misterjadul.com/ppobdev/index.php/" : "http://misterjadul.com/ppob/index.php/";
        public static string LOGIN = BASE_URL + "api/Auth/login";
        public static string LIST_PRODUCT = BASE_URL + "api/Product/List";
        public static string PRODUCT_INFO = BASE_URL + "api/Product/product_info";
        public static string TOPUP_PULSA = BASE_URL + "api/pulsa/Topup";
        public static string INQUIRY = BASE_URL + "api/Transaction/Inquiry";
        public static string PAY_DETAIL = BASE_URL + "api/Transaction/paydetail";
        public static string BUY = BASE_URL + "api/Transaction/buy";
    }
}
