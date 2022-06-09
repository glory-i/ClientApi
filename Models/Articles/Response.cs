using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Articles
{
    public class Response
    {
        public List<Doc> docs { get; set; }
        public Meta meta { get; set; }
    }
}
