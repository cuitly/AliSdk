using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.parser
{
    public class JsonParser
    {
        protected string apiName;//ITopRequest request;

        public JsonParser(string apiName)
        {
            this.apiName = apiName;
        }
    }
}
