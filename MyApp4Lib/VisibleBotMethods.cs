using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp4Lib
{
    public class VisibleBotMethods
    {
        public String GetPriceOfBitcoin(String Currency)
        {
            String URL = "https://api.cryptonator.com/api/ticker/btc-" + Currency;
            RestUtils ru = new RestUtils();
            JsonUtils ju = new JsonUtils();
            String JsonResp = ru.CallRestGETNoAuth(URL);

            // Turn the JsonResp into just the price item from json
            // NEED TO INSERT CODE HERE
            String BCPrice = ju.GetDataFromJsonResponse(JsonResp);
            return BCPrice;
        }


    }
}
