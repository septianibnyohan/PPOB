using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPOB.Repository
{
    public static class ApiRepo
    {
        public const string BASE_URL = "http://misterjadul.com/ppobdev/index.php/";
        public const string LOGIN = BASE_URL + "api/Auth/login";
        public const string LIST_PRODUCT = BASE_URL + "api/Product/List";
        public const string PRODUCT_INFO = BASE_URL + "api/Product/product_info";
        public const string TOPUP_PULSA = BASE_URL + "api/pulsa/Topup";
    }
}
