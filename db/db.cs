using MIRACUM_Mapper.Models;

namespace MIRACUM_Mapper.db
{
    public static class db
    {
        public static List<Project> elements = new List<Project>
        {
            new Project
            {
                Id = 1,
                Name = "Project 1",
                Version = 1.01f,
                Description = "Mapping from ICD-10 to UMLS",
                DisplayMappingEquivalence = true,
                DisplayStatus = true,
                Mappings = new List<Mapping>
                {
                    new Mapping
                    {
                        Id = 1,
                        Sources = new List<Source>
                        {
                            new Source
                            {
                                Name = "ICD-10",
                                Concept = new Concept
                                {
                                    Code = "A00.1",
                                    Meaning = "Cholera due to Vibrio cholerae 01, biovar eltor"
                                }
                            }
                        },
                        Targets = new List<Target>
                        {
                            new Target
                            {
                                Name = "UMLS",
                                Concept = new Concept
                                {
                                    Code = "C0008031",
                                    Meaning = "Cholera"
                                }
                            },
                        },
                        Equivalence = "Equivalent",
                        Status = "Active",
                        Comment = "Mapping checked"
                    },
                    new Mapping
                    {
                        Id = 2,
                        Sources = new List<Source>
                        {
                            new Source
                            {
                                Name = "ICD-10",
                                Concept = new Concept
                                {
                                    Code = "A00.2",
                                    Meaning = "Cholera due to Vibrio cholerae 01, biovar classic"
                                }
                            }
                        },
                        Targets = new List<Target>
                        {
                            new Target
                            {
                                Name = "UMLS",
                                Concept = new Concept
                                {
                                    Code = "C0008032",
                                    Meaning = "Cholera classic"
                                }
                            },
                        },
                        Equivalence = "Equivalent",
                        Status = "Inactive",
                        Comment = "Mapping not checked"
                    },
                    new Mapping
                    {
                        Id = 3,
                        Sources = new List<Source>
                        {
                            new Source
                            {
                                Name = "ICD-10",
                                Concept = new Concept
                                {
                                    Code = "A00.3",
                                    Meaning = "Cholera due to Vibrio cholerae 01, biovar test"
                                }
                            }
                        },
                        Targets = new List<Target>
                        {
                            new Target
                            {
                                Name = "UMLS",
                                Concept = new Concept
                                {
                                    Code = "C0008033",
                                    Meaning = "Cholera test"
                                }
                            },
                        },
                        Equivalence = "Not Equivalent",
                        Status = "Active",
                        Comment = "Mapping verified"
                    }
                }
            },
            new Project
            {
                Id = 2,
                Name = "Project 2",
                Version = 0.05f,
                Description = "Mapping from SNOMED-CT to ICD-10",
                DisplayMappingEquivalence = false,
                DisplayStatus = true,
                Mappings = new List<Mapping>
                {
                    new Mapping
                    {
                        Id = 1,
                        Sources = new List<Source>
                        {
                            new Source
                            {
                                Name = "SNOMED-CT",
                                Concept = new Concept
                                {
                                    Code = "123456789",
                                    Meaning = "Hypertension"
                                }
                            }
                        },
                        Targets = new List<Target>
                        {
                            new Target
                            {
                                Name = "ICD-10",
                                Concept = new Concept
                                {
                                    Code = "I10",
                                    Meaning = "Essential hypertension"
                                }
                            }
                        },
                        Equivalence = "Equivalent",
                        Status = "Active",
                        Comment = "Mapping verified"
                    },
                    new Mapping
                    {
                        Id = 2,
                        Sources = new List<Source>
                        {
                            new Source
                            {
                                Name = "SNOMED-CT",
                                Concept = new Concept
                                {
                                    Code = "987654321",
                                    Meaning = "Diabetes"
                                }
                            }
                        },
                        Targets = new List<Target>
                        {
                            new Target
                            {
                                Name = "ICD-10",
                                Concept = new Concept
                                {
                                    Code = "E11",
                                    Meaning = "Type 2 diabetes mellitus"
                                }
                            }
                        },
                        Equivalence = "Equivalent",
                        Status = "Active",
                        Comment = "Mapping checked"
                    },
                    new Mapping
                    {
                        Id = 3,
                        Sources = new List<Source>
                        {
                            new Source
                            {
                                Name = "SNOMED-CT",
                                Concept = new Concept
                                {
                                    Code = "543210",
                                    Meaning = "Cataract"
                                }
                            }
                        },
                        Targets = new List<Target>
                        {
                            new Target
                            {
                                Name = "ICD-10",
                                Concept = new Concept
                                {
                                    Code = "H25.9",
                                    Meaning = "Unspecified age-related cataract"
                                }
                            }
                        },
                        Equivalence = "Equivalent",
                        Status = "Active",
                        Comment = "Mapping checked"
                    },
                    new Mapping
                    {
                        Id = 4,
                        Sources = new List<Source>
                        {
                            new Source
                            {
                                Name = "SNOMED-CT",
                                Concept = new Concept
                                {
                                    Code = "123123",
                                    Meaning = "Hypothyroidism"
                                }
                            }
                        },
                        Targets = new List<Target>
                        {
                            new Target
                            {
                                Name = "ICD-10",
                                Concept = new Concept
                                {
                                    Code = "E03.9",
                                    Meaning = "Hypothyroidism, unspecified"
                                }
                            }
                        },
                        Equivalence = "Equivalent",
                        Status = "Active",
                        Comment = "Mapping checked"
                    },
                    new Mapping
                    {
                        Id = 5,
                        Sources = new List<Source>
                        {
                            new Source
                            {
                                Name = "SNOMED-CT",
                                Concept = new Concept
                                {
                                    Code = "567890",
                                    Meaning = "Asthma"
                                }
                            }
                        },
                        Targets = new List<Target>
                        {
                            new Target
                            {
                                Name = "ICD-10",
                                Concept = new Concept
                                {
                                    Code = "J45.909",
                                    Meaning = "Unspecified asthma, uncomplicated"
                                }
                            }
                        },
                        Equivalence = "Equivalent",
                        Status = "Active",
                        Comment = "Mapping checked"
                    }
                }
            },
            new Project
            {
                Id = 3,
                Name = "Project 3",
                Version = 2.0f,
                Description = "Mapping from LOINC to CMT",
                DisplayMappingEquivalence = true,
                DisplayStatus = false,
                Mappings = new List<Mapping>
                {
                    new Mapping
                    {
                        Id = 1,
                        Sources = new List<Source>
                        {
                            new Source
                            {
                                Name = "LOINC",
                                Concept = new Concept
                                {
                                    Code = "12345-6",
                                    Meaning = "Blood pressure"
                                }
                            }
                        },
                        Targets = new List<Target>
                        {
                            new Target
                            {
                                Name = "CMT",
                                Concept = new Concept
                                {
                                    Code = "7890",
                                    Meaning = "Hypertension"
                                }
                            }
                        },
                        Equivalence = "Equivalent",
                        Status = "--",
                        Comment = "Mapping en cours de validation"
                    }
                }
            },
            new Project
            {
                Id = 4,
                Name = "Project 4",
                Version = 1.5f,
                Description = "Mapping from ICD-11 to MeSH",
                DisplayMappingEquivalence = false,
                DisplayStatus = false,
                Mappings = new List<Mapping>
                {
                    new Mapping
                    {
                        Id = 1,
                        Sources = new List<Source>
                        {
                            new Source
                            {
                                Name = "ICD-11",
                                Concept = new Concept
                                {
                                    Code = "A10.1",
                                    Meaning = "Type 2 diabetes mellitus"
                                }
                            }
                        },
                        Targets = new List<Target>
                        {
                            new Target
                            {
                                Name = "MeSH",
                                Concept = new Concept
                                {
                                    Code = "D003924",
                                    Meaning = "Diabetes Mellitus, Type 2"
                                }
                            }
                        },
                        Equivalence = "--",
                        Status = "--",
                        Comment = "new mapping"
                    }
                }
            },
            new Project
            {
                Id = 5,
                Name = "Project 5",
                Version = 2.2f,
                Description = "Mapping from MeSH to UMLS",
                DisplayMappingEquivalence = true,
                DisplayStatus = false,
                Mappings = new List<Mapping>
                {
                    new Mapping
                    {
                        Id = 1,
                        Sources = new List<Source>
                        {
                            new Source
                            {
                                Name = "MeSH",
                                Concept = new Concept
                                {
                                    Code = "D009765",
                                    Meaning = "Hypertension"
                                }
                            }
                        },
                        Targets = new List<Target>
                        {
                            new Target
                            {
                                Name = "UMLS",
                                Concept = new Concept
                                {
                                    Code = "C0020538",
                                    Meaning = "Hypertension"
                                }
                            }
                        },
                        Equivalence = "Equivalent",
                        Status = "Actif",
                        Comment = "Mapping valid"
                    }
                }
            }
        };
    }
}
