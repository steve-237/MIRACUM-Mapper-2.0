using MIRACUM_Mapper.Models;

namespace MIRACUM_Mapper.db
{
    public static class db
    {
        public static List<Project> elements = new List<Project>
        {
            new Project
            {
                Id = 0,
                Name = "Creative Mapping Endeavor",
                Version = 1.09f,
                Description = "Exploration of Complex Mapping between LOINC, SNOMED-CT, and UMLS to Other Terminologies",
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
                                Name = "LOINC",
                                Concept = new Concept
                                {
                                    Code = "12345-6",
                                    Meaning = "Serum creatinine"
                                }
                            },
                            new Source
                            {
                                Name = "SNOMED-CT",
                                Concept = new Concept
                                {
                                    Code = "7890123",
                                    Meaning = "Hypertension"
                                }
                            },
                            new Source
                            {
                                Name = "UMLS",
                                Concept = new Concept
                                {
                                    Code = "C0012345",
                                    Meaning = "Renal dysfunction"
                                }
                            }
                        },
                        Targets = new List<Target>
                        {
                            new Target
                            {
                                Name = "Other Terminologies",
                                Concept = new Concept
                                {
                                    Code = "T987654",
                                    Meaning = "Kidney function abnormalities"
                                }
                            },
                            new Target
                            {
                                Name = "Other Terminologies",
                                Concept = new Concept
                                {
                                    Code = "T567890",
                                    Meaning = "High blood pressure"
                                }
                            }
                        },
                        Equivalence = "Equivalent",
                        Status = "Active",
                        Comment = "Mapping verified"
                    },
                }
            },
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
                                Name = "ICD-10 1",
                                Concept = new Concept
                                {
                                    Code = "A01.1",
                                    Meaning = "Intestinal infection by E. coli"
                                }
                            },
                            new Source
                            {
                                Name = "ICD-10 2",
                                Concept = new Concept
                                {
                                    Code = "B02.2",
                                    Meaning = "Influenza due to A(H1N1) virus"
                                }
                            },
                            new Source
                            {
                                Name = "ICD-10 3",
                                Concept = new Concept
                                {
                                    Code = "C03.3",
                                    Meaning = "Malignant neoplasm of colon"
                                }
                            }
                        },
                        Targets = new List<Target>
                        {
                            new Target
                            {
                                Name = "UMLS 1",
                                Concept = new Concept
                                {
                                    Code = "C0001234",
                                    Meaning = "Bacterial infection of intestine"
                                }
                            },
                            new Target
                            {
                                Name = "UMLS 2",
                                Concept = new Concept
                                {
                                    Code = "C0005678",
                                    Meaning = "Influenza A(H1N1)"
                                }
                            },
                            new Target
                            {
                                Name = "UMLS 3",
                                Concept = new Concept
                                {
                                    Code = "C0009876",
                                    Meaning = "Colon carcinoma"
                                }
                            }
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
                                Name = "ICD-10 1",
                                Concept = new Concept
                                {
                                    Code = "D04.4",
                                    Meaning = "Nosebleed"
                                }
                            },
                            new Source
                            {
                                Name = "ICD-10 2",
                                Concept = new Concept
                                {
                                    Code = "E05.5",
                                    Meaning = "Hypothyroidism"
                                }
                            },
                            new Source
                            {
                                Name = "ICD-10 3",
                                Concept = new Concept
                                {
                                    Code = "F06.6",
                                    Meaning = "Mental disorder due to brain injury"
                                }
                            }
                        },
                        Targets = new List<Target>
                        {
                            new Target
                            {
                                Name = "UMLS 1",
                                Concept = new Concept
                                {
                                    Code = "C0012345",
                                    Meaning = "Nosebleed"
                                }
                            },
                            new Target
                            {
                                Name = "UMLS 2",
                                Concept = new Concept
                                {
                                    Code = "C0056789",
                                    Meaning = "Hypothyroidism"
                                }
                            },
                            new Target
                            {
                                Name = "UMLS 3",
                                Concept = new Concept
                                {
                                    Code = "C0098765",
                                    Meaning = "Mental disorder due to brain injury"
                                }
                            }
                        },
                        Equivalence = "Not Equivalent",
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
                                Name = "ICD-10 1",
                                Concept = new Concept
                                {
                                    Code = "G07.7",
                                    Meaning = "Intracranial abscess and granuloma"
                                }
                            },
                            new Source
                            {
                                Name = "ICD-10 2",
                                Concept = new Concept
                                {
                                    Code = "H08.8",
                                    Meaning = "Disorders of eyelid, lacrimal system, and orbit in diseases classified elsewhere"
                                }
                            },
                            new Source
                            {
                                Name = "ICD-10 3",
                                Concept = new Concept
                                {
                                    Code = "I09.9",
                                    Meaning = "Rheumatic heart disease, unspecified"
                                }
                            }
                        },
                        Targets = new List<Target>
                        {
                            new Target
                            {
                                Name = "UMLS 1",
                                Concept = new Concept
                                {
                                    Code = "C0123456",
                                    Meaning = "Intracranial abscess"
                                }
                            },
                            new Target
                            {
                                Name = "UMLS 2",
                                Concept = new Concept
                                {
                                    Code = "C0456789",
                                    Meaning = "Eyelid disorders"
                                }
                            },
                            new Target
                            {
                                Name = "UMLS 3",
                                Concept = new Concept
                                {
                                    Code = "C0987654",
                                    Meaning = "Unspecified rheumatic heart disease"
                                }
                            },
                        },
                        Equivalence = "Not Equivalent",
                        Status = "Inactive",
                        Comment = "Mapping not checked"
                    },
                    new Mapping
                    {
                        Id = 4,
                        Sources = new List<Source>
                        {
                            new Source
                            {
                                Name = "ICD-10 1",
                                Concept = new Concept
                                {
                                    Code = "J10.0",
                                    Meaning = "Influenza due to other identified influenza virus"
                                }
                            },
                            new Source
                            {
                                Name = "ICD-10 2",
                                Concept = new Concept
                                {
                                    Code = "K20.9",
                                    Meaning = "Gastro-esophageal reflux disease without esophagitis"
                                }
                            },
                            new Source
                            {
                                Name = "ICD-10 3",
                                Concept = new Concept
                                {
                                    Code = "L30.9",
                                    Meaning = "Dermatitis, unspecified"
                                }
                            }
                        },
                        Targets = new List<Target>
                        {
                            new Target
                            {
                                Name = "UMLS 1",
                                Concept = new Concept
                                {
                                    Code = "C0222222",
                                    Meaning = "Influenza due to influenza A virus"
                                }
                            },
                            new Target
                            {
                                Name = "UMLS 2",
                                Concept = new Concept
                                {
                                    Code = "C0333333",
                                    Meaning = "Gastroesophageal reflux disease"
                                }
                            },
                            new Target
                            {
                                Name = "UMLS 3",
                                Concept = new Concept
                                {
                                    Code = "C0444444",
                                    Meaning = "Unspecified dermatitis"
                                }
                            },
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
                                Name = "ICD-10 1",
                                Concept = new Concept
                                {
                                    Code = "M12.3",
                                    Meaning = "Traumatic arthropathy of the elbow"
                                }
                            },
                            new Source
                            {
                                Name = "ICD-10 2",
                                Concept = new Concept
                                {
                                    Code = "N12.0",
                                    Meaning = "Tubulo-interstitial nephritis"
                                }
                            },
                            new Source
                            {
                                Name = "ICD-10 3",
                                Concept = new Concept
                                {
                                    Code = "O12.4",
                                    Meaning = "Gestational edema"
                                }
                            }
                        },
                        Targets = new List<Target>
                        {
                            new Target
                            {
                                Name = "UMLS 1",
                                Concept = new Concept
                                {
                                    Code = "C0555555",
                                    Meaning = "Elbow arthropathy due to trauma"
                                }
                            },
                            new Target
                            {
                                Name = "UMLS 2",
                                Concept = new Concept
                                {
                                    Code = "C0666666",
                                    Meaning = "Tubulointerstitial nephritis"
                                }
                            },
                            new Target
                            {
                                Name = "UMLS 3",
                                Concept = new Concept
                                {
                                    Code = "C0777777",
                                    Meaning = "Edema of pregnancy"
                                }
                            },
                        },
                        Equivalence = "Equivalent",
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
