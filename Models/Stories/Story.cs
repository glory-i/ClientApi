using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Stories
{
    public class Story
    {
        public string status { get; set; }
        public string copyright { get; set; }
        public string section { get; set; }
        public string last_updated { get; set; }
        public int num_results { get; set; }
        public List<Article> results { get; set; }
    }
}
