using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Books.BestSellers
{
    public class Result
    {

        public string list_name { get; set; }

        public string display_name { get; set; }

        public string list_name_encoded { get; set; }

        public string oldest_published_date { get; set; }

        public string newest_published_date { get; set; }

        public string updated { get; set; }
    }
}
