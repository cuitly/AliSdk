using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{
    public class OfferModifyRequest : TopRequest, ITopRequest
    {
        public string Offer;
        public string OfferId;
        public int AmountOnSale;
        public List<SkuInfo> skus = new List<SkuInfo>();
        public string ProductFeatures;

        public override string GetApiName()
        {
            return "offer.modify.increment";
        }

        #region ITopRequest 成员

//"{"offerId":"1262147902","skuList":"[{\"specAttributes\":{\"3216\":\"白色\",\"450\":\"XS\"},\"amountOnSale\":80,\"cargoNumber\":\"0010108\"}]\"}";
        public IDictionary<string, string> GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(Offer))
                parameters.Add("offer", this.Offer);
            else
            {
                StringBuilder json = new StringBuilder("{");
                json.Append("\"offerId\":");
                json.Append("\""+this.OfferId + "\",");
                if (AmountOnSale >= 0)
                {
                    json.Append("\"amountOnSale\":");
                    json.Append("\"" + this.AmountOnSale.ToString() + "\",");
                }
                if (!string.IsNullOrEmpty(this.ProductFeatures))
                {
                    json.Append("\"productFeatures\":");
                    json.Append("\"" + this.AmountOnSale.ToString() + "\",");
                }
                if (skus.Count > 0)
                {
                    json.Append("\"skuList\":\"[");
                    foreach (SkuInfo sku in skus)
                    {
                        if (sku.SpecAttributes == null)
                            continue;
                        json.Append("{");
                        json.Append("\\\"specAttributes\\\":");
                        json.Append("{"+sku.SpecAttributes.Replace("\"","\\\"")+"},");
                        if (sku.AmountOnSale >= 0)
                        {
                            json.Append("\\\"amountOnSale\\\":"+sku.AmountOnSale.ToString() + ",");
                        }
                        if (sku.price > 0)
                        {
                            json.Append("\\\"price\\\":" + sku.price.ToString() + ",");
                        }
                        if (sku.retailPrice > 0)
                        {
                            json.Append("\\\"retailPrice\\\":" + sku.retailPrice.ToString() + ",");
                        }
                        if (!string.IsNullOrEmpty(sku.CargoNumber))
                        {
                            json.Append("\\\"cargoNumber\\\":\\\"" + sku.CargoNumber + "\\\",");
                        }
                        json.Replace(',', ' ', json.Length - 1, 1);
                        json.Append("},");
                    }
                    json.Replace(',', ' ', json.Length - 1, 1);
                    json.Append("]\"");
                }
                json.Replace(',', ' ', json.Length - 1, 1);
                json.Append("}");
                parameters.Add("offer", json.ToString());
            }
            return parameters;
        }

        #endregion
    }

    //public class OfferModify
    //{
    //    public string OfferId;
    //    public int AmountOnSale;
    //    public string CargoNumber;
    //    public List<SkuInfo> skus = new List<SkuInfo>();
    //}

    public class SkuInfo
    {
        public string SpecAttributes;
        public int AmountOnSale;
        public string CargoNumber;
        public double price;
        public double retailPrice;
    }
}
