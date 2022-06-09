using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Books.FullOverview
{
    public class FullOverviewBook
    {
        public string age_group { get; set; }
        public string author { get; set; }
        public string contributor { get; set; }
        public string contributor_note { get; set; }
        public string created_date { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public string primary_isbn13 { get; set; }
        public string primary_isbn10 { get; set; }
        public string publisher { get; set; }
        public int rank { get; set; }
        public string title { get; set; }
        public string updated_date { get; set; }
    }
}
