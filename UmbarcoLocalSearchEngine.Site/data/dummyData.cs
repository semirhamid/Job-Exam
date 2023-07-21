using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace UmbarcoLocalSearchEngine.Site
{
    public static class dummyData
    {
        public static List<SearchResult> searchData = new List<SearchResult>
        {
            new SearchResult(){
                UserId = 1,
                Id = 1,
                Title = "Sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                Body = "Quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
            },
            new SearchResult(){
                UserId = 1,
                Id = 2,
                Title = "Qui est esse",
                Body = "Est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla"
            }

        };
    }
}