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
            var project = elements.FirstOrDefault(p => p.Id == projectId);

            if (project == null)
            {
                return NotFound();
            }

            var mappings = project.Mappings.Where(m => selectedMappings.Contains(m.Id)).ToList();

            if (mappings == null)
            {
                return NotFound();
            }

            return Json(mappings);
        }

        [HttpPost]
        public IActionResult Delete(Project project)
        {
            List<Project> updatedElements;

            if (project != null)
            {
                var elementToDelete = elements.FirstOrDefault(e => e.Id == project.Id);
                if (elementToDelete != null)
                {
                    if (elements.Remove(elementToDelete))
                    {
                        updatedElements = elements;
                        return View("~/Views/Home/Index.cshtml", updatedElements); //I have to redicted the view here to Index
                    }
                }
                return PartialView("_ConfirmDelete", elements);
                //return Json(new { success = true, message = "Element successfully deleted.", updatedElements });
            }
            else
            {
                return PartialView("_ConfirmDelete", elements);
            }
        }
    }
}
