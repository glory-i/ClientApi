using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Books.Overview
{
    public class OverviewResponse
    {
        public string status { get; set; }
        public string copyright { get; set; }
        public int num_results { get; set; }

        public OverviewResult results { get; set; }
    }
}
