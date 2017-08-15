using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{
    public class OrderFullInfoGetRequest : TopRequest, ITopRequest
    {
        public string OrderId;
        public bool NeedOrderEntries;
        public bool NeedInvoiceInfo;
        public bool NeedOrderMemoList;
        public bool NeedLogisticsOrderList;
        public override string GetApiName()
        {
            return "trade.order.detail.get";
        }

        #region ITopRequest 成员


        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.OrderId);
            parameters.Add("needOrderEntries", this.NeedOrderEntries);
            parameters.Add("needInvoiceInfo", this.NeedInvoiceInfo);
            parameters.Add("needOrderMemoList", this.NeedOrderMemoList);
            parameters.Add("needLogisticsOrderList", this.NeedOrderMemoList);
            return parameters;
        }

        #endregion
    }
}
