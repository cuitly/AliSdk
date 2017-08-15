using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{
    public class OffersGetRequest : TopRequest, ITopRequest
    {
        public string Type;
        public string CategoryId;
        public string GroupIds;
        public string TimeStamp;
        public int PageNo;
        public int PageSize = 35;
        public string OrderBy;
        public string ReturnFields;

        public override string GetApiName()
        {
            return "offer.getPublishOfferList";
        }

        #region ITopRequest 成员


        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("type", this.Type);
            parameters.Add("categoryId", this.CategoryId);
            parameters.Add("groupIds", this.GroupIds);
            parameters.Add("page", this.PageNo);
            parameters.Add("pageSize", this.PageSize);
            parameters.Add("timeStamp", this.TimeStamp);
            parameters.Add("orderBy", this.OrderBy);
            parameters.Add("returnFields", this.ReturnFields);
            return parameters;
        }

        #endregion
    }
}
