using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Articles
{
    public class Doc
    {
        public string web_url { get; set; }
        public string snippet { get; set; }
        public int print_page { get; set; }
        public string print_section { get; set; }
        public string source { get; set; }
        public List<Multimedia> multimedia { get; set; }
        public Headline headline { get; set; }
        public List<Keyword> keywords { get; set; }
        public string pub_date { get; set; }
        public string document_type { get; set; }
        public string news_desk { get; set; }
        public string section_name { get; set; }
        public Byline byline { get; set; }
        public string type_of_material { get; set; }
        public string _id { get; set; }
        public int word_count { get; set; }
        public string uri { get; set; }

    }
}
