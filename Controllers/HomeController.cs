using Microsoft.AspNetCore.Mvc;
using MIRACUM_Mapper.Models;
using System.Diagnostics;

namespace MIRACUM_Mapper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var elements = new List<ElementModel>
            {
                new ElementModel { Id = 1, Titre = "Élément 1" , Version = 1},
                new ElementModel { Id = 2, Titre = "Élément 2", Version = 5 },
                new ElementModel { Id = 3, Titre = "jean 1" , Version = 7},
                new ElementModel { Id = 4, Titre = "paul 2", Version = 0 },
                new ElementModel { Id = 5, Titre = "eli 1" , Version = 4},
                new ElementModel { Id = 6, Titre = "vent 2" , Version = 3},
                new ElementModel { Id = 7, Titre = "chat 1" , Version = 1},
                new ElementModel { Id = 8, Titre = "paul 2" , Version = 1},
                new ElementModel { Id = 3, Titre = "jean 1" , Version = 1},
                new ElementModel { Id = 4, Titre = "paul 2" , Version = 1},
                new ElementModel { Id = 5, Titre = "eli 1" , Version = 1},
                new ElementModel { Id = 6, Titre = "vent 2" , Version = 1},
                new ElementModel { Id = 7, Titre = "chat 1" , Version = 1},
                new ElementModel { Id = 8, Titre = "paul 2", Version = 1},
            };
            return View(elements);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}