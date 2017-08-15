using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Globalization;

namespace AliSdk.Top.Api.Domain
{
    [Serializable]
    public class OrderInvoiceModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        [JsonProperty("invoiceCompanyName")]
        public string InvoiceCompanyName { get; set; }

        [JsonProperty("taxpayerIdentify")]
        public string TaxpayerIdentify { get; set; }

        [JsonProperty("bankAndAccount")]
        public string BankAndAccount { get; set; }
    }

    [Serializable]
    public class Order : BaseObject
    {
        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("gmtModified")]
        public string gmtModified;

        public string GmtModified
        {
            get
            {
                return ConvertToDateTime(gmtModified);
            }
            set
            {
                gmtModified = value;
            }
        }

        /// <summary>
        /// 卖家支付宝ID
        /// </summary>
        [JsonProperty("sellerAlipayId")]
        public string SellerAlipayId { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [JsonProperty("tradeTypeStr")]
        public string tradeTypeStr { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonProperty("gmtCreate")]
        private string gmtCreate;

        public string GmtCreate
        {
            get
            {
                return ConvertToDateTime(gmtCreate);
            }
            set
            {
                gmtCreate = value;
            }
        }

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
        /// 买家id
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
        /// 买家电话
        /// </summary>
        [JsonProperty("buyerPhone")]
        public string BuyerPhone { get; set; }

        /// <summary>
        /// 收货人电话
        /// </summary>
        [JsonProperty("toPhone")]
        public string ToPhone { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [JsonProperty("sellerMemberId")]
        public string SellerMemberId { get; set; }

        /// <summary>
        /// 买家付款时间
        /// </summary>
        [JsonProperty("gmtPayment")]
        public string gmtPayment;

        public string GmtPayment
        {
            get
            {
                return ConvertToDateTime(gmtPayment);
            }
            set
            {
                gmtPayment = value;
            }
        }

        /// <summary>
        /// 公司名称（这个字段有问题！！不是买家旺旺号）
        /// </summary>
        [JsonProperty("sellerEmail")]
        public string BuyerAccount { get; set; }

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
        /// 退款金额
        /// </summary>
        [JsonProperty("refundPayment")]
        public string RefundPayment { get; set; }

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
        /// 卖家备注
        /// </summary>
        [JsonProperty("sellerOrderMemo")]
        public OrderMemoModel SellerOrderMemo { get; set; }

        /// <summary>
        /// 买家留言
        /// </summary>
        [JsonProperty("buyerFeedback")]
        public string BuyerFeedback { get; set; }

        ///<summary>
        /// 物流信息
        /// </summary>
        [JsonProperty("logisticsOrderList")]
        public List<LogisticsOrderModel> LogisticsOrderList { get; set; }


        /// <summary>
        /// 发票信息数组-购货公司名称
        /// </summary>
        [JsonProperty("orderInvoiceModel")]
        public OrderInvoiceModel InvoiceInfo { get; set; }


        /// <summary>
        /// 订单明细
        /// </summary>
        [JsonProperty("orderEntries")]
        public List<OrderDetail> Details { get; set; }

        /// <summary>
        /// 发票信息数组-电话
        /// </summary>
        [JsonProperty("needLogistics")]
        public string NeedLogistics { get; set; }

        /// <summary>
        /// 卖家评价状态
        /// </summary>
        [JsonProperty("sellerRateStatus")]
        public string SellerRateStatus { get; set; }

        /// <summary>
        /// 确认时间
        /// </summary>
        [JsonProperty("gmtConfirmed")]
        public string GmtConfirmed { get; set; }

        /// <summary>
        /// 关闭原因
        /// </summary>
        [JsonProperty("closeReason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 买家公司名称
        /// </summary>
        [JsonProperty("buyerCompanyName")]
        public string BuyerCompanyName { get; set; }

        /// <summary>
        /// 买家email
        /// </summary>
        [JsonProperty("buyerEmail")]
        public string BuyerEmail { get; set; }

        /// <summary>
        /// 备注列表
        /// </summary>
        [JsonProperty("orderMemoList")]
        public List<OrderMemoModel> OrderMemoList { get; set; }

        /// <summary>
        /// 是否一次性付款
        /// </summary>
        [JsonProperty("stepPayAll")]
        public bool StepPayAll { get; set; }

        /// <summary>
        /// 支付状态。1:等待买家付款，2:已付款，4:交易关闭，6:交易成功，8:交易被系统关闭
        /// </summary>
        [JsonProperty("payStatus")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 物流状态。8:还未创建物流订单；1:未发货；2:已发货；3:已收货，交易成功；4:已经退货，交易失败；5:部分发货，交易成功
        /// </summary>
        [JsonProperty("logisticsStatus")]
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// 分阶段协议地址
        /// </summary>
        [JsonProperty("stepAgreementPath")]
        public string StepAgreementPath { get; set; }

        /// <summary>
        /// 是否COD订单并且清算成功
        /// </summary>
        [JsonProperty("codAudit")]
        public bool CodAudit { get; set; }

        /// <summary>
        /// cod服务费  
        /// </summary>
        [JsonProperty("codFee")]
        public string CodFee { get; set; }

        /// <summary>
        /// 买家承担的服务费
        /// </summary>
        [JsonProperty("codBuyerFee")]
        public string CodBuyerFee { get; set; }

        /// <summary>
        /// 卖家承担的服务费
        /// </summary>
        [JsonProperty("codSellerFee")]
        public string CodSellerFee { get; set; }

        /// <summary>
        /// cod交易的实付款（买家实际支付给物流的费用）
        /// </summary>
        [JsonProperty("codActualFee")]
        public string CodActualFee { get; set; }

        /// <summary>
        /// 买家签收时间(COD)
        /// </summary>
        [JsonProperty("gmtSign")]
        public string GmtSign { get; set; }

        /// <summary>
        /// cod三家分润
        /// </summary>
        [JsonProperty("codFeeDividend")]
        public string CodFeeDividend { get; set; }

        /// <summary>
        /// cod服务费初始值
        /// </summary>
        [JsonProperty("codInitFee")]
        public string CodInitFee { get; set; }

        /// <summary>
        /// 买家承担的服务费初始值
        /// </summary>
        [JsonProperty("codBuyerInitFee")]
        public string CodBuyerInitFee { get; set; }

        /// <summary>
        /// 买家备注
        /// </summary>
        [JsonProperty("buyerOrderMemo")]
        public OrderMemoModel BuyerOrderMemo { get; set; }

        /// <summary>
        /// 卖家数字id
        /// </summary>
        [JsonProperty("sellerUserId")]
        public string SellerUserId { get; set; }

        /// <summary>
        /// 买家数字id
        /// </summary>
        [JsonProperty("buyerUserId")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 卖家登录id
        /// </summary>
        [JsonProperty("sellerLoginId")]
        public string SellerLoginId { get; set; }

        /// <summary>
        /// 卖家登录id
        /// </summary>
        [JsonProperty("buyerLoginId")]
        public string BuyerLoginId { get; set; }

        private string ConvertToDateTime(string dateString)
        {
            if (string.IsNullOrEmpty(dateString))
                return null;
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("en-US");
            DateTime dt = DateTime.ParseExact(dateString, "yyyyMMddHHmmssfffzz00", System.Globalization.CultureInfo.CurrentCulture);
            return dt.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }

    //[Serializable]
    //public class OrderDetail
    //{
    //    /// <summary>
    //    /// 商品信息数组-商品所有图片的URL地址
    //    /// </summary>
    //   // [JsonProperty("productPic")]
    //    //public List<string> ProductPic { get; set; }

    //    /// <summary>
    //    /// 订单明细id
    //    /// </summary>
    //    [JsonProperty("id")]
    //    public string OrderEntryId;

    //    /// <summary>
    //    /// 商品信息数组-订单中该商品的购买数量
    //    /// </summary>
    //    [JsonProperty("quantity")]
    //    public string Quantity { get; set; }

    //    /// <summary>
    //    /// 商品信息数组-商品单价，单位：分
    //    /// </summary>
    //    [JsonProperty("price")]
    //    public double price { get; set; }

    //    /// <summary>
    //    /// 商品信息数组-商品名称
    //    /// </summary>
    //    [JsonProperty("productName")]
    //    public string ProductName { get; set; }

    //    /// <summary>
    //    /// 子订单spec主键信息
    //    /// </summary>
    //    [JsonProperty("specId")]
    //    public string SpecId { get; set; }

    //    /// <summary>
    //    /// 条目状态
    //    /// </summary>
    //    [JsonProperty("entryStatus")]
    //    public string EntryStatus { get; set; }

    //    /// <summary>
    //    /// 商品信息数组-商品ID
    //    /// </summary>
    //    [JsonProperty("sourceId")]
    //    public string SourceId { get; set; }

    //    /// <summary>
    //    /// 条目货到付款状态
    //    /// </summary>
    //    [JsonProperty("codStatus")]
    //    public string EntryCodStatus { get; set; }

    //    /// <summary>
    //    /// 条目优惠金额
    //    /// </summary>
    //    [JsonProperty("entryDiscount")]
    //    public string EntryDiscount { get; set; }

    //    /// <summary>
    //    /// 属性
    //    /// </summary>
    //    [JsonProperty("specInfoModel")]
    //    public List<SpecInfo> specInfo { get; set; }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    [JsonProperty("mainImageUrl")]
    //    public string offerSnapshotImageUrl { get; set; }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    [JsonProperty("logisticsOrderId")]
    //    public string LogisticsOrderId { get; set; }

    //}

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
        public string RemarkIcon;

        [JsonProperty("memberId")]
        public string MemberId;
    }

    [Serializable]
    public class LogisticsOrderModel
    {
        /// <summary>
        /// SELF_SEND_GOODS("0")自行发货，在线发货ONLINE_SEND_GOODS("1"，不需要物流的发货 NO_LOGISTICS_SEND_GOODS("2")
        /// </summary>
        [JsonProperty("type")]
        public string Type;

        /// <summary>
        /// 主键id
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status")]
        public string Status;

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("gmtModified")]
        public string GmtModified;

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("gmtCreate")]
        public string GmtCreate;

        /// <summary>
        /// 订单id
        /// </summary>
        [JsonProperty("orderId")]
        public string OrderId;

        /// <summary>
        /// 运费(单位为分)
        /// </summary>
        [JsonProperty("carriage")]
        public string Carriage;

        /// <summary>
        /// 收货人邮编
        /// </summary>
        [JsonProperty("toPost")]
        public string ToPost;

        /// <summary>
        /// 收货人地址
        /// </summary>
        [JsonProperty("toArea")]
        public string ToArea;

        /// <summary>
        /// 物流公司编号
        /// </summary>
        [JsonProperty("logisticsCompanyId")]
        public string LogisticsCompanyId;

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonProperty("logisticsOrderNo")]
        public string LogisticsOrderNo;

        /// <summary>
        /// 发货省编码
        /// </summary>
        [JsonProperty("fromProvince")]
        public string FromProvince;

        /// <summary>
        /// 发货市编码
        /// </summary>
        [JsonProperty("fromCity")]
        public string FromCity;

        /// <summary>
        /// 发货区编码
        /// </summary>
        [JsonProperty("fromArea")]
        public string FromArea;

        /// <summary>
        /// 发货街道地址
        /// </summary>
        [JsonProperty("fromAddress")]
        public string FromAddress;

        /// <summary>
        /// 发货联系电话
        /// </summary>
        [JsonProperty("fromPhone")]
        public string FromPhone;

        /// <summary>
        /// 发货联系手机
        /// </summary>
        [JsonProperty("fromMobile")]
        public string FromMobile;

        /// <summary>
        /// 发货地址邮编
        /// </summary>
        [JsonProperty("fromPost")]
        public string FromPost;

        /// <summary>
        /// 收货省编码
        /// </summary>
        [JsonProperty("toProvince")]
        public string ToProvince;

        /// <summary>
        /// 收货联系人
        /// </summary>
        [JsonProperty("toContact")]
        public string ToContact;

        /// <summary>
        /// 物流公司运单号
        /// </summary>
        [JsonProperty("logisticsBillNo")]
        public string LogisticsBillNo;

        /// <summary>
        /// 发货时间
        /// </summary>
        [JsonProperty("gmtSend")]
        public string GmtSend;

        /// <summary>
        /// 物流公司
        /// </summary>
        [JsonProperty("logisticsCompany")]
        public LogisticsCompanyModel LogisticsCompany;
    }



    [Serializable]
    public class OrderMemoModel
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("gmtModified")]
        public string GmtModified;

        [JsonProperty("gmtCreate")]
        public string GmtCreate;

        [JsonProperty("orderId")]
        public string OrderId;

        [JsonProperty("memberId")]
        public string MemberId;

        [JsonProperty("remark")]
        public string Remark;

        [JsonProperty("remarkIcon")]
        public string RemarkIcon;
    }

    public class LogisticsCompanyModel
    {
        public string Id { get; set; }
        public string companyName { get; set; }
        public string companyNo { get; set; }
    }
}
