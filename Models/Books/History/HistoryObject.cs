using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Books.History
{
    public class HistoryObject
    {
        public string status { get; set; }
        public string copyright { get; set; }
        public int num_results { get; set; }
        public List<HistoryResult> results { get; set; }
    }
}
