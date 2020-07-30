using Newtonsoft.Json;
using PPOB.Class;
using PPOB.Class.Model;
using PPOB.Class.Response;
using PPOB.Repository;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPOB.Helper
{
    class ApiHelper : RestHelper
    {
        public static bool Login(string username, string password)
        {

            var url = ApiRepo.LOGIN;
            var data = "{\"username\" : \"" + username + "\", \"password\" : \"" + password + "\"}";
            var client = new RestClient(url);
            var content = Post(url, data);

            var res = JsonConvert.DeserializeObject<LoginResponse>(content);

            if (res.status == "success")
            {
                Session.UserName = res.Data.Username;
                Session.Deposite = res.Data.Deposite;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Product[] GetListProduct()
        {
            var url = ApiRepo.LIST_PRODUCT + "?code=ISAT";

            var content = Get(url);

            var res = JsonConvert.DeserializeObject<ProductListResponse>(content);

            if (res.status == "success")
            {
                var products = res.data;
                return products;
            }
            else
            {
                return null;
            }
        }
    }
}
