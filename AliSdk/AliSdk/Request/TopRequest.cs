using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{
    public abstract class TopRequest
    {
        public abstract string GetApiName();
        public virtual string GetVersion()
        {
            return "1";
        }
    }
}
