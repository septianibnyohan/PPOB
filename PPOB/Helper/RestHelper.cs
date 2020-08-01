using PPOB.Repository;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPOB.Helper
{
    public class RestHelper
    {
        public static string Post(string url, string data, string token = null)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);

            if (!String.IsNullOrEmpty(token))
            {
                request.AddHeader("Authorization", "Bearer " + token);
            }

            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", data, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var content = response.Content;

            return content;
        }

        public static string Get(string token, string url)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + token);
            IRestResponse response = client.Execute(request);

            var content = response.Content;

            return content;
        }
    }
}
