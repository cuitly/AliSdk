using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Domain
{
    [Serializable]
    public class OfferUserCategory:BaseObject
    {
        public string OfferId;
        public List<string> UserCategorys;
    }
}
