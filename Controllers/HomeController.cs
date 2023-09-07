using Microsoft.AspNetCore.Mvc;
using MIRACUM_Mapper.Models;
using System.Diagnostics;

namespace MIRACUM_Mapper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<Project> elements = new List<Project>
        {
             new Project { Id = 1, Name = "Internal LabCode to LOINC Mapping", Version = 1.0f},
             new Project { Id = 2, Name = "SNOMED to ICD Mapping", Version = 1.9f},
             new Project { Id = 3, Name = "ICD-10 to LOINC Mapping", Version = 0.8f},
             new Project { Id = 4, Name = "ICD-10 to SNOMED-CT Mapping", Version = 2.8f}
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View(elements);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var elementToDelete = elements.FirstOrDefault(e => e.Id == id);

            if (elementToDelete != null)
            {
                elements.Remove(elementToDelete);

                var updatedElements = elements.Select(e => new { e.Id, e.Name, e.Version }).ToList();

                return Json(new { success = true, message = "Element successfully deleted.", updatedElements });
            }
            else
            {
                return Json(new { success = false, message = "Element not found." });
            }
        }

        [HttpPost]
        public IActionResult Edit([FromBody] Project editedProject)
        {
            if (editedProject == null)
            {
                return Json(new { success = false, message = "Invalid data or data not provided." });
            }

            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                return Json(new { success = false, errors = errors });
            }

            var existingProject = FindProjectById(editedProject.Id);
            if (existingProject == null)
            {
                return Json(new { success = false, message = "Project not found." });
            }

            existingProject.Name = editedProject.Name;
            existingProject.Version = editedProject.Version;

            return Json(new { success = true, message = "Data updated successfully.", existingProject });
        }

        private Project FindProjectById(int id) => elements.FirstOrDefault(project => project.Id == id);

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