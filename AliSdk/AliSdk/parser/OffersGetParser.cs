using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliSdk.Top.Api.Domain;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.parser
{
    public class OffersGetParser : ITopParser<OffersGetResponse>
    {
        #region ITopParser<Offer> 成员

        public OffersGetResponse Parse(string body)
        {
            JObject obj = JObject.Parse(body);
            if (obj["message"] != null)
            {
                throw new Exception(obj["message"].ToString());
            }
            int resultTotal = 0;
            List<Offer> offers = new List<Offer>();
            OffersGetResponse response = new OffersGetResponse();
            response.ResultTotal = resultTotal;
            response.Offers = offers;
            JToken token = obj["result"];
            if (token == null)
                return response;
            JToken token1 = token["toReturn"];
            if (token1 == null)
                return response;
            resultTotal = int.Parse(token["total"].ToString());
            response.ResultTotal = resultTotal;
            JArray tokenList = token1 as JArray;
            if (tokenList.Count == 0)
                return response;


            for (int i = 0; i < tokenList.Count; i++)
            {
                object offerTemp = new JsonSerializer().Deserialize(tokenList[i].CreateReader(), typeof(Offer));

                Offer offer = (Offer)offerTemp;
                JToken token2 = tokenList[i]["skuArray"];
                if (token2 != null)
                {
                    JArray token1List = token2 as JArray;
                    if (token1List.Count != 0)
                    {
                        List<Sku> realSkus = new List<Sku>();
                        for (int j = 0; j < token1List.Count; j++)
                        {
                            object skus = new JsonSerializer().Deserialize(token1List[j].CreateReader(), typeof(SkuTemp));
                            SkuTemp skuTemp = (SkuTemp)skus;
                            foreach (Sku sku in skuTemp.childs)
                            {
                                sku.Fid = skuTemp.fid + ";" + sku.Fid;
                                sku.Value = skuTemp.value + ";" + sku.Value;
                                realSkus.Add(sku);
                            }
                        }
                        offer.SkuArray = realSkus;
                    }
                }

                offers.Add(offer);
            }

            return response;
        }

        #endregion
    }

    public class OffersGetResponse
    {
        public int ResultTotal = 0;
        public List<Offer> Offers = new List<Offer>();
    }
}
