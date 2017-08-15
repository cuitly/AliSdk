using System;
using System.Collections.Generic;
using System.Text;
using AliSdk.Top.Api.Domain;
using Newtonsoft.Json.Linq;
using Carpa.Web.Ajax;

namespace AliSdk.Top.Api.parser
{
    //{"loginIdMap":{"b2b-1757540541":"tryandyw"}}
    public class LoginIdsGetParser : ITopParser<List<MemberLoginId>>
    {
        public List<MemberLoginId> Parse(string body)
        {
            JObject obj = JObject.Parse(body);
            if (obj["message"] != null)
            {
                throw new Exception(obj["message"].ToString());
            }
            List<MemberLoginId> areas = new List<MemberLoginId>();
            JToken token = obj["loginIdMap"];
            if (token == null)
                return areas;

            JavaScriptSerializer jss = JavaScriptSerializer.CreateInstance();
            Dictionary<string, string> result = jss.Deserialize<Dictionary<string, string>>(token.ToString());
            foreach (string key in result.Keys)
            {
                MemberLoginId area = new MemberLoginId();
                area.MemberId = key;
                area.LoginId = result[key];
                areas.Add(area);
            }
            return areas;
        }
    }
}
