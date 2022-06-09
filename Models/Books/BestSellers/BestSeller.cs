using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Books.BestSellers
{
    public class BestSeller
    {
        public string status { get; set; }
        public string copyright { get; set; }
        public int num_results { get; set; }
        public List<Result> results { get; set; }
    }
}
