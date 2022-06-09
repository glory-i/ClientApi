using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Books.DateBestSellers
{
    public class ResultObject
    {
        public string list_name { get; set; }
        public string bestsellers_date { get; set; }
        public string published_date { get; set; }
        public string display_name { get; set; }
        public int normal_list_ends_at { get; set; }
        public string updated { get; set; }
        public List<Book> books { get; set; }
        public List<Correction> corrections { get; set; }
    }
}
