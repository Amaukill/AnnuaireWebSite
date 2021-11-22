using AnnuaireWebSite.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace AnnuaireWebSite.Data
{
    public class Api
    {
        private static HttpClient ApiClient { get; set; }
        private static readonly string ApiCall = "https://localhost:44340";
        public static void InitializeClient()
        {
            ApiClient = new HttpClient
            {
                BaseAddress = new Uri(ApiCall)
            };
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ApiClient.Timeout = TimeSpan.FromMilliseconds(Timeout.Infinite);

        }
        public static async Task<List<Contact>>  GetContactsByParameters(string first = null , string last = null, string street = null, string city = null, int? zip = null)
        {
            NameValueCollection query = HttpUtility.ParseQueryString(string.Empty);
            
            if (first != null)
            {
                query["first"] = first;
            }
            if(last != null)
            {
                query["last"] = last;
            }
            if (street != null) 
            {
                query["city"] = city;
            }
            if (zip != null)
            {
                query["zip"] = zip.ToString(); ;
            }
            using (HttpResponseMessage response = await ApiClient.GetAsync($"{ApiCall}/GetContactsByParameters?{query}"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ReasonPhrase);
                }

                return JsonConvert.DeserializeObject<List<Contact>>(await response.Content.ReadAsStringAsync());
            }
        }
    }
}
