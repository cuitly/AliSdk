using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.Domain
{
    /// <summary>
    /// 会员自定义分类信息
    /// </summary>
    [Serializable]
    public class SellerCat:BaseObject
    {
        /// <summary>
        /// 自定义分类ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 显示顺序
        /// </summary>
        [JsonProperty("ordering")]
        public int Ordering { get; set; }

        /// <summary>
        /// 子类目
        /// </summary>
        [JsonProperty("children")]
        public List<SellerCat> Children { get; set; }

        /// <summary>
        /// 暂时没用
        /// </summary>
        [JsonProperty("gmtModified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 暂时没用
        /// </summary>
        [JsonProperty("gmtCreate")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 会员ID
        /// </summary>
        [JsonProperty("memberId")]
        public string Memberid { get; set; }
    }
}
