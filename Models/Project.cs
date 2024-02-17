using System.ComponentModel.DataAnnotations;

namespace MIRACUM_Mapper.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Version is required")]
        public float Version { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        public bool DisplayMappingEquivalence { get; set; }
        public bool DisplayStatus { get; set; }

        public List<Mapping> Mappings { get; set; }

        public Project()
        {
            Mappings = new List<Mapping>();
        }
    }
}
