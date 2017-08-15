using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{
    public class ProductAttributesGetRequest : TopRequest, ITopRequest
    {
        public string CategoryID;
        public string TimeStamp;

        public override string GetApiName()
        {
            return "productAttributes.get";
        }

        #region ITopRequest 成员
        public IDictionary<string, string> GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("categoryID", this.CategoryID);
            parameters.Add("timeStamp", this.TimeStamp);
            return parameters;
        }

        #endregion
    }
}
