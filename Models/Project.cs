namespace MIRACUM_Mapper.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Version { get; set; }
        public string Description { get; set; }
        public List<Source>? Sources { get; set; }
        public List<Target>? Targets { get; set; }
    }
}
