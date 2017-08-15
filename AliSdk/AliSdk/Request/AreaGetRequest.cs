using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{
    public class AreaGetRequest : TopRequest, ITopRequest
    {
        public override string GetApiName()
        {
            return "areaCode.get";
        }

        #region ITopRequest 成员


        public IDictionary<string, string> GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            return parameters;
        }

        #endregion
    }
}
