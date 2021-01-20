using Dictionary.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dictionary.Core.Services
{
    public interface IDictionarySearchService
    {
        Task<List<RetrievedDictionaryModel.Entry>> SearchDictionaryAsync(string searchTerm);
    }
}