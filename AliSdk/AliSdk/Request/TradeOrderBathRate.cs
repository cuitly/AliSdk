using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{

    public class Map
    {
        public string orderID;
        public TradeRateParam traderateparam;
    }

    public class TradeRateParam
    {
        public string content;
        public string starLevel;
    }

    public class TradeOrderBathRate : TopRequest, ITopRequest
    {
        //public string orderid;
        //public string content;
        //public string starLevel;
        public Map map;

        public override string GetApiName()
        {
            return "trade.order.batch.rate";
        }

        #region ITopRequest 成员


        public IDictionary<string, string> GetParameters()
        {
            string orders;
            //orders = "{\"orders\":{\"390944086163479\":[{\"starLevel\":\"5\",\"content\":\"好评\"}]}}";
            //orders = "{\"postMemberId\":\"joeelife168\",\"bizType\":\"trade\",\"orders\":{\"390944086163479\":[{\"starLevel\" : \"5\",\"content\": \"很好\"}]}}";
            orders = "{\"orders\":{\"390944086163479\":[{\"starLevel\":\"5\",\"content\":\"很好\"}]}}";
            string tempJson = Newtonsoft.Json.JsonConvert.SerializeObject(this.map);

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            //parameters.Add("orders", Newtonsoft.Json.JsonConvert.SerializeObject(this.map));
            parameters.Add("orders", orders);


            //parameters.Add("orderid", this.orderid);
            //parameters.Add("content", this.content); 
            //parameters.Add("starLevel", this.starLevel);
            return parameters;
        }

        #endregion
    }
}
