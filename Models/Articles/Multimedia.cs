using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Articles
{
    public class Multimedia
    {
        public int rank { get; set; }
        public string subtype { get; set; }
        public string caption { get; set; }
        public string credit { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public Legacy legacy { get; set; }
        public string crop_name { get; set; }


    }
}
