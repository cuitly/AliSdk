using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace AliSdk.Top.Api.Utils
{
    public class TopUtils
    {
        /// <summary>
        /// 给TOP请求签名。
        /// </summary>
        /// <param name="parameters">所有字符型的TOP请求参数</param>
        /// <param name="secret">签名密钥</param>
        /// <returns>签名</returns>
        public static string SignTopRequest(IDictionary<string, string> parameters, string sercret)
        {
            return SignTopRequest("", parameters, sercret);
        }

        /// <summary>
        /// 给TOP请求签名。
        /// </summary>
        /// <param name="parameters">所有字符型的TOP请求参数</param>
        /// <param name="secret">签名密钥</param>
        /// <returns>签名</returns>
        public static string SignTopRequest(string urlPath,IDictionary<string, string> parameters, string secret)
        {
            // 第一步：把字典按Key的字母顺序排序
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(parameters);
            IEnumerator<KeyValuePair<string, string>> dem = sortedParams.GetEnumerator();

            // 第二步：把所有参数名和参数值串在一起
            StringBuilder query = new StringBuilder(urlPath);
            while (dem.MoveNext())
            {
                string key = dem.Current.Key;
                string value = dem.Current.Value;
                if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
                {
                    query.Append(key).Append(value);
                }
            }

            // 第三步：使用MD5加密
            using (HMACSHA1 sha = new HMACSHA1(Encoding.UTF8.GetBytes(secret)))
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(query.ToString()));
                // 第四步：把二进制转化为大写的十六进制
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    string hex = bytes[i].ToString("X");
                    if (hex.Length == 1)
                    {
                        result.Append("0");
                    }
                    result.Append(hex);
                }
                return result.ToString();
            }            
        }
    }
}
