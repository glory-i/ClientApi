using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using trialforclient.Models.Books.BestSellers;
using System.Net.Http.Formatting;
using trialforclient.Models.Books.Overview;
using System.Globalization;
using trialforclient.Models.Books.Review;
using trialforclient.Services.Interfaces;
using trialforclient.Models.Books.FullOverview;
using trialforclient.Models.Books.History;
using trialforclient.Models.Books.DateBestSellers;

namespace trialforclient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly IBookServices _bookServices;
        private readonly HttpClient client;
        public BookController(IBookServices bookServices)
        {
            _bookServices = bookServices;
            client = bookServices.setclient();
        }
        
        //private string baseUrl = "https://api.nytimes.com/svc/books/v3/";
        
        private string apiKey = "?api-key=8MbNkLfZ5APwwW0AGUOA6oLaz4IA7pUw";
        
        //private string baseUrl = "https://api.nytimes.com/svc/books/v3/lists/names.json";
        //private string baseUrl = "https://api.nytimes.com/svc/books/v3/lists/names.json";
        //private string my_url = "https://api.nytimes.com/svc/books/v3/lists/overview.json";
        //private string urlParameters = "?api"

        

/*        [HttpGet("set-client")]
        public void setclient()
        {
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }
*/

        [HttpGet("get-bestsellers-list")]
        public async Task<ActionResult> GetBestSellersList() 
        {
            try
            {
                //setclient();
                //string path = "lists/names.json" + apiKey;
                string path = $"lists/names.json{apiKey}"; 
                HttpResponseMessage Res = await client.GetAsync(path);
                //HttpResponseMessage Res = await client.GetAsync("https://api.nytimes.com/svc/books/v3/lists/names.json?api-key=8MbNkLfZ5APwwW0AGUOA6oLaz4IA7pUw");

                if (Res.IsSuccessStatusCode)
                {
                    var new_bestseller = await Res.Content.ReadAsAsync<BestSeller>();
                    // var new_bestseller =   Res.Content.ReadAsAsync<BestSeller>().Result;
                    //BestSeller bestSeller = JsonConvert.DeserializeObject<BestSeller>(new_bestseller);

                    return Ok(new_bestseller);
                }
            }
            catch(Exception my_ex)
            {
                throw new BadHttpRequestException(my_ex.Message);
                
            }

            return BadRequest();

        }


        [HttpGet("get-top-bestsellers-list")]
        public async Task<ActionResult> GetTopBestSellersList(string date)
        {
            try
            {
                //setclient();
                //string path = "lists/overview.json" + apiKey + "&published_date=" + date;
                string path = $"lists/overview.json{apiKey}&published_date={date}";
                
                HttpResponseMessage Res = await client.GetAsync(path);

                if (Res.IsSuccessStatusCode)
                {
                    var new_overview_response = await Res.Content.ReadAsAsync<OverviewResponse>();

                    return Ok(new_overview_response);
                }
            }

            catch(Exception my_ex)
            {
                throw new BadHttpRequestException(my_ex.Message);

            }

            return BadRequest();
        }


        [HttpGet("get-book-reviews")]
        public async Task<ActionResult> GetBookReviews(string isbn,string title,string author)
        {
            try
            {
                //setclient();
                //string path = "reviews.json" + apiKey + "&isbn=" + isbn + "&title=" + title + "&author=" + author;
                string path = $"reviews.json{apiKey}&isbn={isbn}&title={title}&author={author}";
                HttpResponseMessage Res = await client.GetAsync(path);


                if (String.IsNullOrEmpty(isbn) && String.IsNullOrEmpty(title) && String.IsNullOrEmpty(author))
                {
                    return BadRequest("All the parameters cannot be empty and ISBN must be 10 or 13 digits long");
                }

                if (!String.IsNullOrEmpty(isbn))
                {
                    if (isbn.Length != 10 && isbn.Length != 13)
                    {
                        return BadRequest("Invalid Isbn. Isbn must be 10 or 13 digits");
                    }
                }
                
                if (Res.IsSuccessStatusCode)
                {
                    var new_review = await Res.Content.ReadAsAsync<ReviewObject>();

                    return Ok(new_review);
                }

            }
            catch (Exception my_ex)
            {
                throw new BadHttpRequestException(my_ex.Message);
            }

            return BadRequest();
        }


        [HttpGet("get-full-overview")]
        public async Task<ActionResult> GetFullOverview(string published_date)
        {
            try
            {
                //setclient();
                //string path = "lists/full-overview.json" + apiKey + "&published_date=" + published_date;
                
                string path = $"lists/full-overview.json{apiKey}&published_date={published_date}";
                HttpResponseMessage Res = await client.GetAsync(path);

                if (Res.IsSuccessStatusCode)
                {
                    var fullOverview = await Res.Content.ReadAsAsync<FullOverviewResponse>();

                    return Ok(fullOverview);
                }
            }

            catch (Exception my_ex)
            {
                throw new BadHttpRequestException(my_ex.Message);

            }

            return BadRequest();
        }


        [HttpGet("get-bestsellers-history")]
        public async Task<ActionResult> GetBestSellersHistory(string age_group,string author,string contributor,
            string isbn,int offset,string price,string publisher,string title)
        {
            try
            {
                //setclient();
                
                /*string path = "lists/best-sellers/history.json" + apiKey + "&age-group=" + age_group +
                    "&author="+author +"&contributor="+contributor +"&isbn="+isbn +"&offset="+offset
                    +"&price="+price +"&publisher="+publisher +"&title="+title;*/

                string path = $"lists/best-sellers/history.json{apiKey}&age-group={age_group}" +
                    $"&author={author}&contributor={contributor}&isbn={isbn}&offset={offset}" +
                    $"&price={price}&publisher={publisher}&title={title}";


                HttpResponseMessage Res = await client.GetAsync(path);

                if (Res.IsSuccessStatusCode)
                {
                    var historyObject = await Res.Content.ReadAsAsync<HistoryObject>();

                    return Ok(historyObject);
                }
            }

            catch (Exception my_ex)
            {
                throw new BadHttpRequestException(my_ex.Message);

            }

            return BadRequest();
        }


        [HttpGet("get-bestsellers-by-date")]
        public async Task<ActionResult> GetBestSellersByDate(string date,string list,int offset)
        {
            try
            {
                //setclient();
                /*string path = "lists/best-sellers/history.json" + apiKey + "&age-group=" + age_group +
                    "&author=" + author + "&contributor=" + contributor + "&isbn=" + isbn + "&offset=" + offset
                    + "&price=" + price + "&publisher=" + publisher + "&title=" + title;*/

                string path2 = $"lists/{date}/{list}.json{apiKey}&date={date}&list={list}&offset={offset}";
                HttpResponseMessage Res = await client.GetAsync(path2);

                if (Res.IsSuccessStatusCode)
                {
                    var BestSellerByDate = await Res.Content.ReadAsAsync<DateBestSeller>();

                    return Ok(BestSellerByDate);
                }
            }

            catch (Exception my_ex)
            {
                throw new BadHttpRequestException(my_ex.Message);

            }

            return BadRequest();
        }



    }
}
