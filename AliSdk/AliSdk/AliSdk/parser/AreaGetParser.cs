using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliSdk.Top.Api.Domain;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;

namespace AliSdk.Top.Api.parser
{
    class AreaGetParser : ITopParser<List<Area>>
    {
        #region ITopParser<Area> 成员

        public List<Area> Parse(string body)
        {
            JObject obj = JObject.Parse(body);
            if (obj["message"] != null)
            {
                throw new Exception(obj["message"].ToString());
            }
            List<Area> areas = new List<Area>();
            JToken token = obj["result"];
            if (token == null)
                return areas;
            JToken token1 = token["toReturn"];
            if (token1 == null)
                return areas;
            JArray token2 = token1 as JArray;
            if (token2.Count == 0)
                return areas;
            JToken token3 = token2[0];
            if (token3 == null)
                return areas;

            JavaScriptSerializer jss = new JavaScriptSerializer();
            Dictionary<string,string> result = jss.Deserialize<Dictionary<string, string>>(token3.ToString());
            foreach(string key in result.Keys)
            {
                Area area = new Area();
                area.Name = key;
                area.Code = result[key];
                areas.Add(area);
            }
            return areas;
        }

        #endregion
    }
}
