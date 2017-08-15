using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.Domain
{
    [Serializable]
    public class LogisticsOrder:BaseObject
    {
        /// <summary>
        /// 物流编号
        /// </summary>
         
        [JsonProperty("logisticsId")]
        public string LogisticsId;

        /// <summary>
        /// 物流公司运单号
        /// </summary>
        [JsonProperty("logisticsBillNo")]
        public string logisticsBillNo;

        /// <summary>
        /// 订单明细
        /// </summary>
        [JsonProperty("orderEntryIds")]
        public string OrderEntryIds;

        /// <summary>
        /// 物流状态
        /// </summary>
        [JsonProperty("status")]
        public string Status;

        /// <summary>
        /// 物流公司ID
        /// </summary>
        [JsonProperty("logisticsCompanyId")]
        public string LogisticsCompanyId;

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [JsonProperty("logisticsCompanyName")]
        public string LogisticsCompanyName;

        /// <summary>
        /// 用户发货时备注
        /// </summary>
        [JsonProperty("remarks")]
        public string Remarks;

        /// <summary>
        /// 产品类型和增值服务选择（自行发货、无需物流、在线快递下单该字段为空）
        /// </summary>
        [JsonProperty("ServiceFeature")]
        public string ServiceFeature;

        /// <summary>
        /// 发货人信息
        /// </summary>
        [JsonProperty("Sender")]
        public string Sender;

        /// <summary>
        /// 收货人信息
        /// </summary>
        [JsonProperty("Receiver")]
        public string Receiver;

        /// <summary>
        /// 货物信息列表
        /// </summary>
        [JsonProperty("SendGoods")]
        public string SendGoods;

        /// <summary>
        /// 系统发货时间
        /// </summary>
        [JsonProperty("GmtSystemSend")]
        public string gmtSystemSend;
    }
}
