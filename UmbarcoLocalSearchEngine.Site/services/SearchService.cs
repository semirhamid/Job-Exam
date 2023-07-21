using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using System.Collections.Generic;
using UmbarcoLocalSearchEngine.Site.Models;

namespace UmbarcoLocalSearchEngine.Site.Services
{
    public interface ISearchService
    {
        List<SearchResultDto> GetSearchResults(string searchTerm);
    }
}
