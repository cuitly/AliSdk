using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliSdk.Top.Api.Domain;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AliSdk.Top.Api.parser
{
    public class LogisticesOrderGetParser : ITopParser<List<LogisticsOrder>>
    {
        #region ITopParser<List<LogisticsOrder>> 成员

        public List<LogisticsOrder> Parse(string body)
        {
            JObject obj = JObject.Parse(body);

            List<LogisticsOrder> logistices = new List<LogisticsOrder>();
            JToken token = obj["dataList"];
            if (token == null)
                return logistices;
            JArray tokenList = token as JArray;
            if (tokenList.Count == 0)
                return logistices;

            for (int i = 0; i < tokenList.Count; i++)
            {
                object logistice = new JsonSerializer().Deserialize(tokenList[i].CreateReader(), typeof(LogisticsOrder));
                logistices.Add((LogisticsOrder)logistice);
            }

            return logistices;
        }

        #endregion
    }
}
