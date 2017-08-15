using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{
    public class OffersUserCategoryGetRequest : TopRequest, ITopRequest
    {
        public string OfferIds;

        public override string GetApiName()
        {
            return "userCategory.get.offerIds";
        }

        #region ITopRequest 成员


        public IDictionary<string, string> GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("offerIds", this.OfferIds);
            return parameters;
        }

        #endregion
    }
}
