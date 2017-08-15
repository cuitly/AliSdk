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
            Order order = new Order();
            JToken token = obj["orderModel"];
            if (token == null)
                return order;

            object result = new JsonSerializer().Deserialize(token.CreateReader(), typeof(Order));
            return (Order)result;
        }

        #endregion
    }
}
