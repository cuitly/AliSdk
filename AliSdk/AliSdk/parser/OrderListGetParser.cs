using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliSdk.Top.Api.Domain;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.parser
{
    class OrderListGetParser : ITopParser<OrderListGetResponse>
    {
        #region ITopParser<List<SellerCat>> 成员

        public OrderListGetResponse Parse(string body)
        {
            JObject obj = JObject.Parse(body);

            int resultTotal = 0;
            List<Order> orders = new List<Order>();
            OrderListGetResponse response = new OrderListGetResponse();
            response.ResultTotal = resultTotal;
            response.Orders = orders;
            JToken token = obj["orderListResult"];
            if (token == null)
                return response;
            JToken token1 = token["modelList"];
            if (token1 == null)
                return response;
            resultTotal = int.Parse(token["totalCount"].ToString());
            response.ResultTotal = resultTotal;
            JArray tokenList = token1 as JArray;
            if (tokenList.Count == 0)
                return response;


            for (int i = 0; i < tokenList.Count; i++)
            {
                object order = new JsonSerializer().Deserialize(tokenList[i].CreateReader(), typeof(Order));
                orders.Add((Order)order);
            }

            return response;
        }

        #endregion
    }

    public class OrderListGetResponse
    {
        public int ResultTotal = 0;
        public List<Order> Orders = new List<Order>();
    }
}
