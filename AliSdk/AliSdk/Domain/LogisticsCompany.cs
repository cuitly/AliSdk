using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.Domain
{
    [Serializable]
    public class LogisticsCompany:BaseObject
    {
        /// <summary>
        /// 物流公司ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 是否支持打印
        /// </summary>
        [JsonProperty("isSupportPrint")]
        public string IsSupportPrint { get; set; }

        /// <summary>
        /// 公司编码
        /// </summary>
        [JsonProperty("companyNo")]
        public string CompanyNo { get; set; }

        /// <summary>
        /// 公司电话
        /// </summary>
        [JsonProperty("companyPhone")]
        public string CompanyPhone { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }
    }
}
