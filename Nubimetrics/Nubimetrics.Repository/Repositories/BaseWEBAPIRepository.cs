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
       
        protected BaseWEBAPIRepository()
        {
        }

        //protected virtual async Task<T> GetDataAsync<T>(string url, HttpMethod httpMethod, T data = default(T))
        //{
        //    return await GetStreamAsync<T>(url, httpMethod, data);
        //}       

        //protected virtual async Task<T> GetStreamAsync<T>( string url, HttpMethod httpMethod, T data = default(T))
        //{
        //    using( var httpClient = new HttpClient())
        //    {
        //        using (var httpMessage = new HttpRequestMessage(httpMethod, new Uri(url)))
        //        {
        //            if(!EqualityComparer<T>.Default.Equals(data, default(T)))
        //            {
        //                httpMessage.Content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, MediaTypeNames.Application.Json);
        //            }
        //            try
        //            {
        //                var responseMessage = (await httpClient.SendAsync(httpMessage)).EnsureSuccessStatusCode();

        //                var responseContentStream = await responseMessage.Content.ReadAsStreamAsync();

        //                return await JsonSerializer.DeserializeAsync<T>(responseContentStream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });


        //            }
        //            catch (Exception e)
        //            {
        //                var exceeption = e.Message;
        //                throw;
        //            }
        //        }
        //    }
        //}
    }
}
