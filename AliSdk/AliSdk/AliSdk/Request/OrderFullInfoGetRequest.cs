using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{
    public class OrderFullInfoGetRequest : TopRequest, ITopRequest
    {
        public string OrderId;
        public override string GetApiName()
        {
            return "trade.order.orderDetail.get";
        }

        #region ITopRequest 成员


        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("orderId", this.OrderId);
            return parameters;
        }

        #endregion
    }
}
