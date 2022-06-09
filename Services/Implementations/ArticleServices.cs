using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using trialforclient.Services.Interfaces;

namespace trialforclient.Services.Implementations
{
    public class ArticleServices : IArticleServices
    {
        public HttpClient setclient()
        {
            //throw new NotImplementedException();
            HttpClient client = new HttpClient();
            string baseUrl = "https://api.nytimes.com/svc/search/v2/";
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}
