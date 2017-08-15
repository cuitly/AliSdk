using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.Domain
{
    [Serializable]
    public class ReturnObject : BaseObject
    {
        public List<ReturnInfo> returnObject;
    }

    [Serializable]
    public class ReturnInfo
    {
        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonProperty("failure")]
        public string Failure;

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonProperty("isSuccess")]
        public string IsSuccess;

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonProperty("offerId")]
        public string OfferId;
    }
}
