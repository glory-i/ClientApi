using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Books.Overview
{
    public class OverviewList
    {
        public int list_id { get; set; }
        public string list_name { get; set; }
        public string display_name { get; set; }
        public string updated { get; set; }
        public string list_image { get; set; }
        public List<OverviewBook> books { get; set; }


    }
}
