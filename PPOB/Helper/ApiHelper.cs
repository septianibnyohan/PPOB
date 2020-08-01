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
            var content = Post(url, data);

            var res = JsonConvert.DeserializeObject<LoginResponse>(content);

            if (res.status == "success")
            {
                Session.UserName = res.Data.Username;
                Session.Password = password;
                Session.Token = res.Data.Token;
                Session.Deposite = res.Data.Deposite;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Product[] GetListProduct(string code)
        {
            var url = ApiRepo.LIST_PRODUCT + "?code=" + code;
            Login(Session.UserName, Session.Password);

            var content = Get(Session.Token, url);

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

        public static ProductInfo GetProductInfo(string product_code)
        {
            var url = ApiRepo.PRODUCT_INFO + "?product_code=" + product_code;
            Login(Session.UserName, Session.Password);

            var content = Get(Session.Token, url);

            var res = JsonConvert.DeserializeObject<ProductInfoResponse>(content);

            if (res.status == "success")
            {
                var product_info = res.data;
                return product_info;
            }
            else
            {
                var res_data = res.data;
                return res_data;
            }
        }


        public static Topup TopupPulsa(string phone_number, string product_code)
        {
            var url = ApiRepo.TOPUP_PULSA;
            Login(Session.UserName, Session.Password);

            var data = "{\"phone_number\" : \"" + phone_number + "\", \"product_code\" : \"" + product_code + "\"}";
            var content = Post(url, data, Session.Token);

            var res = JsonConvert.DeserializeObject<TopupResponse>(content);

            if (res.status == "success")
            {
                var res_data = res.data;
                return res_data;
            }
            else
            {
                var res_data = res.data;
                return res_data;
            }
        }
    }
}
