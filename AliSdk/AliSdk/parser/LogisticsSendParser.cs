using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliSdk.Top.Api.Domain;
using Newtonsoft.Json.Linq;

namespace AliSdk.Top.Api.parser
{
    public class LogisticsSendParser : ITopParser<bool>
    {
        #region ITopParser<bool> 成员

        public bool Parse(string body)
        {
            JObject obj = JObject.Parse(body);
            JToken token = obj["success"];
            if (token == null)
                return false;
            bool isSuccess = bool.Parse(token.ToString());
            if (!isSuccess)
            {
                throw new Exception(obj["resultMsg"].ToString());
            }
            return isSuccess;
        }

        #endregion
    }
}
