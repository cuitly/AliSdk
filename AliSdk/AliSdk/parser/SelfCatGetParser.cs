using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliSdk.Top.Api.Domain;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.parser
{
    public class SelfCatGetParser :  ITopParser<List<SellerCat>>
    {
        #region ITopParser<SellerCat> 成员

        public List<SellerCat> Parse(string body)
        {
            JObject obj = JObject.Parse(body);
            if (obj["message"] != null)
            {
                throw new Exception(obj["message"].ToString());
            }
            List<SellerCat> sellercatsList = new List<SellerCat>();
            JToken token = obj["result"];
            if (token == null)
                return sellercatsList;
            JToken token1 = token["toReturn"];
            if (token1 == null)
                return sellercatsList;
            JArray tokenList = token1 as JArray;
            if (tokenList.Count == 0)
                return sellercatsList;
            JToken token2 = tokenList[0];
            if (token2 == null)
                return sellercatsList;
            JToken token3 = token2["sellerCats"];

            if (token3 != null)
            {
                JArray sellercats = token3 as JArray;
                for (int i = 0; i < sellercats.Count; i++)
                {
                    object sellercat = new JsonSerializer().Deserialize(sellercats[i].CreateReader(), typeof(SellerCat));
                    sellercatsList.Add((SellerCat)sellercat);
                }
            }
            return sellercatsList;
        }

        #endregion
    }
}
