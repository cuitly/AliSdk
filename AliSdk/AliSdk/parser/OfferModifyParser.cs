using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace AliSdk.Top.Api.parser
{
    public class OfferModifyParser : ITopParser<bool>
    {
        #region ITopParser<bool> 成员

        public bool Parse(string body)
        {
            JObject obj = JObject.Parse(body);
            if (obj["message"] != null)
            {
                throw new Exception(obj["message"].ToString());
            }
            JToken token = obj["result"];
            if (token == null)
                return false;
            JToken token1 = token["success"];
            if (token1 == null)
                return false;
            bool isSuccess = false;
            bool.TryParse(token1.ToString(), out isSuccess);
            return isSuccess;
        }

        #endregion
    }
}
