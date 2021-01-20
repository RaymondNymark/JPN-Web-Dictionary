using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dictionary.Core.Services;
using System.Linq;

namespace Dictionary.Tests.Services
{
    [TestClass]
    public class DictionarySearchService_Tests
    {
        [TestMethod]
        public void SearchDictionaryAsync_ValidCallShouldReturnSomething()
        {
            var input = "omoiyari";
            var actual = false;
            var service = new DictionarySearchService();

            var retrievedList = service.SearchDictionaryAsync(input).Result;

            if (retrievedList.Count > 1)
            {
                // Returns true if anything is actually retrieved.
                actual = true;
            }

            Assert.IsTrue(actual);
        }
    }
}
