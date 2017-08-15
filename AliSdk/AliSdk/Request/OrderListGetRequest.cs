using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{
    public class OrderListGetRequest:TopRequest, ITopRequest
    {
        public string SellerMemberId ;
        public string TradeType;
        public string OrderStatus;
        public int PageNo = 0;
        public int PageSize = 20;
        public string ProductName;
        public string OrderId;
        public string CreateStartTime;
        public string CreateEndTime;
        public string PayStartTime;
        public string PayEndTime;
        public string ModifyStartTime;
        public string ModifyEndTime;

        public override string GetApiName()
        {
            return "trade.order.list.get";
        }
        public override string GetVersion()
        {
            return "2";
        }

        #region ITopRequest 成员


        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("sellerMemberId", this.SellerMemberId);
            parameters.Add("tradeType", this.TradeType);
            parameters.Add("orderStatusEnum", this.OrderStatus);
            parameters.Add("pageNO", this.PageNo);
            parameters.Add("pageSize", this.PageSize);
            parameters.Add("productName", this.ProductName);
            parameters.Add("orderId", this.OrderId);
            if (!string.IsNullOrEmpty(this.CreateStartTime))
            {
                string create_StartTime = DateTime.Parse(this.CreateStartTime).ToString("yyyyMMddHHmmssfff") + "+0800";//阿里新接口时间格式
                parameters.Add("createStartTime", create_StartTime);
            }
            if (!string.IsNullOrEmpty(this.CreateEndTime))
            {
                string create_EndTime = DateTime.Parse(this.CreateEndTime).ToString("yyyyMMddHHmmssfff") + "+0800";
                parameters.Add("createEndTime", create_EndTime);
            }
            if (!string.IsNullOrEmpty(this.PayStartTime))
            {
                string pay_StartTime = DateTime.Parse(this.PayStartTime).ToString("yyyyMMddHHmmssfff") + "+0800";
                parameters.Add("payStartTime", pay_StartTime);
            }
            if (!string.IsNullOrEmpty(this.PayEndTime))
            {
                string pay_EndTime = DateTime.Parse(this.PayEndTime).ToString("yyyyMMddHHmmssfff") + "+0800";
                parameters.Add("payEndTime", pay_EndTime);
            }
            if (!string.IsNullOrEmpty(this.ModifyStartTime))
            {
                string modify_StartTime = DateTime.Parse(this.ModifyStartTime).ToString("yyyyMMddHHmmssfff") + "+0800";
                //string modify_StartTime = this.ModifyStartTime;
                parameters.Add("modifyStartTime", modify_StartTime);
            }
            if (!string.IsNullOrEmpty(this.ModifyEndTime))
            {
                string modify_EndTime = DateTime.Parse(this.ModifyEndTime).ToString("yyyyMMddHHmmssfff") + "+0800";
                //string modify_EndTime = this.ModifyEndTime;
                parameters.Add("modifyEndTime", modify_EndTime);
            }
            return parameters;
        }

        #endregion
    }
    public enum TradeType
    {

        /// <summary>
        /// 担保交易
        /// </summary>
        GUARANTEE = 1,
        /// <summary>
        /// 预付款交易
        /// </summary>
        PREPAID = 2,
        /// <summary>
        /// ETC境外收单交易
        /// </summary>
        ETC = 3,
        /// <summary>
        /// 即时到帐交易
        /// </summary>
        IMMEDIATE = 4,
        /// <summary>
        /// 保障金安全交易
        /// </summary>
        SERCURITY = 5,
        /// <summary>
        /// 统一交易流程
        /// </summary>
        UNITY = 6,
        /// <summary>
        /// 分阶段交易
        /// </summary>
        STEP = 7,
        /// <summary>
        /// 货到付款交易
        /// </summary>
        COD = 8
    }
}
