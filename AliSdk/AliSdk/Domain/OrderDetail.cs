using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.Domain
{
    [Serializable]
    public class OrderDetail
    {
        /// <summary>
        /// 订单明细ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id { get; set; }

        /// <summary>
        /// 订单明细(产品)名称
        /// </summary>
        [JsonProperty("productName")]
        public string ProductName { get; set; }

        /// <summary>
        /// 订单明细来源ID，如offer的id
        /// </summary>
        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 货物单位
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 产品图片文件名,用";"隔开
        /// </summary>
        [JsonProperty("productPic")]
        public string ProductPic { get; set; }

        /// <summary>
        /// 产品图片/快照图片
        /// </summary>
        [JsonProperty("snapshotImages")]
        public List<SnapshotImageModel> SnapshotImages { get; set; }

        /// <summary>
        /// 该订单明细订购的来源，比如大额批发、普通大市场或者拿样，对应Detail的来源不同
        /// </summary>
        [JsonProperty("orderSourceType")]
        public string OrderSourceType { get; set; }

        /// <summary>
        /// 订单明细业务标识
        /// </summary>
        [JsonProperty("bizSign")]
        public OrderEntryBizSignModel BizSign { get; set; }

        /// <summary>
        /// 订单明细单价，单位：分
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 货币种类
        /// </summary>
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 产品打折单价
        /// </summary>
        [JsonProperty("discountPrice")]
        public string DiscountPrice { get; set; }

        /// <summary>
        /// 产品金额
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 折扣价
        /// </summary>
        [JsonProperty("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 抵价券额度
        /// </summary>
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// 订单明细涨价或折扣
        /// </summary>
        [JsonProperty("entryDiscount")]
        public string EntryDiscount { get; set; }

        /// <summary>
        /// 明细的实际使用低价卷金额
        /// </summary>
        [JsonProperty("entryCouponAmount")]
        public string EntryCouponAmount { get; set; }

        /// <summary>
        /// 明细单价
        /// </summary>
        [JsonProperty("unitPrice")]
        public string UnitPrice { get; set; }

        /// <summary>
        /// 优惠价格 - 如满100立减
        /// </summary>
        [JsonProperty("promotionsFee")]
        public string PromotionsFee { get; set; }

        /// <summary>
        /// 付款时分摊后的每笔子订单金额
        /// </summary>
        [JsonProperty("actualPayFee")]
        public string ActualPayFee { get; set; }

        /// <summary>
        /// 快照ID
        /// </summary>
        [JsonProperty("snapshotId")]
        public string SnapshotId { get; set; }

        /// <summary>
        /// 子订单状态，取值范围同主订单状态
        /// </summary>
        [JsonProperty("entryStatusStr")]
        public string EntryStatusStr { get; set; }

        /// <summary>
        /// 子订单退款状态，waitselleragree等待卖家同意，refundsuccess退款成功，refundclose退款关闭，waitbuyermodify待买家修改，waitbuyersend等待买家退货，waitsellerreceive等待卖家确认收货
        /// </summary>
        [JsonProperty("entryRefundStatus")]
        public string EntryRefundStatus { get; set; }

        /// <summary>
        /// 明细记录售后退款状态
        /// </summary>
        [JsonProperty("entryRefundStatusForAs")]
        public string EntryRefundStatusForAs { get; set; }

        /// <summary>
        /// 支付状态，与淘宝一致
        /// </summary>
        [JsonProperty("entryPayStatus")]
        public string EntryPayStatus { get; set; }

        /// <summary>
        /// 售中退款单ID
        /// </summary>
        [JsonProperty("refundId")]
        public string RefundId { get; set; }

        /// <summary>
        /// 售后退款单ID
        /// </summary>
        [JsonProperty("refundIdForAs")]
        public string RefundIdForAs { get; set; }

        /// <summary>
        /// offer的类目id；非offer订单为空
        /// </summary>
        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商品规格属性ID
        /// </summary>
        [JsonProperty("specId")]
        public string SpecId { get; set; }

        /// <summary>
        /// 商品规格属性数据模型
        /// </summary>
        [JsonProperty("specInfoModel")]
        public SpecInfoModel SpecInfoModel { get; set; }

        /// <summary>
        /// 该订单明细是否有保障卡支持
        /// </summary>
        [JsonProperty("guaranteeSupport")]
        public string GuaranteeSupport { get; set; }

        /// <summary>
        /// 该订单明细是否有行业化保障服务
        /// </summary>
        [JsonProperty("industrySecurityCodes")]
        public string IndustrySecurityCodes { get; set; }

        /// <summary>
        /// 该订单明细是否有买家保障服务
        /// </summary>
        [JsonProperty("buyerSecuritySupport")]
        public string BuyerSecuritySupport { get; set; }

        /// <summary>
        /// 买家评价状态(4:未评论,5:已评论,6;不需要评论)
        /// </summary>
        [JsonProperty("buyerRateStatus")]
        public string BuyerRateStatus { get; set; }

        /// <summary>
        /// 卖家评价状态(4:未评论,5:已评论,6;不需要评论)
        /// </summary>
        [JsonProperty("sellerRateStatus")]
        public string SellerRateStatus { get; set; }

        /// <summary>
        /// 优惠信息
        /// </summary>
        [JsonProperty("promotionSnaps")]
        public string PromotionSnaps { get; set; }

        /// <summary>
        /// 明细的关闭原因
        /// </summary>
        [JsonProperty("closeReason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 订单来源(已废弃)
        /// </summary>
        [JsonProperty("orderFrom")]
        public string OrderFrom { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("gmtCreate")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("gmtModified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 明细完成时间
        /// </summary>
        [JsonProperty("gmtCompleted")]
        public string GmtCompleted { get; set; }

        /// <summary>
        /// 自主订单的详情信息
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 物流状态，取值范围同主订单物流状态
        /// </summary>
        [JsonProperty("logisticsStatus")]
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// 加工定制offer订单自定义属性
        /// </summary>
        [JsonProperty("customAttributes")]
        public List<CustomOrderAttributeModel> CustomAttributes { get; set; }

        /// <summary>
        /// COD物流状态，与淘宝一致
        /// </summary>
        [JsonProperty("codStatus")]
        public string CodStatus { get; set; }

        /// <summary>
        /// 和交易交互的外部明细标识，目前用在采购速配中
        /// </summary>
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 售后投诉状态，'-'初始值，'1'首次投诉中，'0'投诉自行撤销，'2'投诉后台无效，'3'再次投诉中，'8'投诉资格关闭，'9'投诉处理完成
        /// </summary>
        [JsonProperty("complaintStatus")]
        public ComplaintStatusModel ComplaintStatus { get; set; }

        /// <summary>
        /// 明细扩展属性,用于保存交易不关心，但需要打在订单上的属性。目前只有“是否已导入行业产品库"
        /// </summary>
        //[JsonProperty("attributes")]
        //public string Attributes { get; set; }
    }

    [Serializable]
    public class SnapshotImageModel
    {
        /// <summary>
        /// 大图图片：全路径
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// 小图图片：全路径，目前动态生成小图规格：64x64
        /// </summary>
        public string SummImageUrl { get; set; }

        /// <summary>
        /// 中图图片：全路径，目前动态生成中图规格：150x150
        /// </summary>
        public string MidImageUrl { get; set; }
    }

    [Serializable]
    public class OrderEntryBizSignModel
    {
        /// <summary>
        /// 按位的方式表示订单所属业务市场。第一位，表示是否混批；第二位，表示是否促销；第三位，表示是否一分钱的样品；第四位，表示是否普通的样品；第五位，表示是否满包邮；第六位，表示是否为虚拟货品,没有该标记时认为是实物
        /// </summary>
        public string Sign { get; set; }
    }

    [Serializable]
    public class SpecInfoModel 
    {
        /// <summary>
        /// 规格属性条目列表
        /// </summary>
        public List<SpecItem> SpecItems { get; set; }
    }

    [Serializable]
    public class SpecItem
    {
        /// <summary>
        /// 规格属性名称
        /// </summary>
        public string SpecName { get; set; }

        /// <summary>
        /// 规格属性值
        /// </summary>
        public string SpecValue { get; set; }

        /// <summary>
        /// 规格属性单位
        /// </summary>
        public string Unit { get; set; }
    }

    [Serializable]
    public class CustomOrderAttributeModel
    {
        /// <summary>
        /// 显示名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 显示的值
        /// </summary>
        public string Value { get; set; }
    }

    [Serializable]
    public class ComplaintStatusModel
    {
        public bool RefundComplaintDoing { get; set; }
        public bool Valid { get; set; }
        public bool AfterSalesComplaintDoing { get; set; }
    }
}
