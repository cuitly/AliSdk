using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using AliSdk.Top.Api.Domain;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.parser
{
    public class OfferExpireParser : ITopParser<ReturnObject>
    {
        #region ITopParser<Offer> 成员

        public ReturnObject Parse(string body)
        {
            JObject obj = JObject.Parse(body);

            ReturnObject returnObject = new ReturnObject();
            List<ReturnInfo> returnInfos = new List<ReturnInfo>();
            JToken token = obj["result"];
            if (token == null)
                return returnObject;
            JToken token1 = token["toReturn"];
            if (token1 == null)
                return returnObject;
            JArray tokenList = token1 as JArray;
            if (tokenList.Count == 0)
                return returnObject;

            for (int i = 0; i < tokenList.Count; i++)
            {
                object result = new JsonSerializer().Deserialize(tokenList[i].CreateReader(), typeof(ReturnInfo));
                ReturnInfo returnInfo = (ReturnInfo)result;
                returnInfos.Add(returnInfo);
            }
            returnObject.returnObject = returnInfos;
            return returnObject;
        }

        #endregion
    }
}
