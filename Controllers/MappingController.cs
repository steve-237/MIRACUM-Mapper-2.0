using Microsoft.AspNetCore.Mvc;
using MIRACUM_Mapper.Models;

namespace MIRACUM_Mapper.Controllers
{
    public class MappingController : Controller
    {
        private List<Project> elements = new List<Project>
        {
             new Project { Id = 1, Name = "Internal LabCode to LOINC Mapping", Description ="description id1", Version = 1.0f, Sources = {}, Targets = {}, DisplayMappingEquivalence= true, DisplayStatus=false},
             new Project { Id = 2, Name = "SNOMED to ICD Mapping", Description ="description id2",Version = 1.9f, Sources = {}, Targets = {}, DisplayMappingEquivalence= true, DisplayStatus=true},
             new Project { Id = 3, Name = "ICD-10 to LOINC Mapping", Description ="description id3",Version = 0.8f, Sources = {}, Targets = {}, DisplayMappingEquivalence= false, DisplayStatus=false},
             new Project { Id = 4, Name = "ICD-10 to SNOMED-CT Mapping",Description ="description id4", Version = 2.8f, Sources = {}, Targets = {}, DisplayMappingEquivalence= false, DisplayStatus=true}
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
