using Microsoft.AspNetCore.Mvc;
using MIRACUM_Mapper.Models;

namespace MIRACUM_Mapper.Controllers
{
    public class MappingController : Controller
    {
        private List<Project> elements = new List<Project>
        {
             new Project { Id = 1, Name = "Internal LabCode to LOINC Mapping", Description = "Decription 1", Version = 1.0f, Sources = {}, Targets = {} },
             new Project { Id = 2, Name = "SNOMED to ICD Mapping", Description = "Decription 2", Version = 1.9f, Sources = {}, Targets = {}},
             new Project { Id = 3, Name = "ICD-10 to LOINC Mapping", Description = "Decription 3", Version = 0.8f, Sources = {}, Targets = {}},
             new Project { Id = 4, Name = "ICD-10 to SNOMED-CT Mapping", Description = "Decription 4", Version = 2.8f, Sources = {}, Targets = {}}
        };
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
