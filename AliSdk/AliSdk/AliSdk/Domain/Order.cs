using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.Domain
{
    [Serializable]
    public class Order:BaseObject
    {
        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("gmtModified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 卖家支付宝ID
        /// </summary>
        [JsonProperty("sellerAlipayId")]
        public string SellerAlipayId { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [JsonProperty("tradeType")]
        public int TradeType { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonProperty("gmtCreate")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("alipayTradeId")]
        public string AlipayTradeId { get; set; }

        /// <summary>
        /// 运费
        /// </summary>
        [JsonProperty("carriage")]
        public string Carriage { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 收货人邮编
        /// </summary>
        [JsonProperty("toPost")]
        public string ToPost { get; set; }

        /// <summary>
        /// 买家支付宝ID
        /// </summary>
        [JsonProperty("buyerAlipayId")]
        public string BuyerAlipayId { get; set; }

        /// <summary>
        /// 货品总价+运费=实付款
        /// </summary>
        [JsonProperty("sumPayment")]
        public string SumPayment { get; set; }

        /// <summary>
        /// 买家会员登录名
        /// </summary>
        [JsonProperty("buyerMemberId")]
        public string BuyerMemberId { get; set; }

        /// <summary>
        /// 收货人所在地区
        /// </summary>
        [JsonProperty("toArea")]
        public string ToArea { get; set; }

        /// <summary>
        /// 涨价或折扣，折扣为负数
        /// </summary>
        [JsonProperty("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 收货人手机
        /// </summary>
        [JsonProperty("toMobile")]
        public string ToMobile { get; set; }

        /// <summary>
        /// 卖家会员登录名
        /// </summary>
        [JsonProperty("sellerMemberId")]
        public string SellerMemberId { get; set; }

        /// <summary>
        /// 买家付款时间
        /// </summary>
        [JsonProperty("gmtPayment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [JsonProperty("toFullName")]
        public string ToFullName { get; set; }

        /// <summary>
        /// 买家评价状态
        /// </summary>
        [JsonProperty("buyerRateStatus")]
        public string BuyerRateStatus { get; set; }

        /// <summary>
        /// 卖家公司名
        /// </summary>
        [JsonProperty("sellerCompanyName")]
        public string SellerCompanyName { get; set; }

        /// <summary>
        /// 卖家电话
        /// </summary>
        [JsonProperty("sellerPhone")]
        public string SellerPhone { get; set; }

        /// <summary>
        /// 卖家发货时间
        /// </summary>
        [JsonProperty("gmtGoodsSend")]
        public string GmtGoodsSend { get; set; }

        /// <summary>
        /// 买家电话
        /// </summary>
        [JsonProperty("buyerPhone")]
        public string BuyerPhone { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [JsonProperty("refundPaymen")]
        public string RefundPaymen { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [JsonProperty("refundStatus")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 商品总金额
        /// </summary>
        [JsonProperty("sumProductPayment")]
        public string SumProductPayment { get; set; }

        /// <summary>
        /// 卖家备注信息
        /// </summary>
        [JsonProperty("memos")]
        public List<Memo> Memos { get; set; }

        /// <summary>
        /// 买家留言
        /// </summary>
        [JsonProperty("buyerFeedback")]
        public string BuyerFeedback { get; set; }

        ///<summary>
        /// 物流信息
        /// </summary>
        [JsonProperty("logistics")]
        public List<Logistics> Logistics { get; set; }

        /// <summary>
        /// 订单明细
        /// </summary>
        [JsonProperty("orderEntries")]
        public List<OrderDetail> Details { get; set; }
    }

    [Serializable]
    public class OrderDetail
    {
        /// <summary>
        /// 商品信息数组-商品所有图片的URL地址
        /// </summary>
       // [JsonProperty("productPic")]
        //public List<string> ProductPic { get; set; }

        /// <summary>
        /// 商品信息数组-订单中该商品的购买数量
        /// </summary>
        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 商品信息数组-商品单价，单位：分
        /// </summary>
        [JsonProperty("price")]
        public double price { get; set; }

        /// <summary>
        /// 商品信息数组-商品名称
        /// </summary>
        [JsonProperty("productName")]
        public string ProductName { get; set; }

        /// <summary>
        /// 子订单spec主键信息
        /// </summary>
        [JsonProperty("specId")]
        public string SpecId { get; set; }

        /// <summary>
        /// 条目状态
        /// </summary>
        [JsonProperty("entryStatus")]
        public string EntryStatus { get; set; }

        /// <summary>
        /// 商品信息数组-商品ID
        /// </summary>
        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        /// <summary>
        /// 条目货到付款状态
        /// </summary>
        [JsonProperty("entryCodStatus")]
        public string EntryCodStatus { get; set; }

        /// <summary>
        /// 条目优惠金额
        /// </summary>
        [JsonProperty("entryDiscount")]
        public string EntryDiscount { get; set; }

        /// <summary>
        /// 属性
        /// </summary>
        [JsonProperty("specInfo")]
        public List<SpecInfo> specInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("offerSnapshotImageUrl")]
        public string offerSnapshotImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("logisticsOrderId")]
        public string LogisticsOrderId { get; set; }
    }

    [Serializable]
    public class SpecInfo
    {
        [JsonProperty("specName")]
        public string SpecName;

        [JsonProperty("specValue")]
        public string SpecValue;
    }

    [Serializable]
    public class Memo
    {
        [JsonProperty("remark")]
        public string Remark;

        [JsonProperty("remarkIcon")]
        public int RemarkIcon;
    }

    [Serializable]
    public class Logistics
    {
        [JsonProperty("logisticsBillNo")]
        public string LogisticsBillNo;

        [JsonProperty("status")]
        public string Status;

        [JsonProperty("fromContact")]
        public string fromContact;

        [JsonProperty("fromProvince")]
        public string fromProvince;

        [JsonProperty("toPost")]
        public string toPost;

        [JsonProperty("logisticsOrderNo")]
        public string logisticsOrderNo;

        [JsonProperty("gmtSend")]
        public string gmtSend;

        [JsonProperty("toArea")]
        public string toArea;

        [JsonProperty("logisticsId")]
        public string logisticsId;

        [JsonProperty("logisticsCompanyName")]
        public string logisticsCompanyName;

        [JsonProperty("toProvince")]
        public string toProvince;

        [JsonProperty("fromPhone")]
        public string fromPhone;

        [JsonProperty("toMobile")]
        public string toMobile;

        [JsonProperty("fromAddress")]
        public string fromAddress;

        [JsonProperty("toCity")]
        public string toCity;

        [JsonProperty("toContact")]
        public string toContact;

        [JsonProperty("fromArea")]
        public string fromArea;

        [JsonProperty("fromCity")]
        public string fromCity;
    }
}
