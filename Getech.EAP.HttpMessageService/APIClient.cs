using System;
using System.Net;
using RestSharp;
using RestSharp.Authenticators;

namespace Getech.EAP.HttpMessageService
{
    public class APIClient : IDisposable
    {
        private const string BaseUrl = "";
        private readonly IRestClient client;
        public APIClient(string accountSid, string secretKey)
        {
            client = new RestClient(BaseUrl) { Authenticator = new HttpBasicAuthenticator(accountSid, secretKey) };
        }
        public APIClient(string url)
        {
            client = new RestClient(url);
        }

        public T Execute<T>(RestRequest request) where T : new()
        {
            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var ex = new Exception(message, response.ErrorException);
                throw ex;
            }
            return response.Data;
        }

        public IRestClient Client => client;
        /// <summary>
        /// 调用get接口方法
        /// </summary>
        /// <typeparam name="T">返回对象</typeparam>
        /// <param name="apiName">接口名称</param>
        /// <param name="pragm">参数信息</param>
        /// <returns></returns>
        public T GetApi<T>(string apiName, string pragm = "")
        {
            var apiNameStr = string.Format($"{BaseUrl}/{apiName}");
            if (!string.IsNullOrEmpty(pragm))
            {
                apiName = $"{apiName}?{pragm}";
            }
            var req = new RestRequest(apiName, Method.GET);
            req.AddHeader("Accept", "application/json");
            client.Timeout = 5000;
            var request = client.Execute(req);
            if (request.StatusCode != HttpStatusCode.OK)
            {
                return (T)Convert.ChangeType(request.ErrorMessage, typeof(T));
            }
            T result = (T)Convert.ChangeType(request.Content, typeof(T));
            return result;
        }
        /// <summary>
        /// 调用post接口方法
        /// </summary>
        /// <typeparam name="T">返回类型</typeparam>
        /// <param name="apiName">接口名称</param>
        /// <param name="obj">参数对象</param>
        /// <returns></returns>
        public T PostApi<T>(string apiName, object obj)
        {
            var req = new RestRequest(apiName, Method.POST);
            req.AddHeader("Accept", "application/json");
            req.Timeout = 5000;
            req.AddJsonBody(obj);
            var res = client.Execute(req);
            var result = res.Content;
            if (res.StatusCode != HttpStatusCode.OK)
            {
                return (T)Convert.ChangeType(res.ErrorMessage, typeof(T));
            }
            T request = (T)Convert.ChangeType(res.Content, typeof(T));
            return request;
        }
        public void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
