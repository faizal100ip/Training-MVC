using Newtonsoft.Json;
using System.Reflection;
using System.Collections.Generic;
using Newtonsoft.Json.Serialization;
using RestSharp;

namespace Training.MVC.Factory
{
    public class FactoryApi : IFactoryApi
    {
        private const string _MYIMMS_WEBAPI_404 = "[404]API Controller Cannot Be Contacted.";
        private const string BasicAuthResponseHeader = "WWW-Authenticate";
        private const string BasicAuthResponseHeaderValue = "Basic";
        private const string WEB_API_URL = "http://localhost:56253/";
        public FactoryApi()
        {
        }


        public virtual void GetAPI<T>(T vm, string apiResource)
        {
            var client = this.GetApiClientSetup();
            var request = this.GetApiRequestSetup(apiResource, RestSharp.Method.GET);
            request.AddBody(vm);
            var response = client.Execute(request);

            if (!response.IsSuccessful())
            {
                ErrorResponse(request, response);
            }
        }

        public TReturn GetAPISingle<TReturn, TRequest>(TRequest vm, string apiResource)
        {
            var client = this.GetApiClientSetup();
            var request = this.GetApiRequestSetup(apiResource, RestSharp.Method.GET);
            request.AddBody(vm);
            var response = client.Execute(request);


            if (!response.IsSuccessful())
            {
                ErrorResponse(request, response);
            }

            return JsonConvert.DeserializeObject<TReturn>(response.Content);
        }


