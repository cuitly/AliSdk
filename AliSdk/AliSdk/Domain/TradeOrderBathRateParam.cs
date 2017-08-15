using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.Domain
{
    [Serializable]
    public class TradeOrderBathRateParam
    {
        [JsonProperty("content")]
        public string Content { get; set; }
        //[JsonProperty("starLevel")]
        //public string StarLevel { get; set; }
    }
}
