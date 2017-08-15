using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{
    public class OfferGetRequest : TopRequest, ITopRequest
    {
        public string OfferId;
        public string ReturnFields;

        public override string GetApiName()
        {
            return "offer.get";
        }

        #region ITopRequest 成员


        public IDictionary<string, string> GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("offerId", this.OfferId);
            parameters.Add("returnFields", this.ReturnFields);
            return parameters;
        }

        #endregion
    }
}
