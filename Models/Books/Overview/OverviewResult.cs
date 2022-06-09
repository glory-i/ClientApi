using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Books.Overview
{
    public class OverviewResult
    {
        public string bestsellers_date { get; set; }
        public string published_date { get; set; }
        public List<OverviewList> lists { get; set; }
    }
}
