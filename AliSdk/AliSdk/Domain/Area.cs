using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.Domain
{
    [Serializable]
    public class Area:BaseObject
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("code")]
        public string Code;
    }
}
