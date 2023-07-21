$(document).ready(function () {
    const searchInput = $("#searchTerm");
    const searchResults = $("#searchResults");

    searchInput.on("input", function () {
        const searchTerm = searchInput.val().trim();
        filterResults(searchTerm);
    });

    function filterResults(searchTerm) {
        if (searchTerm == "") {
            searchResults.html("");
            return;
        }

        $.ajax({
            url: `/umbraco/api/Search/GetSearchResults?searchTerm=${encodeURIComponent(
                searchTerm
            )}`,
            type: "GET",
            dataType: "json",
            success: function (data) {
                let resultsHtml = "";
                console.log(data)
                if(data.length == 0){
                    resultsHtml = `<li><h4>No results found</h4></li>`;
                }else{
                    data.forEach((result) => {
                        resultsHtml += `<li><h4>${result.title}</h4><p>${result.body}</p></li>`;
                    });
                }
                
                searchResults.html(`<ul>${resultsHtml}</ul>`);
            },
            error: function (error) {
                console.error("Error fetching search results:", error);
            },
        });
    }
});
