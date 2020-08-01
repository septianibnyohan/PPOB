using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPOB.Class.Model
{
    public class ProductInfo
    {
        public string product_code { get; set; }
        public string ProductCode { get { return product_code; } }
        public int Price { get; set; }
        public string Product { get; set; }
        public string product_status { get; set; }
        public string ProductStatus { get { return product_status; } }
    }
}
