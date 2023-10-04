namespace MIRACUM_Mapper.Models
{
    public class Mapping
    {
        public int Id { get; set; }
        public List<Source> Sources { get; set; }
        public List<Target> Targets { get; set; }
        public string Equivalence { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
    }
}
