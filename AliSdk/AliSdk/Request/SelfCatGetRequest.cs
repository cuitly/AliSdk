using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{
    public class SelfCatGetRequest : TopRequest, ITopRequest
    {
        public string MemberId;

        #region ITopRequest 成员

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("memberId", this.MemberId);
            return parameters;
        }

        #endregion

        public override string GetApiName()
        {
            return "category.getSelfCatlist";
        }
    }
}
