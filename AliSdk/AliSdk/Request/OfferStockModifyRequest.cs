using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{
    public class OfferStockModifyRequest : TopRequest, ITopRequest
    {
        public long OfferId { get; set; }
        public int OfferAmountChange { get; set; }
        public string SkuAmountChange { get; set; }

        public override string GetApiName()
        {
            return "offer.modify.stock";
        }


        public IDictionary<string, string> GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("offerId", this.OfferId.ToString());
            parameters.Add("offerAmountChange", this.OfferAmountChange.ToString());
            if (!string.IsNullOrEmpty(this.SkuAmountChange))
            {
                parameters.Add("skuAmountChange", this.SkuAmountChange);
            }
            return parameters;
        }
    }
}
