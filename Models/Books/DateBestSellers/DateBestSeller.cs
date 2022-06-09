using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Books.DateBestSellers
{
    public class DateBestSeller
    {
        public string status { get; set; }
        public string copyright { get; set; }
        public int num_results { get; set; }
        public string last_modified { get; set; }
        public ResultObject results { get; set; }
    }
}
