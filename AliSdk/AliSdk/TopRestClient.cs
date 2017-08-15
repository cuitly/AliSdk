using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliSdk.Top.Api.Utils;
using AliSdk.Top.Api.Domain;
using Newtonsoft.Json;

namespace AliSdk.Top.Api
{
    public class TopRestClient:ITopClient
    {
      
        public const string FORMAT = "param2";
        //public const string VERSION = "1";
        //public const string VERSION2 = "2";
        public const string NAMESPACE = "cn.alibaba.open";

        private string appKey;
        private string appSecret;
        private string url;

        public TopRestClient(string url, string appKey, string appSecret)
        {
            this.appKey = appKey;
            this.appSecret = appSecret;
            this.url = url;
        }

        #region ITopClient 成员

        public T Execute<T>(AliSdk.Top.Api.Request.ITopRequest request, AliSdk.Top.Api.parser.ITopParser<T> parser)
        {
            return Execute<T>(request, parser, false,null);
        }

        public T Execute<T>(AliSdk.Top.Api.Request.ITopRequest request, AliSdk.Top.Api.parser.ITopParser<T> parser, bool signature)
        {
            return Execute<T>(request, parser, signature, null);
        }

        public T Execute<T>(AliSdk.Top.Api.Request.ITopRequest request, AliSdk.Top.Api.parser.ITopParser<T> parser, bool signature, string access_token)
        {
            // 添加协议级请求参数
            TopDictionary txtParams = new TopDictionary(request.GetParameters());
            txtParams.Add("timestamp", DateTime.Now);

            //是否需要用户授权令牌
            if (!string.IsNullOrEmpty(access_token))
                txtParams.Add("access_token", access_token);

             //添加签名参数,不同请求版本不同
            string urlPath = string.Format("{0}/{1}/{2}/{3}/{4}", FORMAT, request.GetVersion(),
                    NAMESPACE, request.GetApiName(), this.appKey);
            if (signature)
                txtParams.Add("_aop_signature", TopUtils.SignTopRequest(urlPath, txtParams, appSecret));

            //url
            string serverUrl = string.Format("{0}/{1}", this.url, urlPath);

            //if (request.GetApiName().Equals("trade.order.batch.rate"))
            //{
            //    TradeRateParam map = new TradeRateParam();
            //    map.Content = txtParams["content"].ToString();
            //    map.StarLevel = txtParams["starLevel"].ToString();

            //    string mapstr = Newtonsoft.Json.JsonConvert.SerializeObject(map);

            //    txtParams.Add("orders", mapstr);

            //    txtParams.Remove("content");
            //    txtParams.Remove("starLevel");
            //}


            string response;
            response = WebUtils.DoPost(serverUrl, txtParams);

            return parser.Parse(response);
        }

        #endregion
    }
}
