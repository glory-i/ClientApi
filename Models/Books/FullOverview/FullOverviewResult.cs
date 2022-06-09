using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Books.FullOverview
{
    public class FullOverviewResult
    {
        public string bestsellers_date { get; set; }
        public string published_date { get; set; }
        public List<FullOverviewList> lists { get; set; }
    }
}
