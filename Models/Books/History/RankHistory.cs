using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Books.History
{
    [JsonObject]
    public class RankHistory
    {
        public string primary_isbn10 { get; set; }
        public string primary_isbn13 { get; set; }
        public int rank { get; set; }
        public string list_name { get; set; }
        public string display_name { get; set; }
        public string published_date { get; set; }
        public string bestsellers_date { get; set; }
        public int weeks_on_list { get; set; }
        public string ranks_last_week { get; set; }
        public int asterisk { get; set; }
        public int dagger { get; set; }



    }
}
