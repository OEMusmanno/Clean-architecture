using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Nubimetrics.Dal.Repositories
{
    public abstract class BaseWEBAPIRepository
    {
        protected virtual async Task<T> GetDataAsync<T>(string url, HttpMethod httpMethod)
        {
            using (var httpClient = new HttpClient())
            {
                using (var httpMessage = new HttpRequestMessage(httpMethod, new Uri(url)))
                {
                    try
                    {
                        var responseMessage = (await httpClient.SendAsync(httpMessage)).EnsureSuccessStatusCode();

                        var responseContentStream = await responseMessage.Content.ReadAsStreamAsync();

                        return await JsonSerializer.DeserializeAsync<T>(responseContentStream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    }
                    catch (Exception e)
                    {
                        var exception = e.Message;
                        throw;
                    }
                }
            }
        }
    }
}
