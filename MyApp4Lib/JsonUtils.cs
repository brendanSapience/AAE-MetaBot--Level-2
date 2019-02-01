
using RestSharp.Deserializers;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp4Lib
{
    class JsonUtils
    {

        public String GetDataFromJsonResponse(String JsonResp)
        {
            RestSharp.RestResponse response = new RestSharp.RestResponse();

            response.Content = JsonResp;

            JsonDeserializer deserial = new JsonDeserializer();

            StdJsonResponseForCurrCheck x = deserial.Deserialize<StdJsonResponseForCurrCheck>(response);
            String Resp = "";
            Resp = x.ticker.price;

            return Resp;
        }
    }

    public class Ticker
    {
        public string @base { get; set; }
        public string target { get; set; }
        public string price { get; set; }
        public string volume { get; set; }
        public string change { get; set; }
    }

    public class StdJsonResponseForCurrCheck
    {
        public Ticker ticker { get; set; }
        public int timestamp { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
}
