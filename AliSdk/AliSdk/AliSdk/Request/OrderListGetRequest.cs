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
            return "trade.order.orderList.get";
        }

        #region ITopRequest 成员


        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("sellerMemberId", this.SellerMemberId);
            parameters.Add("tradeType", this.TradeType);
            parameters.Add("orderStatus", this.OrderStatus);
            parameters.Add("pageNO", this.PageNo);
            parameters.Add("pageSize", this.PageSize);
            parameters.Add("productName", this.ProductName);
            parameters.Add("orderId", this.OrderId);
            parameters.Add("createStartTime", this.CreateStartTime);
            parameters.Add("createEndTime", this.CreateEndTime);
            parameters.Add("payStartTime", this.PayStartTime);
            parameters.Add("payEndTime", this.PayEndTime);
            parameters.Add("modifyStartTime", this.ModifyStartTime);
            parameters.Add("modifyEndTime", this.ModifyEndTime);
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
