using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliSdk.Top.Api.Request
{
    public interface ITopRequest
    {
        /// <summary>
        /// 获取TOP的API名称。
        /// </summary>
        /// <returns>API名称</returns>
        string GetApiName();

        /// <summary>
        /// 获取所有的Key-Value形式的文本请求参数字典。其中：
        /// Key: 请求参数名
        /// Value: 请求参数文本值
        /// 重点：接口参数区分大小写
        /// </summary>
        /// <returns>文本请求参数字典</returns>
        IDictionary<string, string> GetParameters();
    }
}
