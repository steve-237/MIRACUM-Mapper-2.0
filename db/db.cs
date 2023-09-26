using MIRACUM_Mapper.Models;

namespace MIRACUM_Mapper.db
{
    public static class db
    {
        public static List<Source> sources = new List<Source>
        {
            new Source { Id = 1, Name = "ICD-10", Description = "Description source 1", Url = "Url 1"},
            new Source { Id = 2, Name = "UMLS", Description = "Description source 2", Url = "Url 2"},
            new Source { Id = 3, Name = "LONIC", Description = "Description source 3", Url = "Url 3"},
        };

        public static List<Target> targets = new List<Target>
        {
            new Target { Id = 1, Name = "ICD-10 target", Description = "Description target 1", Url = "Url 1"},
            new Target { Id = 2, Name = "UMLS target", Description = "Description target 2", Url = "Url 2"},
            new Target { Id = 3, Name = "LONIC target", Description = "Description target 3", Url = "Url 3"},
        };

        public static List<Source> sources1 = new List<Source>
        {
            new Source { Id = 1, Name = "ICD-11", Description = "Description source 1", Url = "Url 1"}
        };

        public static List<Target> targets1 = new List<Target>
        {
            new Target { Id = 1, Name = "UMLS target", Description = "Description target 1", Url = "Url 1"}
        };

        public static List<Project> elements = new List<Project>
        {
             new Project { Id = 1, Name = "Internal LabCode to LOINC Mapping", Description ="description id1", Version = 1.0f, Sources = sources, Targets = targets, DisplayMappingEquivalence= true, DisplayStatus=false},
             new Project { Id = 2, Name = "SNOMED to ICD Mapping", Description ="description id2",Version = 1.9f, Sources = sources, Targets = targets, DisplayMappingEquivalence= true, DisplayStatus=true},
             new Project { Id = 3, Name = "ICD-10 to LOINC Mapping", Description ="description id3",Version = 0.8f, Sources = sources, Targets = targets, DisplayMappingEquivalence= false, DisplayStatus=false},
             new Project { Id = 4, Name = "ICD-10 to SNOMED-CT Mapping",Description ="description id4", Version = 2.8f, Sources = sources, Targets = targets, DisplayMappingEquivalence= false, DisplayStatus=true},
             new Project { Id = 5, Name = "ICD-11 to UMLS Mapping",Description ="description id5", Version = 5.8f, Sources = sources1, Targets = targets1, DisplayMappingEquivalence= false, DisplayStatus=true}
        };
    }
}
