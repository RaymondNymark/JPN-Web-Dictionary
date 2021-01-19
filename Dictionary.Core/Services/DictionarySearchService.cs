using Dictionary.Core.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Core.Services
{
    public class DictionarySearchService
    {
        public DictionarySearchService()
        {
            // Initializes the API Client.  TODO : Move this to autostart.
            ApiManager.InitializeAPIClient();
        }
    }
}
