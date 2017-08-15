using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliSdk.Top.Api.Domain;
using Newtonsoft.Json.Linq;
using Carpa.Web.Ajax;

namespace AliSdk.Top.Api.parser
{
    public class OfferUserCategoryGetParser : ITopParser<List<OfferUserCategory>>
    {
        #region ITopParser<List<OfferUserCategory>> 成员

        public List<OfferUserCategory> Parse(string body)
        {
            JObject obj = JObject.Parse(body);
            if (obj["message"] != null)
            {
                throw new Exception(obj["message"].ToString());
            }
            List<OfferUserCategory> userCategorys = new List<OfferUserCategory>();
            JToken token = obj["result"];
            if (token == null)
                return userCategorys;
            JToken token1 = token["toReturn"];
            if (token1 == null)
                return userCategorys;
            JArray tokenList = token1 as JArray;
            if (tokenList.Count == 0)
                return userCategorys;

            JavaScriptSerializer jss = JavaScriptSerializer.CreateInstance();
            Dictionary<string, List<string>> ucs = jss.Deserialize<Dictionary<string, List<string>>>(tokenList[0].ToString());
            foreach (string key in ucs.Keys)
            {
                OfferUserCategory ouc = new OfferUserCategory();
                //key=offerID1262147902
                ouc.OfferId = key.Substring(7);
                ouc.UserCategorys = ucs[key];
                userCategorys.Add(ouc);
            }
            
            
            return userCategorys;
        }

        #endregion
    }
}
