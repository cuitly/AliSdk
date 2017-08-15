using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliSdk.Top.Api.Domain;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.parser
{
    class LogisticsListGetParser : ITopParser<List<LogisticsCompany>>
    {

        #region ITopParser<List<LogisticsCompany>> 成员

        public List<LogisticsCompany> Parse(string body)
        {
            JObject obj = JObject.Parse(body);
            if (obj["message"] != null)
            {
                throw new Exception(obj["message"].ToString());
            }
            List<LogisticsCompany> companys = new List<LogisticsCompany>();
            JToken token = obj["result"];
            if (token == null)
                return companys;
            JToken token1 = token["toReturn"];
            if (token1 == null)
                return companys;
            JArray tokenList = token1 as JArray;
            if (tokenList.Count == 0)
                return companys;

            for (int i = 0; i < tokenList.Count; i++)
            {
                object company = new JsonSerializer().Deserialize(tokenList[i].CreateReader(), typeof(LogisticsCompany));
                companys.Add((LogisticsCompany)company);
            }

            return companys;
        }

        #endregion
    }
}
