using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace j1Lib
{
    public class REST
    {
        private RestClient api;
        public REST(string api)
        {
            this.api = new RestClient(api);
        }
        public void GET(string url, NameValueCollection data, Action<IRestResponse> callback)
        {
            RestRequest request = new RestRequest(url, Method.GET);
            if (data != null)            {
                foreach (string key in data)
                {
                    request.AddQueryParameter(key,data[key]);
                }
            }
            request.AddHeader("User-Agent", "j1Lib");
            api.ExecuteAsync(request, callback);
        }
        public void POST(string url, NameValueCollection data, Action<IRestResponse> callback)
        {
            RestRequest request = new RestRequest(url, Method.POST);
            if (data != null)
            {
                foreach (string key in data)
                {
                    request.AddParameter(key, data[key]);
                }
            }
            request.AddHeader("User-Agent", "j1Lib");
            api.ExecuteAsync(request, callback);
        }
    }
}
