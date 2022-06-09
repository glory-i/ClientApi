using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using trialforclient.Models.Stories;
using trialforclient.Services.Interfaces;

namespace trialforclient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoriesController : ControllerBase
    {

        /*private readonly HttpClient client;
        private readonly IStoryServices _storyServices;
        public StoriesController(IStoryServices storyServices)
        {
            _storyServices = storyServices;
            client = storyServices.setclient();
        }
        */

        private readonly IHttpClientFactory _clientFactory;
        public StoriesController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        //private string baseUrl = "https://api.nytimes.com/svc/topstories/v2/";
        private string apikey = "?api-key=6Wh0KQ0RTAMIVVuEilsbfJcd4aTJAZbZ";
        

        [HttpGet("get-top-stories")]
        public async Task<ActionResult> GetTopStories(string section)
        {

            string path = $"{section}.json{apikey}";
            try
            {

                /*client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                */

                var client = _clientFactory.CreateClient("StoryClient");
                HttpResponseMessage Res = await client.GetAsync(path);
                if (Res.IsSuccessStatusCode)
                {
                    var top_stories = await Res.Content.ReadAsAsync<Story>();
                    return Ok(top_stories);
                    
                }
            }
            catch(Exception my_ex)
            {
                throw new BadHttpRequestException(my_ex.Message);
            }

            return BadRequest();

        }


    }
}
