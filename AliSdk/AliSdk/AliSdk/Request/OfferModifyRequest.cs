using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{
    class OfferModifyRequest : TopRequest, ITopRequest
    {
        public string OfferId;
        public int AmountOnSale;

        public override string GetApiName()
        {
            return "offer.modify.increment";
        }

        #region ITopRequest 成员


        public IDictionary<string, string> GetParameters()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
