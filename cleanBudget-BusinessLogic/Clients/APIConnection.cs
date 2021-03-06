using cleanBudget_BL.Clients.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace cleanBudget_BL.Clients
{
    public class APIConnection : IAPIConnection
    {
        private HttpClient client;
        public APIConnection(HttpClient client)
        {
            this.client = client;
        }

        public async Task<T> SendGetRequestAsync<T>(string APILink, Dictionary<string,object> requestObj = null)
        {
            try
            {
                string getParams = "";
                if (requestObj != null)
                    getParams = "?" + String.Join("&",requestObj.Select(x => x.Key + "=" + x.Value.ToString()));

                Stream JSONResponse = await client.GetStreamAsync(APILink + getParams);

                return await JsonSerializer.DeserializeAsync<T>(JSONResponse);
            }
            catch (HttpRequestException e)
            {
                return default;
            }
        }

        public async Task<T> SendPostRequestAsync<T,U>(string APILink, U requestObj = default)
        {
            try
            {
                MemoryStream JSON = new MemoryStream();
                await JsonSerializer.SerializeAsync(JSON,requestObj);
                var byteContent = new ByteArrayContent(JSON.ToArray());
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var httpResponse = await client.PostAsync(APILink, byteContent);
                Stream JSONResponse = await httpResponse.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<T>(JSONResponse);
            }
            catch (HttpRequestException e)
            {
                return default;
            }
        }
    }
}
