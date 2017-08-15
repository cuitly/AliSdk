using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{
    public class LogisticsListGetRequest : TopRequest, ITopRequest
    {
        public string MemberId;

        public override string GetApiName()
        {
            return "trade.logisticsCompany.logisticsCompanyList.get";
        }

        #region ITopRequest 成员


        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("memberId", this.MemberId);
            return parameters;
        }

        #endregion
    }
}
