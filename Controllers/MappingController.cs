using Microsoft.AspNetCore.Mvc;
using MIRACUM_Mapper.Models;

namespace MIRACUM_Mapper.Controllers
{
    public class MappingController : Controller
    {
        public List<Project> elements = db.db.elements.ToList();
        public IActionResult Index(int id)
        {
            var project = elements.FirstOrDefault(e => e.Id == id);
            if (project == null)
            {
                return View("Error");
            }
            return View(project);
        }

        public List<Project> GetAllProjects()
        {
            return elements;
        }

        [HttpPost]
        public IActionResult FetchInfo(int projectId, List<int> selectedMappings)
        {
            var projet = elements.FirstOrDefault(p => p.Id == projectId);

            if (projet == null)
            {
                return NotFound();
            }

            var mappings = projet.Mappings.Where(m => selectedMappings.Contains(m.Id)).ToList();

            if (mappings == null)
            {
                return NotFound();
            }

            return Json(mappings);
        }
    }
}
