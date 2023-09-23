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
    }
}
