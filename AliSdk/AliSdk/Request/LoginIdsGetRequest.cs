using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{ 
   public class LoginIdsGetRequest : TopRequest, ITopRequest
   {
       public List<string> MemberIds;   

       public override string GetApiName()
       {
           return "convertLoginIdsByMemberIds";
       }

       #region ITopRequest 成员


       public IDictionary<string, string> GetParameters()
       {
           Dictionary<string, string> parameters = new Dictionary<string, string>();
           parameters.Add("memberIds", Newtonsoft.Json.JsonConvert.SerializeObject(this.MemberIds));        
           return parameters;
       }

       #endregion
    }
}
