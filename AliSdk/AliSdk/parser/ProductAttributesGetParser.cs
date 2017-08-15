using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliSdk.Top.Api.Domain;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.parser
{
    public class ProductAttributesGetParser : ITopParser<List<ProductAttributes>>
    {
        #region ITopParser<List<ProductAttributes>> 成员

        List<ProductAttributes> ITopParser<List<ProductAttributes>>.Parse(string body)
        {
            List<ProductAttributes> productAttributeList = new List<ProductAttributes>();
            JObject obj = JObject.Parse(body);
            if (obj["message"] != null)
            {
                throw new Exception(obj["message"].ToString());
            }
            JToken token = obj["result"];
            if (token == null)
                return productAttributeList;
            JToken token1 = token["toReturn"];
            if (token1 == null)
                return productAttributeList;
            JArray tokenList = token1 as JArray;
            if (tokenList.Count == 0)
                return productAttributeList;
            for (int i = 0; i < tokenList.Count; i++)
            {
                object result = new JsonSerializer().Deserialize(tokenList[i].CreateReader(), typeof(ProductAttributes));
                if (!productAttributeList.Contains((ProductAttributes)result))
                {
                    productAttributeList.Add((ProductAttributes)result);
                }
            }
            return productAttributeList;
        }

        #endregion
    }
}
