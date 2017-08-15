using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace AliSdk.Top.Api.parser
{
    public class OfferStockModifyParser : ITopParser<bool>
    {
        public bool Parse(string body)
        {
            JObject obj = JObject.Parse(body);
            if (obj["message"] != null)
            {
                throw new Exception(obj["message"].ToString());
            }
            JToken token = obj["success"];
            if (token == null)
                return false;
            bool isSuccess = false;
            bool.TryParse(token.ToString(), out isSuccess);
            return isSuccess;
        }
    }
}
