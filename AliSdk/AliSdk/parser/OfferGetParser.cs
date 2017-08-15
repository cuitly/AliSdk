using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliSdk.Top.Api.Domain;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.parser
{
    public class OfferGetParser :ITopParser<Offer>
    {
        #region ITopParser<Offer> 成员

        public Offer Parse(string body)
        {
            JObject obj = JObject.Parse(body);
            if (obj["message"] != null)
            {
                throw new Exception(obj["message"].ToString());
            }
            Offer offer = new Offer();
            JToken token = obj["result"];
            if (token == null)
                return offer;
            JToken token1 = token["toReturn"];
            if (token1 == null)
                return offer;
            JArray tokenList = token1 as JArray;
            if (tokenList.Count == 0)
                return offer;
            JToken token2 = tokenList[0];
            if (token2 == null)
                return offer;

            object result = new JsonSerializer().Deserialize(token2.CreateReader(), typeof(Offer));
            offer = (Offer)result;
            JToken token3 = token2["skuArray"];
            if (token3 != null)
            {
                JArray token1List = token3 as JArray;
                if (token1List.Count != 0)
                {
                    List<Sku> realSkus = new List<Sku>();
                    for (int i = 0; i < token1List.Count; i++)
                    {
                        object skus = new JsonSerializer().Deserialize(token1List[i].CreateReader(), typeof(SkuTemp));
                        SkuTemp skuTemp = (SkuTemp)skus;
                        if (skuTemp.childs.Count != 0)
                        {
                            foreach (Sku sku in skuTemp.childs)
                            {
                                sku.Fid = skuTemp.fid + ";" + sku.Fid;
                                sku.Value = skuTemp.value + ";" + sku.Value;
                                realSkus.Add(sku);
                            }
                        }
                        else
                        {
                            Sku sku = new Sku();
                            sku.Fid = skuTemp.fid + ";";
                            sku.Value = skuTemp.value + ";";
                            sku.CanBookCount = skuTemp.CanBookCount;
                            sku.CargoNumber = skuTemp.CargoNumber;
                            sku.Price = skuTemp.Price;
                            sku.RetailPrice = skuTemp.RetailPrice;
                            sku.SaleCount = skuTemp.SaleCount;
                            sku.SpecId = skuTemp.SpecId;
                            realSkus.Add(sku);
                        }
                    }
                    offer.SkuArray = realSkus;
                }
            }
            return offer;
        }

        #endregion
    }

    [Serializable]
    public class SkuTemp
    {
        [JsonProperty("fid")]
        public string fid;
        [JsonProperty("value")]
        public string value;
        [JsonProperty("children")]
        public List<Sku> childs = new List<Sku>();
        [JsonProperty("price")]
        public string Price;
        [JsonProperty("cargoNumber")]
        public string CargoNumber;
        [JsonProperty("canBookCount")]
        public int CanBookCount;
        [JsonProperty("retailPrice")]
        public string RetailPrice;
        [JsonProperty("saleCount")]
        public int SaleCount;
        [JsonProperty("specId")]
        public string SpecId;
    }
}
