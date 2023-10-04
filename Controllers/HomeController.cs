using Microsoft.AspNetCore.Mvc;
using MIRACUM_Mapper.Models;
using System.Diagnostics;

namespace MIRACUM_Mapper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        List<Project> elements = db.db.elements.ToList();
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
                        return View("Index", updatedElements); //I have to redicted the view here to Index
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

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var existingProject = FindProjectById(Id);
            if (existingProject == null)
            {
                return Json(new { success = false, message = "Project not found." });
            }

            var updatedProjects = GetAllProjects();

            return PartialView("EditProjectModal", existingProject); //I have to redicted the view here to Index
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Project project)
        {

            Project projectToUpdate = elements.Find(p => p.Id == project.Id);
            List<Project> updatedElements;

            if (ModelState.IsValid)
            {
                if (projectToUpdate != null)
                {
                    project.Id = projectToUpdate.Id;
                    elements.Remove(projectToUpdate);
                    updatedElements = elements;
                    updatedElements.Add(project);
                    Console.WriteLine(updatedElements);
                    return View("Index", updatedElements); //I have to redicted the view here to Index
                }
                return PartialView("EditProjectModal", project);
            }

            return PartialView("EditProjectModal", project);
            //return Json(new { success = false, message = "Data updated failed.", elements, projectToUpdate });
        }

        private Project FindProjectById(int id) => elements.FirstOrDefault(project => project.Id == id);

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
