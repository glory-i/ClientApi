using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trialforclient.Models.Books.History
{
    [JsonObject]
    public class Isbn
    {
        public string isbn10 { get; set; }
        public string isbn13 { get; set; }
    }
}
