using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.Domain
{
    [Serializable]
   public class MemberLoginId:BaseObject
   {
        [JsonProperty("memberId")]
        public string MemberId;

        [JsonProperty("loginId")]
        public string LoginId;
   }
}
