namespace MIRACUM_Mapper.ModelViews
{
    public class MappingRowViewModel
    {
        public int Id { get; set; }
        public bool IsSelected { get; set; }
        public List<SourceViewModel> Sources { get; set; }
        public List<TargetViewModel> Targets { get; set; }
        public string Equivalence { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
    }
}
