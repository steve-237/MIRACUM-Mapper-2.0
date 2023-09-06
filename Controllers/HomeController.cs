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
            var elements = new List<Project>
            {
                new Project { Id = 1, Name = "Internal LabCode to LOINC Mapping", Version = 1.0f},
                new Project { Id = 2, Name = "SNOMED to ICD Mapping", Version = 1.9f},
                new Project { Id = 3, Name = "ICD-10 to LOINC Mapping", Version = 0.8f},
                new Project { Id = 4, Name = "ICD-10 to SNOMED-CT Mapping", Version = 2.8f}
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