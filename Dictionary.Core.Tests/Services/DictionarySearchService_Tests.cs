using Dictionary.Core.Services;
using System.Threading.Tasks;
using Xunit;

namespace Dictionary.Core.Tests.Services
{
    public class DictionarySearchService_Tests
    {
        [Fact]
        public async Task SearchDictionaryAsync_ValidCallShouldReturnAsync()
        {
            var dictionarySearch = new DictionarySearchService();
            var returnedCollection = await dictionarySearch.SearchDictionaryAsync("omoiyari");
            var actual = returnedCollection.Count > 1;
            Assert.True(actual);
        }
    }
}
