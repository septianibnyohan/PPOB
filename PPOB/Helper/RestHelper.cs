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
        public static string Post(string url, string data)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", data, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var content = response.Content;

            return content;
        }

        public static string Get(string url)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            var content = response.Content;

            return content;
        }
    }
}
