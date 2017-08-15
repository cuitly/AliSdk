using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{
    public class LogisticsOfflineSendRequest : TopRequest, ITopRequest
    {
        public string MemberId;
        public string OrderId;
        public string OrderEntryIds;
        public string TradeSourceType;
        public string Remarks;
        public string LogisticsCompanyId;
        public string SelfCompanyName;
        public string LogisticsBillNo;
        public string GmtSystemSend;
        public string GmtLogisticsCompanySend;

        public override string GetApiName()
        {
            return "e56.logistics.offline.send";
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
            parameters.Add("logisticsCompanyId", this.LogisticsCompanyId);
            parameters.Add("selfCompanyName", this.SelfCompanyName);
            parameters.Add("logisticsBillNo", this.LogisticsBillNo);
            if (!string.IsNullOrEmpty(this.GmtSystemSend))
            {
                string Gmt_SystemSend = DateTime.Parse(this.GmtSystemSend).ToString("yyyy-MM-dd HH:mm:ss");
                parameters.Add("gmtSystemSend", Gmt_SystemSend);
            }
            if (!string.IsNullOrEmpty(this.GmtLogisticsCompanySend))
            {
                string Gmt_LogisticsCompanySend = DateTime.Parse(this.GmtLogisticsCompanySend).ToString("yyyy-MM-dd HH:mm:ss");
                parameters.Add("gmtLogisticsCompanySend", Gmt_LogisticsCompanySend);
            }
            return parameters;
        }

        #endregion
    }
}
