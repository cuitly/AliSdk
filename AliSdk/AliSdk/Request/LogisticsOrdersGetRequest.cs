using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{
    public class LogisticsOrdersGetRequest : TopRequest, ITopRequest
    {
        public string MemberId;
        public string Fields;
        public string TradeSourceType;
        public string OrderId;

        public override string GetApiName()
        {
            return "e56.logistics.orders.get";
        }

        #region ITopRequest 成员


        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("memberId", this.MemberId);
            parameters.Add("fields", this.Fields);
            parameters.Add("tradeSourceType", this.TradeSourceType);
            parameters.Add("orderId", this.OrderId);
            return parameters;
        }

        #endregion
    }
}
