
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApi.Models;
using EF.Entities.RickAndMorty;

namespace WebApi.Controllers
{
    public class RickAndMortyController : Controller
    {

        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://rickandmortyapi.com/api/character");
            
            RickAndMortyEntity characters = JsonConvert.DeserializeObject<RickAndMortyEntity>(json);
            var result = characters.Results.Select(s => new RickAndMortyModel { Name = s.Name, Gender = s.Gender, Image = s.Image, Origin = s.Origin.Name, Species = s.Species }).ToList();

            return View(result);
        }
    }
}