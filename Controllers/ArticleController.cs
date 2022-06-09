using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using trialforclient.Models.Articles;
using trialforclient.Services.Interfaces;

namespace trialforclient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {

        HttpClient client = new HttpClient();
        private IArticleServices _articleServices;
        public ArticleController(IArticleServices articleServices)
        {
            _articleServices = articleServices;
            client = articleServices.setclient();
        }

        [HttpGet("get-articles")]
        public async Task<ActionResult> GetArticles(string begin_date,string end_date,string facet,
            string facet_fields,string facet_filter,string fl,string fq,int page,string q,string sort)
        
        {
           
            /*string baseUrl = "https://api.nytimes.com/svc/search/v2/";
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            */
           
            string apiKey = "?api-key=6Wh0KQ0RTAMIVVuEilsbfJcd4aTJAZbZ";
            
            string path = $"articlesearch.json{apiKey}&begin_date={begin_date}&end_date={end_date}" +
                $"&facet={facet}&facet_fields={facet_fields}&facet_filter={facet_filter}&fl={fl}" +
                $"&fq={fq}&page={page}&q={q}&sort={sort}";

            //string path = $"articlesearch.json{apiKey}";
            try
            {
                HttpResponseMessage Res = await client.GetAsync(path);
                if (Res.IsSuccessStatusCode)
                {

                    var article = await Res.Content.ReadAsAsync<Article>();
                    return Ok(article);
                }
                else
                {
                    throw new HttpRequestException($"{Res.ReasonPhrase}{Res.StatusCode}");
                }
            }


           /* catch(HttpRequestException ex)
            {
                throw ex;
            }
           */
            catch(Exception my_ex)
            {
                throw new BadHttpRequestException(my_ex.Message);
            }
            //return BadRequest();

        }

    }
}
