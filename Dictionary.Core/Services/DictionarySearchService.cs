using Dictionary.Core.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dictionary.Core.Services
{
    public class DictionarySearchService : IDictionarySearchService
    {
        public DictionarySearchService()
        {
            // Initializes the API Client.  TODO : Move this to autostart.
            ApiManager.InitializeAPIClient();
        }

        /// <summary>
        /// Performs a dictionary search using the search term and returns a list
        /// of found entries, if they are found.
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns>A list of retrieved dictionary searches</returns>
        public async Task<List<RetrievedDictionaryModel.Entry>> SearchDictionaryAsync(string searchTerm)
        {
            string SearchTerm = searchTerm;
            string Url = $"https://jisho.org/api/v1/search/words?keyword={SearchTerm}";

            using (HttpResponseMessage response = await ApiManager.ApiClient.GetAsync(Url))
            {
                if (response.IsSuccessStatusCode)
                {
                    // Fetches all of the data from the API call and plots it
                    // into the DictionaryEntry model, shaving off properties
                    // that will not be used in the process. 
                    var DeserializedEntries = await response.Content.ReadAsAsync<RetrievedDictionaryModel.DictionaryResult>();

                    return DeserializedEntries.Entries;
                }
                else
                {
                    // Throws exception if response is not successful.
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
    }
}
