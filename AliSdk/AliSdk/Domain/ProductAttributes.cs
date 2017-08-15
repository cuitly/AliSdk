using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.Domain
{
    [Serializable]
    public class ProductAttributes : BaseObject
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("specAttr")]
        public bool SpecAttr { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }
    }
}
