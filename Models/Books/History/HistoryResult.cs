using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Books.History
{
    public class HistoryResult
    {
        public string title { get; set; }
        public string description { get; set; }
        public string contributor { get; set; }
        public string author { get; set; }
        public string contributor_note { get; set; }
        public string price { get; set; }
        public string age_group { get; set; }
        public string publisher { get; set; }
       
        
        public List<Isbn> isbns { get; set; }
        public List<RankHistory> ranks_history { get; set; }
        public List<HistoryReview> reviews { get; set; }

    }
}
