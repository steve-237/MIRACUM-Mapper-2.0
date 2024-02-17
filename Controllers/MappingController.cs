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

        [HttpPost]
        public IActionResult DeleteSelectedMappings(int projectId, List<int> selectedMappings)
        {

            var project = elements.FirstOrDefault(p => p.Id == projectId);

            if (project == null)
            {
                return NotFound();
            }


            foreach (var mappingId in selectedMappings)
            {
                var mappingToRemove = project.Mappings.FirstOrDefault(m => m.Id == mappingId);
                if (mappingToRemove != null)
                {
                    project.Mappings.Remove(mappingToRemove);
                }
            }

            return View("Index", project);
        }

        public IActionResult Edit(int id)
        {
            var project = elements.FirstOrDefault(e => e.Id == id);
            if (project == null)
            {
                return View("Error");
            }
            return View(project);
        }

        [HttpPost]
        public IActionResult Edit(int Id, List<Mapping> Mappings)
        {
            if (Mappings != null)
            {
                var project = elements.FirstOrDefault(e => e.Id == Id);
                if (project == null)
                {
                    return View("Error");
                }

                project.Mappings = Mappings;


                return RedirectToAction("Index", new { id = Id });
            }

            return View("Edit", Mappings);
        }

    }
}
