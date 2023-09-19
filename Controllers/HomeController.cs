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
             new Project { Id = 1, Name = "Internal LabCode to LOINC Mapping", Description ="description id1", Version = 1.0f, Sources = {}, Targets = {}, DisplayMappingEquivalence= true, DisplayStatus=false},
             new Project { Id = 2, Name = "SNOMED to ICD Mapping", Description ="description id2",Version = 1.9f, Sources = {}, Targets = {}, DisplayMappingEquivalence= true, DisplayStatus=true},
             new Project { Id = 3, Name = "ICD-10 to LOINC Mapping", Description ="description id3",Version = 0.8f, Sources = {}, Targets = {}, DisplayMappingEquivalence= false, DisplayStatus=false},
             new Project { Id = 4, Name = "ICD-10 to SNOMED-CT Mapping",Description ="description id4", Version = 2.8f, Sources = {}, Targets = {}, DisplayMappingEquivalence= false, DisplayStatus=true}
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(elements);
        }

        public List<Project> GetAllProjects()
        {
            return elements;
        }

        [HttpPost]
        public IActionResult Create(Project project)
        {
            elements.Add(project);
            var newElements = elements;
            return View("Index", newElements);
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

        //[HttpPost]
        //public IActionResult Edit([FromBody] Project editedProject)
        //{
        //    if (editedProject == null)
        //    {
        //        return Json(new { success = false, message = "Invalid data or data not provided." });
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
        //        return Json(new { success = false, errors = errors });
        //    }

        //    var existingProject = FindProjectById(editedProject.Id);
        //    if (existingProject == null)
        //    {
        //        return Json(new { success = false, message = "Project not found.", editedProject });
        //    }

        //    existingProject.Name = editedProject.Name;
        //    existingProject.Version = editedProject.Version;

        //    var updatedProjects = GetAllProjects();

        //    return Json(new { success = true, message = "Data updated successfully.", updatedProjects, editedProject });
        //}

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var existingProject = FindProjectById(Id);
            if (existingProject == null)
            {
                return Json(new { success = false, message = "Project not found." });
            }

            var updatedProjects = GetAllProjects();

            return View("Edit", existingProject);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Project project)
        {
            if (id != project.Id)
            {
                return NotFound();
            }

            Project projectToUpdate = elements.Find(p => p.Id == project.Id);

            if (ModelState.IsValid)
            {
                if (projectToUpdate != null)
                {
                    projectToUpdate.Id = project.Id;
                    projectToUpdate.Name = project.Name;
                    projectToUpdate.Version = project.Version;
                    projectToUpdate.Description = project.Description;
                    projectToUpdate.Sources = project.Sources;
                    projectToUpdate.Targets = project.Targets;
                }
                return View("index", elements);
            }

            return Json(new { success = false, message = "Data updated failed.", elements, projectToUpdate });
        }

        public IActionResult EditModal(int projectId)
        {
            var project = FindProjectById(projectId);

            Project model = new Project
            {
                Id = project.Id,
                Name = project.Name,
                Version = project.Version,
                Description = project.Description
            };
            return PartialView("_EditProjectModal", model);
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