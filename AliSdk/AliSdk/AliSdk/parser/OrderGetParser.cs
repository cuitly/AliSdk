using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliSdk.Top.Api.Domain;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.parser
{
    public class OrderGetParser : ITopParser<Order>
    {
        #region ITopParser<Offer> 成员

        public Order Parse(string body)
        {
            JObject obj = JObject.Parse(body);
            if (obj["message"] != null)
            {
                throw new Exception(obj["message"].ToString());
            }
            Order order = new Order();
            JToken token = obj["result"];
            if (token == null)
                return order;
            JToken token1 = token["toReturn"];
            if (token1 == null)
                return order;
            JArray tokenList = token1 as JArray;
            if (tokenList.Count == 0)
                return order;
            JToken token2 = tokenList[0];
            if (token2 == null)
                return order;

            object result = new JsonSerializer().Deserialize(token2.CreateReader(), typeof(Order));
            return (Order)result;
        }

        #endregion
    }
}
