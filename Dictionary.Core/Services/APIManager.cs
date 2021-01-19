using System;
using System.Net.Http;

namespace Dictionary.Core.Services
{
    public static class ApiManager
    {
        // Static so it only opens once to save performance. 
        public static HttpClient ApiClient { get; set; } = new HttpClient();

        public static void InitializeAPIClient()
        {
            ApiClient = new HttpClient();
            // Sets base address as the entire API so requests won't have to
            // have the full URL in them, instead only the actual search term.
            ApiClient.BaseAddress = new Uri("https://jisho.org/api/v1/search/words?keyword=");

            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
