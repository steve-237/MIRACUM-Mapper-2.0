namespace MIRACUM_Mapper.ModelViews
{
    public class MappingViewModel
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public List<MappingRowViewModel> MappingRows { get; set; }
        public bool DisplayStatus { get; set; }
        public bool DisplayMappingEquivalence { get; set; }
    }
}
