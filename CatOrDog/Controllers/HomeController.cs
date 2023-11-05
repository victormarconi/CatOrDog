using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CatOrDog.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        // Método para obter imagem de cachorro
        [HttpGet]
        public async Task<IActionResult> GetDogImage()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync("https://api.thedogapi.com/v1/images/search");
                var data = JArray.Parse(response);
                var imageUrl = data[0]["url"].ToString();
                return Json(new { url = imageUrl });
            }
        }

        // Método para obter imagem de gato
        [HttpGet]
        public async Task<IActionResult> GetCatImage()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync("https://api.thecatapi.com/v1/images/search");
                var data = JArray.Parse(response);
                var imageUrl = data[0]["url"].ToString();
                return Json(new { url = imageUrl });
            }
        }
    }
}
