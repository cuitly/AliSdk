using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliSdk.Top.Api.Request;
using AliSdk.Top.Api.parser;

namespace AliSdk.Top.Api
{
    public interface ITopClient
    {
        /// <summary>
        /// 执行TOP公开API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的TOP API请求</param>
        /// <param name="parser">与API请求响应相对应的解释器接口实现</param>
        /// <returns>领域对象</returns>
        T Execute<T>(ITopRequest request, ITopParser<T> parser);

        /// <summary>
        /// 执行TOP隐私API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的TOP API请求</param>
        /// <param name="parser">与API请求响应相对应的解释器接口实现</param>
        /// <param name="session">是否需要请求签名</param>
        /// <returns>领域对象</returns>
        T Execute<T>(ITopRequest request, ITopParser<T> parser, bool signature);

        /// <summary>
        /// 执行TOP隐私API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的TOP API请求</param>
        /// <param name="parser">与API请求响应相对应的解释器接口实现</param>
        /// <param name="session">是否需要请求签名</param>
        /// /// <param name="session">用户授权令牌</param>
        /// <returns>领域对象</returns>
        T Execute<T>(ITopRequest request, ITopParser<T> parser, bool signature, string access_token);
    }
}
