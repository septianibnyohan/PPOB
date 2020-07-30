using PPOB.Class.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPOB.Class.Response
{
    public class ProductListResponse : Basic
    {
        public Product[] data { get; set; }
    }
}
