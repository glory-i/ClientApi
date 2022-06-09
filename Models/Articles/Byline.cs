using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Articles
{
    public class Byline
    {
        public string original { get; set; }
        public List<Person> person { get; set; }
        public string organization { get; set; }
    }
}
