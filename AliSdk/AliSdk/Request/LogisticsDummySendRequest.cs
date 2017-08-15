using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{
    public class LogisticsDummySendRequest : TopRequest, ITopRequest
    {
        public string MemberId;
        public string OrderId;
        public string OrderEntryIds;
        public string TradeSourceType;
        public string Remarks;
        public string GmtSystemSend;

        public override string GetApiName()
        {
            return "e56.logistics.dummy.send";
        }

        #region ITopRequest 成员


        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("memberId", this.MemberId);
            parameters.Add("orderId", this.OrderId);
            parameters.Add("orderEntryIds", this.OrderEntryIds);
            parameters.Add("tradeSourceType", this.TradeSourceType);
            parameters.Add("remarks", this.Remarks);
            parameters.Add("gmtSystemSend", this.GmtSystemSend);
            return parameters;
        }

        #endregion
    }
}
