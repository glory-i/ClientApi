using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Books.History
{
    [JsonObject]
    public class HistoryReview
    {
        public string book_review_link { get; set; }
        public string first_chapter_link { get; set; }
        public string sunday_review_link { get; set; }
        public string article_chapter_link { get; set; }
    }
}
