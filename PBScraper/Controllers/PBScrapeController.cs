using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PBScraper.Models;

namespace PBScraper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PBScrapeController : ControllerBase
    {
        // GET: api/PBScrape
        [HttpGet]
        public List<string> Get()
        {
            List <PBScrape> allScrapes = PBScrape.GetAll();
            List <string> allProperties = new List<string>();
            for (int i = 0; i < allScrapes.Count; i++)
            {     
                allProperties.Add(allScrapes[i].GetId().ToString());
                allProperties.Add(allScrapes[i].GetKeyword());
                allProperties.Add(allScrapes[i].GetUrl());
                allProperties.Add(allScrapes[i].GetPhone());
                allProperties.Add(allScrapes[i].GetEmail());
            }
            return allProperties;
        }

        // GET: api/PBScrape/5
        [HttpGet("{id}", Name = "Get")]
        public List<string> Get(int id)
        {
            List<PBScrape> allScrapes = PBScrape.GetAll();
            PBScrape currentScrape = allScrapes[id-1];
            List<string> allProperties = new List<string>();
            allProperties.Add(currentScrape.GetId().ToString());
            allProperties.Add(currentScrape.GetKeyword());
            allProperties.Add(currentScrape.GetUrl());
            allProperties.Add(currentScrape.GetPhone());
            allProperties.Add(currentScrape.GetEmail());
            return allProperties;
        }

        // POST: api/PBScrape
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/PBScrape/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
