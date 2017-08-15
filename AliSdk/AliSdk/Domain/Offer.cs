using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.Domain
{
    [Serializable]
    public class Offer:BaseObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonProperty("offerId")]
        public string OfferId;

        /// <summary>
        /// 是否为私密offer的标志位
        /// </summary>
        [JsonProperty("isPrivate")]
        public bool IsPrivate;

        /// <summary>
        /// 私密属性列举
        /// </summary>
        [JsonProperty("privateProperties")]
        public string PrivateProperties;

        /// <summary>
        /// 商品详情地址
        /// </summary>
        [JsonProperty("detailsUrl")]
        public string DetailsUrl;

        /// <summary>
        /// 商品类型。Sale：供应信息，Buy：求购信息
        /// </summary>
        [JsonProperty("type")]
        public string Type;

        /// <summary>
        /// 贸易类型。1：产品，2：加工，3：代理，4：合作，5：商务服务
        /// </summary>
        [JsonProperty("tradeType")]
        public int TradeType;

        /// <summary>
        /// 所属叶子类目ID
        /// </summary>
        [JsonProperty("postCategryId")]
        public string PostCategryId;

        /// <summary>
        /// 状态。auditing：审核中；online：已上网；FailAudited：审核未通过；outdated：已过期；member delete(d)：用户删除；delete：审核删除
        /// </summary>
        [JsonProperty("offerStatus")]
        public string OfferStatus;

        /// <summary>
        /// 卖家会员ID
        /// </summary>
        [JsonProperty("memberId")]
        public string MemberId;

        /// <summary>
        /// 商品标题
        /// </summary>
        [JsonProperty("subject")]
        public string Subject;

        /// <summary>
        /// 详情说明
        /// </summary>
        [JsonProperty("details")]
        public string Details;

        /// <summary>
        /// 商品信息质量星级( 取值为1到5)。1：一星；2：二星；3：三星；4：四星；5：五星
        /// </summary>
        [JsonProperty("qualityLevel")]
        public string QualityLevel;

        /// <summary>
        /// 商品图片列表
        /// </summary>
        [JsonProperty("imageList")]
        public List<OfferImage> ImageList;

        /// <summary>
        /// 商品属性信息
        /// </summary>
        [JsonProperty("productFeatureList")]
        public List<ProductFeature> ProductFeatureList;

        /// <summary>
        /// 是否支持网上交易
        /// </summary>
        [JsonProperty("isOfferSupportOnlineTrade")]
        public bool IsOfferSupportOnlineTrade;

        /// <summary>
        /// 是否支持混批
        /// </summary>
        [JsonProperty("isSupportMix")]
        public string IsSupportMix;

        /// <summary>
        /// 支持的交易方式
        /// </summary>
        [JsonProperty("tradingType")]
        public bool TradingType;

        /// <summary>
        /// 计量单位
        /// </summary>
        [JsonProperty("unit")]
        public string Unit;

        /// <summary>
        /// 交易币种
        /// </summary>
        [JsonProperty("priceUnit")]
        public string PriceUnit;

        /// <summary>
        /// 供货量
        /// </summary>
        [JsonProperty("amount")]
        public int Amount;

        /// <summary>
        /// 可售数量
        /// </summary>
        [JsonProperty("amountOnSale")]
        public int AmountOnSale;

        /// <summary>
        /// 已销售量
        /// </summary>
        [JsonProperty("saledCount")]
        public int SaledCount;

        /// <summary>
        /// 建议零售价
        /// </summary>
        [JsonProperty("retailPrice")]
        public Price RetailPrice;

        /// <summary>
        /// 单价
        /// </summary>
        [JsonProperty("unitPrice")]
        public Price UnitPrice;

        /// <summary>
        /// 价格区间
        /// </summary>
        [JsonProperty("priceRanges")]
        public List<PriceRange> PriceRanges;

        /// <summary>
        /// 有效期(单位：天)
        /// </summary>
        [JsonProperty("termOfferProcess")]
        public int TermOfferProcess;

        /// <summary>
        /// 物流模板id
        /// </summary>
        [JsonProperty("freightTemplateId")]
        public int FreightTemplateId;

        /// <summary>
        /// 发货地址id
        /// </summary>
        [JsonProperty("sendGoodsId")]
        public int SendGoodsId;

        /// <summary>
        /// 单位重量
        /// </summary>
        [JsonProperty("productUnitWeight")]
        public string ProductUnitWeight;

        /// <summary>
        /// 物流方式
        /// </summary>
        [JsonProperty("freightType")]
        public string FreightType;

        /// <summary>
        /// 是否为SKU商品
        /// </summary>
        [JsonProperty("isSkuOffer")]
        public bool IsSkuOffer;

        /// <summary>
        /// 是否支持按照规格报价
        /// </summary>
        [JsonProperty("isSkuTradeSupported")]
        public bool IsSkuTradeSupported;

        /// <summary>
        /// SKU规格属性信息
        /// </summary>
        [JsonProperty("skuArraytemp")]
        public List<Sku> SkuArray;

        /// <summary>
        /// 创建日期
        /// </summary>
        [JsonProperty("gmtCreate")]
        public string GmtCreate;

        /// <summary>
        /// 最近修改时间
        /// </summary>
        [JsonProperty("gmtModified")]
        public string GmtModified;

        /// <summary>
        /// 审核通过时间
        /// </summary>
        [JsonProperty("gmtApproved")]
        public string GmtApproved;

        /// <summary>
        /// 过期日期
        /// </summary>
        [JsonProperty("gmtExpire")]
        public string GmtExpire;

        /// <summary>
        /// 最近重发时间
        /// </summary>
        [JsonProperty("gmtLastRepost")]
        public string GmtLastRepost;
    }

    [Serializable]
    public class Price
    {
        [JsonProperty("amount")]
        public string Amount;

        [JsonProperty("cent")]
        public string Cent;

        [JsonProperty("centFactor")]
        public string CentFactor;

    }

    [Serializable]
    public class Sku
    {
        /// <summary>
        /// 单价
        /// </summary>
        [JsonProperty("price")]
        public string Price;

        /// <summary>
        /// 货号
        /// </summary>
        [JsonProperty("cargoNumber")]
        public string CargoNumber;

        /// <summary>
        /// 可销售数量
        /// </summary>
        [JsonProperty("canBookCount")]
        public int CanBookCount;

        /// <summary>
        /// 建议零售价
        /// </summary>
        [JsonProperty("retailPrice")]
        public string RetailPrice;

        /// <summary>
        /// 销售数量
        /// </summary>
        [JsonProperty("saleCount")]
        public int SaleCount;

        /// <summary>
        /// 属性值ID
        /// </summary>
        [JsonProperty("specId")]
        public string SpecId;

        /// <summary>
        /// 属性ID
        /// </summary>
        [JsonProperty("fid")]
        public string Fid;

        /// <summary>
        /// 属性值
        /// </summary>
        [JsonProperty("value")]
        public string Value;
    }

    [Serializable]
    public class ProductFeature
    {
        [JsonProperty("fid")]
        public string PropId;
        /// <summary>
        /// 属性名称
        /// </summary>
        [JsonProperty("name")]
        public string PropName;

        /// <summary>
        /// 属性值
        /// </summary>
        [JsonProperty("value")]
        public string PropValuesStr;

        [JsonProperty("values")]
        public List<string> PropValues;
    }

    [Serializable]
    public class PriceRange
    {
        /// <summary>
        /// 起始数量。商品批发价格区间的最低起批量
        /// </summary>
        [JsonProperty("minQuantity")]
        public int MinQuantity;

        /// <summary>
        /// 终止数量。商品批发价格区间的最高起批量
        /// </summary>
        [JsonProperty("maxQuantity")]
        public int MaxQuantity;

        /// <summary>
        /// 价格。商品批发价格
        /// </summary>
        [JsonProperty("price")]
        public string Price;

        [JsonProperty("range")]
        public string Range;

        [JsonProperty("convertPrice")]
        public string ConvertPrice;
    }

    [Serializable]
    public class OfferImage
    {
        [JsonProperty("offerId")]
        public string OfferId;

        [JsonProperty("offerUrl")]
        public string OfferUrl;

        [JsonProperty("size310x310URL")]
        public string imgurl;
    }
}
