using Microsoft.AspNetCore.Mvc;
using UmbarcoLocalSearchEngine.Site.Services;
using Umbraco.Cms.Web.Common.Controllers;

namespace UmbarcoLocalSearchEngine.Site
{
    public class SearchController : UmbracoApiController
    {
        private readonly ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet]
        public IActionResult GetSearchResults(string searchTerm)
        {
            var results = _searchService.GetSearchResults(searchTerm);
            return Ok(results);
        }
    }
}
