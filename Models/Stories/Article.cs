using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Stories
{
    public class Article
    {
        public string section { get; set; }
        public string subsection { get; set; }
        public string title { get; set; }
        public string Abstract { get; set; }
        public string url { get; set; }
        public string uri { get; set; }
        public string byline { get; set; }
        public string item_type { get; set; }
        public string updated_date { get; set; }
        public string created_date { get; set; }
        public string published_date { get; set; }
        public string material_type_facet { get; set; }
        public string kicker { get; set; }
        public List<Multimedia> multimedia { get; set; }
        public string short_url { get; set; }


    }
}