        public virtual T GetAPISingle<T>(string apiResource)
        {
            var client = this.GetApiClientSetup();
            var request = this.GetApiRequestSetup(apiResource, RestSharp.Method.GET);
            var response = client.Execute(request);

            if (!response.IsSuccessful())
            {
                ErrorResponse(request, response);
            }
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public virtual T GetAPISingle<T>(string name, string value, string apiResource)
        {
            var client = this.GetApiClientSetup();
            var request = this.GetApiRequestSetup(apiResource, RestSharp.Method.GET);

            request.AddParameter(name, value);
            var response = client.Execute(request);

            if (!response.IsSuccessful())
            {
                ErrorResponse(request, response);
            }

            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public virtual List<TReturn> GetAPIList<TReturn, TRequest>(TRequest vm, string apiResource)
        {
            var client = this.GetApiClientSetup();
            var request = this.GetApiRequestSetup(apiResource, RestSharp.Method.GET);
            var response = client.Execute(request);
            request.AddBody(vm);

            if (!response.IsSuccessful())
            {
                ErrorResponse(request, response);
            }
            return JsonConvert.DeserializeObject<List<TReturn>>(response.Content);
        }

        public virtual List<T> GetAPIList<T>(string apiResource)
        {
            var client = this.GetApiClientSetup();
            var request = this.GetApiRequestSetup(apiResource, RestSharp.Method.GET);
            var response = client.Execute(request);

            if (!response.IsSuccessful())
            {
                ErrorResponse(request, response);
            }
            return JsonConvert.DeserializeObject<List<T>>(response.Content);
        }

        public virtual List<T> GetAPIList<T>(T vm, string apiResource)
        {
            var client = this.GetApiClientSetup();
            var request = this.GetApiRequestSetup(apiResource, RestSharp.Method.GET);
            request.AddBody(vm);
            var response = client.Execute(request);


            if (!response.IsSuccessful())
            {
                ErrorResponse(request, response);
            }
            return JsonConvert.DeserializeObject<List<T>>(response.Content);
        }



        public virtual void PostAPI<T>(T vm, string apiResource)
        {
            var client = this.GetApiClientSetup();
            var request = this.GetApiRequestSetup(apiResource, RestSharp.Method.POST);
            request.AddBody(vm);
            var response = client.Execute(request);

            if (!response.IsSuccessful())
            {
                ErrorResponse(request, response);
            }
        }

        public virtual string PostAPISingle<T>(string apiResource)
        {
            var client = this.GetApiClientSetup();
            var request = this.GetApiRequestSetup(apiResource, RestSharp.Method.POST);
            var response = client.Execute(request);

            if (!response.IsSuccessful())
            {
                ErrorResponse(request, response);
            }
            return response.Content;
        }

        public virtual T PostAPISingle<T>(T vm, string apiResource)
        {
            var client = this.GetApiClientSetup();
            var request = this.GetApiRequestSetup(apiResource, RestSharp.Method.POST);
            request.AddBody(vm);
            var response = client.Execute(request);

            if (!response.IsSuccessful())
            {
                ErrorResponse(request, response);
            }
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public virtual TResult PostAPISingle<TResult, TRequest>(TRequest vm, string apiResource)
        {
            var client = this.GetApiClientSetup();
            var request = this.GetApiRequestSetup(apiResource, RestSharp.Method.POST);
            request.AddBody(vm);
            var response = client.Execute(request);

            if (!response.IsSuccessful())
            {
                ErrorResponse(request, response);
            }

            var records = JsonConvert.DeserializeObject<TResult>(response.Content, Settings);

            return records;
        }

        public virtual List<TResult> PostAPIList<TResult, TRequest>(TRequest vm, string apiResource)
        {
            var client = this.GetApiClientSetup();
            var request = this.GetApiRequestSetup(apiResource, RestSharp.Method.POST);
            request.AddBody(vm);
            var response = client.Execute(request);

            if (!response.IsSuccessful())
            {
                ErrorResponse(request, response);
            }
            return JsonConvert.DeserializeObject<List<TResult>>(response.Content);
        }

        public virtual T PostAPISingle<T>(dynamic vm, string apiResource)
        {
            var client = this.GetApiClientSetup();
            var request = this.GetApiRequestSetup(apiResource, RestSharp.Method.POST);
            request.AddBody(vm);
            var response = client.Execute(request);

            if (!response.IsSuccessful())
            {
                ErrorResponse(request, response);
            }
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public virtual List<T> PostAPIList<T>(string apiResource)
        {
            var client = this.GetApiClientSetup();
            var request = this.GetApiRequestSetup(apiResource, RestSharp.Method.POST);
            var response = client.Execute(request);

            if (!response.IsSuccessful())
            {
                ErrorResponse(request, response);
            }
            return JsonConvert.DeserializeObject<List<T>>(response.Content);
        }

        public virtual List<T> PostAPIList<T>(T vm, string apiResource)
        {
            var client = this.GetApiClientSetup();
            var request = this.GetApiRequestSetup(apiResource, RestSharp.Method.POST);
            request.AddBody(vm);
            var response = client.Execute(request);

            if (!response.IsSuccessful())
            {
                ErrorResponse(request, response);
            }
            return JsonConvert.DeserializeObject<List<T>>(response.Content);
        }


        #region Common

        /// <summary>
        /// Common: To Get Request 
        /// </summary>
        /// <returns></returns>
        public virtual RestSharp.RestRequest GetApiRequestSetup(string apiResource, RestSharp.Method method)
        {
            var request = new RestSharp.RestRequest(apiResource, method) { RequestFormat = RestSharp.DataFormat.Json };
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            return request;
        }

        /// <summary>
        /// Common: To Get Request 
        /// </summary>
        /// <returns></returns>
        public virtual RestSharp.RestClient GetApiClientSetup()
        {
            var client = new RestSharp.RestClient(WEB_API_URL.ToString());

            return client;
        }


        public void ErrorResponse(IRestRequest request, IRestResponse response)
        {
            var ex = JsonConvert.DeserializeObject<System.Web.Http.HttpError>(response.Content);
            const string message = "[FactoryApi] Error retrieving response.  Check inner details for more info.";
            throw new RestException(response.StatusCode, response.ResponseUri, response.Content, message);
        }

        public readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            ContractResolver = new NonPublicPropertiesResolver()
        };


        #endregion

    }

    public class NonPublicPropertiesResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var prop = base.CreateProperty(member, memberSerialization);
            var pi = member as PropertyInfo;
            if (pi != null)
            {
                prop.Readable = (pi.GetMethod != null);
                prop.Writable = (pi.SetMethod != null);
            }
            return prop;
        }
    }
}
