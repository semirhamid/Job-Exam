using System;
using System.Collections.Generic;
using System.Linq;

using UmbarcoLocalSearchEngine.Site.Models;

namespace UmbarcoLocalSearchEngine.Site.Services
{
    public class SearchService : ISearchService
    {
        public List<SearchResultDto> GetSearchResults(string searchTerm)
        {
            var results = dummyData.searchData
                .Where(r => r.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
                            || r.Body.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                .Select(r => new SearchResultDto { Title = r.Title, Body = r.Body })
                .ToList();

            return results;
        }

    
    }
}
