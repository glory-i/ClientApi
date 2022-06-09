using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using trialforclient.Services.Interfaces;

namespace trialforclient.Services.Implementations
{
    public class BookServices : IBookServices
    {

        //public HttpClient client { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //HttpClient client = new HttpClient();
        //public HttpClient client { get; set; }
        public HttpClient setclient()
        {
            HttpClient client = new HttpClient();
            string baseUrl = "https://api.nytimes.com/svc/books/v3/";
            
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return client;

        } 
    }
}


