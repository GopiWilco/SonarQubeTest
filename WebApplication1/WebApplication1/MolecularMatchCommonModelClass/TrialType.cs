using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.MolecularMatchCommonModelClass
{
    public class ListForFilters
    {
        public List<FilterList> IList = new List<FilterList>();

        public List<FilterList> GetTrialTypeList()
        {
            return new List<FilterList>() {
                new FilterList {
                    Name = "Interventional",
                    Value = "Interventional",
                    Id = 0
                },
                new FilterList {
                    Name = "Observational",
                    Value = "Observational",
                    Id = 1
                },
                new FilterList {
                    Name = "Retrospective",
                    Value = "Retrospective",
                    Id = 2
                },
                new FilterList {
                    Name = "Pediatric",
                    Value = "Pediatric",
                    Id = 3
                },
                new FilterList {
                    Name = "Randomized",
                    Value = "Randomized",
                    Id = 4
                },
                new FilterList {
                    Name = "Nonrandomized",
                    Value = "Nonrandomized",
                    Id = 5
                },
                new FilterList {
                    Name = "Cancer Prevention",
                    Value = "Cancer Prevention",
                    Id = 6
                },
                new FilterList {
                    Name = "Cancer Screening",
                    Value = "Cancer Screening",
                    Id = 7
                },
                new FilterList {
                    Name = "Palliative care",
                    Value = "Palliative care",
                    Id = 8
                },
                new FilterList {
                    Name = "Pain Management",
                    Value = "Pain Management",
                    Id = 9
                },
                new FilterList {
                    Name = "Alternative Therapy",
                    Value = "Alternative Therapy",
                    Id = 10
                },
                new FilterList {
                    Name = "Survivors",
                    Value = "Survivors",
                    Id = 11
                },
                new FilterList {
                    Name = "Combination Therapy",
                    Value = "Combination Therapy",
                    Id = 12
                },
                new FilterList {
                    Name = "Salvage Therapy",
                    Value = "Salvage Therapy",
                    Id = 13
                },
                new FilterList {
                    Name = "Prospective",
                    Value = "Prospective",
                    Id = 14
                }
            };

        }

        public List<FilterList> GetTrialStatusList()
        {
            return new List<FilterList>() {
                new FilterList {
                    Name = "Enrolling",
                    Value = "Enrolling",
                    Id = 0
                },
                new FilterList {
                    Name = "Not Enrolling",
                    Value = "Not Enrolling",
                    Id = 1
                },
                new FilterList {
                    Name = "Closed",
                    Value = "Closed",
                    Id = 2
                },
                new FilterList {
                    Name = "Unknown",
                    Value = "Unknown",
                    Id = 3
                }
            };
        }

        public List<FilterList> GetConditionList()
        {
            return new List<FilterList>() {
                new FilterList {
                    Name = "Breast cancer",
                    Value = "Breast cancer",
                    Id = 0
                },
                new FilterList {
                    Name = "Infection",
                    Value = "Infection",
                    Id = 1
                },
                new FilterList {
                    Name = "Lung cancer",
                    Value = "Lung cancer",
                    Id = 2
                },
                new FilterList {
                    Name = "Depressive disorder",
                    Value = "Depressive disorder",
                    Id = 3
                },
                new FilterList {
                    Name = "Severe acute respiratory coronavirus syndrome 2",
                    Value = "Severe acute respiratory coronavirus syndrome 2",
                    Id = 4
                },
                new FilterList {
                    Name = "Traumatic AND/OR non-traumatic injury",
                    Value = "Traumatic AND/OR non-traumatic injury",
                    Id = 5
                },
                new FilterList {
                    Name = "Stroke",
                    Value = "Stroke",
                    Id = 6
                },
                new FilterList {
                    Name = "Leukemia",
                    Value = "Leukemia",
                    Id = 7
                },
                new FilterList {
                    Name = "NSCLC - Non-small cell lung cancer",
                    Value = "NSCLC - Non-small cell lung cancer",
                    Id = 8
                },
                new FilterList {
                    Name = "Cutaneous mastocytosis",
                    Value = "Cutaneous mastocytosis",
                    Id = 9
                },
                new FilterList {
                    Name = "HER2 negative breast cancer",
                    Value = "HER2 negative breast cancer",
                    Id = 10
                },
                new FilterList {
                    Name = "Wound",
                    Value = "Wound",
                    Id = 11
                },
                new FilterList {
                    Name = "Anxiety disorder",
                    Value = "Anxiety disorder",
                    Id = 12
                },
                new FilterList {
                    Name = "Hormone receptor positive malignant neoplasm of breast",
                    Value = "Hormone receptor positive malignant neoplasm of breast",
                    Id = 13
                },
                new FilterList {
                    Name = "Alzheimer's disease",
                    Value = "Alzheimer's disease",
                    Id = 14
                },
                new FilterList {
                    Name = "Non-small cell lung cancer, positive for epidermal growth factor receptor expression",
                    Value = "Non-small cell lung cancer, positive for epidermal growth factor receptor expression",
                    Id = 15
                },
                new FilterList {
                    Name = "BRAF mutated melanoma",
                    Value = "BRAF mutated melanoma",
                    Id = 16
                },
                new FilterList {
                    Name = "Philadelphia chromosome positive chronic myelogenous leukemia",
                    Value = "Philadelphia chromosome positive chronic myelogenous leukemia",
                    Id = 17
                },
                new FilterList {
                    Name = "BRAF mutated colorectal cancer",
                    Value = "BRAF mutated colorectal cancer",
                    Id = 18
                },
                new FilterList {
                    Name = "FLT3 AML",
                    Value = "FLT3 AML",
                    Id = 19
                },
                new FilterList {
                    Name = "Philadelphia chromosome-positive acute lymphoblastic leukemia",
                    Value = "Philadelphia chromosome-positive acute lymphoblastic leukemia",
                    Id = 20
                }
            };
        }

        public List<FilterList> GetGeneList()
        {
            return new List<FilterList>() {
                new FilterList {
                    Name = "IL6",
                    Value = "IL6",
                    Id = 0
                },
                new FilterList {
                    Name = "PD - L1",
                    Value = "PD - L1",
                    Id = 1
                },
                new FilterList {
                    Name = "PD - 1",
                    Value = "PD - 1",
                    Id = 2
                },
                new FilterList {
                    Name = "TNF",
                    Value = "TNF",
                    Id = 3
                },
                new FilterList {
                    Name = "ACAT1",
                    Value = "ACAT1",
                    Id = 4
                },
                new FilterList {
                    Name = "ER",
                    Value = "ER",
                    Id = 5
                },
                new FilterList {
                    Name = "CD4",
                    Value = "CD4",
                    Id = 6
                },
                new FilterList {
                    Name = "Wild - Type ERBB2",
                    Value = "Wild - Type ERBB2",
                    Id = 7
                },
                new FilterList {
                    Name = "EGFR",
                    Value = "EGFR",
                    Id = 8
                },
                new FilterList {
                    Name = "ERBB2",
                    Value = "ERBB2",
                    Id = 9
                },
                new FilterList {
                    Name = "HSD11B1",
                    Value = "HSD11B1",
                    Id = 10
                },
                new FilterList {
                    Name = "ADA",
                    Value = "ADA",
                    Id = 11
                },
                new FilterList {
                    Name = "THOP1",
                    Value = "THOP1",
                    Id = 12
                },
                new FilterList {
                    Name = "PTPRF",
                    Value = "PTPRF",
                    Id = 13
                },
                new FilterList {
                    Name = "EPO",
                    Value = "EPO",
                    Id = 14
                },
                new FilterList {
                    Name = "HR",
                    Value = "HR",
                    Id = 15
                },
                new FilterList {
                    Name = "PGR",
                    Value = "PGR",
                    Id = 16
                },
                new FilterList {
                    Name = "CD20",
                    Value = "CD20",
                    Id = 17
                },
                new FilterList {
                    Name = "ACE",
                    Value = "ACE",
                    Id = 18
                },
                new FilterList {
                    Name = "BDNF",
                    Value = "BDNF",
                    Id = 19
                },
                new FilterList {
                    Name = "NPPB",
                    Value = "NPPB",
                    Id = 20
                },

            };
        }

        public List<FilterList> GetMutationList()
        {
            return new List<FilterList>() {
                new FilterList {
                    Name = "ERBB2 Los",
                    Value = "ERBB2 Los",
                    Id = 0
                },
                new FilterList {
                    Name = "ER Negative",
                    Value = "ER Negative",
                    Id = 1
                },
                new FilterList {
                    Name = "PR Negative",
                    Value = "PR Negative",
                    Id = 2
                },
                new FilterList {
                    Name = "ER/PR Negative",
                    Value = "ER/PR Negative",
                    Id = 3
                },
                new FilterList {
                    Name = "Castration resistant",
                    Value = "Castration resistant",
                    Id = 4
                },
                new FilterList {
                    Name = "ER/PR positive",
                    Value = "ER/PR positive",
                    Id = 5
                },
                new FilterList {
                    Name = "BCR-ABL",
                    Value = "BCR-ABL",
                    Id = 6
                },
                new FilterList {
                    Name = "Microsatellite instability",
                    Value = "Microsatellite instability",
                    Id = 7
                },
                new FilterList {
                    Name = "PSA positive",
                    Value = "PSA positive",
                    Id = 8
                },
                new FilterList {
                    Name = "Microsatellite stability",
                    Value = "Microsatellite stability",
                    Id = 9
                },
                new FilterList {
                    Name = "HLA-A-ROS1",
                    Value = "HLA-A-ROS1",
                    Id = 10
                },
                new FilterList {
                    Name = "EGFR L858R",
                    Value = "EGFR L858R",
                    Id = 11
                },
                new FilterList {
                    Name = "ERBB2 Amplification",
                    Value = "ERBB2 Amplification",
                    Id = 12
                },
                new FilterList {
                    Name = "CD20 positive",
                    Value = "CD20 positive",
                    Id = 13
                },
                new FilterList {
                    Name = "Cancer Antigen 19-9",
                    Value = "Cancer Antigen 19-9",
                    Id = 14
                },
                new FilterList {
                    Name = "EGFR T790M",
                    Value = "EGFR T790M",
                    Id = 15
                },
                new FilterList {
                    Name = "ABL1 F317C",
                    Value = "ABL1 F317C",
                    Id = 16
                },
                new FilterList {
                    Name = "ABL1 F317I",
                    Value = "ABL1 F317I",
                    Id = 17
                },
                new FilterList {
                    Name = "ABL1 F317V",
                    Value = "ABL1 F317V",
                    Id = 18
                },

            };
        }

        public List<FilterList> GetDrugList()
        {
            return new List<FilterList>() {
                new FilterList {
                    Name = "Pargeverine",
                    Value = "Pargeverine",
                    Id = 0
                },
                new FilterList {
                    Name = "Cyclophosphamide",
                    Value = "Cyclophosphamide",
                    Id = 1
                },
                new FilterList {
                    Name = "Paclitaxel",
                    Value = "Paclitaxel",
                    Id = 2
                },
                new FilterList {
                    Name = "Cisplatin",
                    Value = "Cisplatin",
                    Id = 3
                },
                new FilterList {
                    Name = "Dexamethasone",
                    Value = "Dexamethasone",
                    Id = 4
                },
                new FilterList {
                    Name = "Nivolumab",
                    Value = "Nivolumab",
                    Id = 5
                },
                new FilterList {
                    Name = "Pembrolizumab",
                    Value = "Pembrolizumab",
                    Id = 6
                },
                new FilterList {
                    Name = "Carboplatin",
                    Value = "Carboplatin",
                    Id = 7
                },
                new FilterList {
                    Name = "Diethyltoluamide",
                    Value = "Diethyltoluamide",
                    Id = 8
                },
                new FilterList {
                    Name = "Oxaliplatin",
                    Value = "Oxaliplatin",
                    Id = 9
                },
                new FilterList {
                    Name = "Afatinib",
                    Value = "Afatinib",
                    Id = 10
                },
                new FilterList {
                    Name = "Erlotinib",
                    Value = "Erlotinib",
                    Id = 11
                },
                new FilterList {
                    Name = "Gefitinib",
                    Value = "Gefitinib",
                    Id = 12
                },
                new FilterList {
                    Name = "Icotinib",
                    Value = "Icotinib",
                    Id = 12
                },

            };
        }

        public List<FilterList> GetDrugClassList()
        {
            return new List<FilterList>() {
                new FilterList {
                    Name = "Antibodies",
                    Value = "Antibodies",
                    Id = 0
                },
                new FilterList {
                    Name = "Food",
                    Value = "Food",
                    Id = 1
                },
                new FilterList {
                    Name = "Glucose",
                    Value = "Glucose",
                    Id = 2
                },
                new FilterList {
                    Name = "Immunotherapy",
                    Value = "Immunotherapy",
                    Id = 3
                },
                new FilterList {
                    Name = "Inflammation",
                    Value = "Inflammation",
                    Id = 4
                },
                new FilterList {
                    Name = "Adjuvant",
                    Value = "Adjuvant",
                    Id = 5
                },
                new FilterList {
                    Name = "Biomarkers",
                    Value = "Biomarkers",
                    Id = 6
                },
                new FilterList {
                    Name = "Antibodies, Monoclonal",
                    Value = "Antibodies, Monoclonal",
                    Id = 7
                },
                new FilterList {
                    Name = "Serum",
                    Value = "Serum",
                    Id = 8
                },
                new FilterList {
                    Name = "Sodium",
                    Value = "Sodium",
                    Id = 9
                }
            };
        }

        public List<FilterList> GetResistanceList()
        {
            return new List<FilterList>() {
                new FilterList {
                    Name = "Insulin",
                    Value = "Insulin",
                    Id = 0
                },
                new FilterList {
                    Name = "Platinum",
                    Value = "Platinum",
                    Id = 1
                },
                new FilterList {
                    Name = "Adjuvant",
                    Value = "Adjuvant",
                    Id = 2
                },
                new FilterList {
                    Name = "Nivolumab",
                    Value = "Nivolumab",
                    Id = 3
                },
                new FilterList {
                    Name = "Gefitinib",
                    Value = "Gefitinib",
                    Id = 4
                },
                new FilterList {
                    Name = "Afatinib",
                    Value = "Afatinib",
                    Id = 5
                },
                new FilterList {
                    Name = "Erlotinib",
                    Value = "Erlotinib",
                    Id = 6
                },
                new FilterList {
                    Name = "Pembrolizumab",
                    Value = "Pembrolizumab",
                    Id = 7
                },
                new FilterList {
                    Name = "Crizotinib",
                    Value = "Crizotinib",
                    Id = 8
                },
                new FilterList {
                    Name = "PDCD1 inhibitor",
                    Value = "PDCD1 inhibitor",
                    Id = 9
                },
                new FilterList {
                    Name = "CD274 inhibitor",
                    Value = "CD274 inhibitor",
                    Id = 10
                },
            };
        }

        public List<FilterList> GetInstitutionList()
        {
            return new List<FilterList>() {
                new FilterList {
                    Name = "National Institutes of Health",
                    Value = "National Institutes of Health",
                    Id = 0
                },
                new FilterList {
                    Name = "National Cancer Institute",
                    Value = "National Cancer Institute",
                    Id = 1
                },
                new FilterList {
                    Name = "University of California",
                    Value = "University of California",
                    Id = 2
                },
                new FilterList {
                    Name = "Mayo Clinic",
                    Value = "Mayo Clinic",
                    Id = 3
                },
                new FilterList {
                    Name = "MD Anderson Cancer Center",
                    Value = "MD Anderson Cancer Center",
                    Id = 4
                },
                new FilterList {
                    Name = "University of Texas MD Anderson Cancer Center",
                    Value = "University of Texas MD Anderson Cancer Center",
                    Id = 5
                },
                new FilterList {
                    Name = "Johns Hopkins University",
                    Value = "Johns Hopkins University",
                    Id = 6
                },
                new FilterList {
                    Name = "Washington University in St. Louis",
                    Value = "Washington University in St. Louis",
                    Id = 7
                },
                new FilterList {
                    Name = "Sun Yat sen University",
                    Value = "Sun Yat sen University",
                    Id = 8
                },
                new FilterList {
                    Name = "Massachusetts General Hospital",
                    Value = "Massachusetts General Hospital",
                    Id = 9
                },
            };
        }

        public List<FilterList> GetPhaseList()
        {
            return new List<FilterList>() {
                new FilterList {
                    Name = "Phase 0",
                    Value = "Phase 0",
                    Id = 0
                },
                new FilterList {
                    Name = "Phase 1",
                    Value = "Phase 1",
                    Id = 1
                },
                new FilterList {
                    Name = "Phase 2",
                    Value = "Phase 2",
                    Id = 2
                },
                new FilterList {
                    Name = "Phase 3",
                    Value = "Phase 3",
                    Id = 3
                },
                new FilterList {
                    Name = "Phase 4",
                    Value = "Phase 4",
                    Id = 4
                },
            };
        }

        public List<FilterList> GetPublicationtypeList()
        {

            return new List<FilterList>() {
                new FilterList {
                    Name = "Has abstract",
                    Value = "Has abstract",
                    Id = 0
                },
                new FilterList {
                    Name = "PUBMED Abstract",
                    Value = "PUBMED Abstract",
                    Id = 1
                },
                new FilterList {
                    Name = "In patients",
                    Value = "In patients",
                    Id = 2
                },
                new FilterList {
                    Name = "Journal Article",
                    Value = "Journal Article",
                    Id = 3
                },
                new FilterList {
                    Name = "< 3 year old",
                    Value = "< 3 year old",
                    Id = 4
                },
                new FilterList {
                    Name = "PMC citations > 0",
                    Value = "PMC citations > 0",
                    Id = 5
                },
                new FilterList {
                    Name = "ASCOMEETING Abstract",
                    Value = "ASCOMEETING Abstract",
                    Id = 6
                },
                new FilterList {
                    Name = "< 5 year old",
                    Value = "< 5 year old",
                    Id = 7
                },
                new FilterList {
                    Name = "Drug Combination",
                    Value = "Drug Combination",
                    Id = 8
                },
                new FilterList {
                    Name = "Review",
                    Value = "Review",
                    Id = 9
                }
            };
        }

        public List<FilterList> GetJournalList()
        {
            return new List<FilterList>() {
                new FilterList {
                    Name = "Clinical cancer research : an official journal of the American Association for Cancer Research",
                    Value = "Clinical cancer research : an official journal of the American Association for Cancer Research",
                    Id = 0
                },
                new FilterList {
                    Name = "Oncotarget",
                    Value = "Oncotarget",
                    Id = 1
                },
                new FilterList {
                    Name = "PloS one",
                    Value = "PloS one",
                    Id = 2
                },
                new FilterList {
                    Name = "Cancer immunology",
                    Value = "Cancer immunology",
                    Id = 3
                },
                new FilterList {
                    Name = "Journal of clinical oncology : official journal of the American Society of Clinical Oncology",
                    Value = "Journal of clinical oncology : official journal of the American Society of Clinical Oncology",
                    Id = 4
                },
                new FilterList {
                    Name = "Blood",
                    Value = "Blood",
                    Id = 5
                },
                new FilterList {
                    Name = "Frontiers in oncology",
                    Value = "Frontiers in oncology",
                    Id = 6
                },
                new FilterList {
                    Name = "Scientific reports",
                    Value = "Scientific reports",
                    Id = 7
                },
                new FilterList {
                    Name = "Leukemia & lymphoma",
                    Value = "Leukemia & lymphoma",
                    Id = 8
                }
            };
        }

        public List<FilterList> GetFindingList()
        {
            return new List<FilterList>() {
                new FilterList {
                    Name = "Is informed",
                    Value = "Is informed",
                    Id = 0
                },
                new FilterList {
                    Name = "Global Resistance Tag",
                    Value = "Global Resistance Tag",
                    Id = 1
                },
                new FilterList {
                    Name = "Willing",
                    Value = "Willing",
                    Id = 2
                },
                new FilterList {
                    Name = "Contraception",
                    Value = "Contraception",
                    Id = 3
                },
                new FilterList {
                    Name = "Pain",
                    Value = "Pain",
                    Id = 4
                },
                new FilterList {
                    Name = "Sign",
                    Value = "Sign",
                    Id = 5
                },
                new FilterList {
                    Name = "Follow-up status",
                    Value = "Follow-up status",
                    Id = 6
                },
                new FilterList {
                    Name = "Pregnant",
                    Value = "Pregnant",
                    Id = 7
                },
                new FilterList {
                    Name = "Not pregnant",
                    Value = "Not pregnant",
                    Id = 8
                },
                new FilterList {
                    Name = "Pressure",
                    Value = "Pressure",
                    Id = 9
                },
                new FilterList {
                    Name = "Birth",
                    Value = "Birth",
                    Id = 10
                },
                new FilterList {
                    Name = "Pressure",
                    Value = "Pressure",
                    Id = 9
                },
                new FilterList {
                    Name = "Malignant epithelial neoplasm",
                    Value = "Malignant epithelial neoplasm",
                    Id = 10
                },
                new FilterList {
                    Name = "Recurrent tumor",
                    Value = "Recurrent tumor",
                    Id = 11
                },
                new FilterList {
                    Name = "Finding of platelet count",
                    Value = "Finding of platelet count",
                    Id = 12
                },
                new FilterList {
                    Name = "Absence of sensation",
                    Value = "Absence of sensation",
                    Id = 13
                },
                new FilterList {
                    Name = "Stress",
                    Value = "Stress",
                    Id = 14
                },
                new FilterList {
                    Name = "Breast cancer",
                    Value = "Breast cancer",
                    Id = 15
                },
                new FilterList {
                    Name = "Infection",
                    Value = "Infection",
                    Id = 16
                },
                new FilterList {
                    Name = "Anxiety",
                    Value = "Anxiety",
                    Id = 17
                },
                new FilterList {
                    Name = "Locally advanced cancer",
                    Value = "Locally advanced cancer",
                    Id = 18
                },
                new FilterList {
                    Name = "Lung cancer",
                    Value = "Lung cancer",
                    Id = 19
                },
                new FilterList {
                    Name = "Depressive disorder",
                    Value = "Depressive disorder",
                    Id = 20
                },
                new FilterList {
                    Name = "Severe acute respiratory coronavirus syndrome 2",
                    Value = "Severe acute respiratory coronavirus syndrome 2",
                    Id = 21
                },
                new FilterList {
                    Name = "Traumatic AND/OR non-traumatic injury",
                    Value = "Traumatic AND/OR non-traumatic injury",
                    Id = 22
                },
                new FilterList {
                    Name = "Stroke",
                    Value = "Stroke",
                    Id = 23
                },
                new FilterList {
                    Name = "Leukemia",
                    Value = "Leukemia",
                    Id = 24
                },
                new FilterList {
                    Name = "NSCLC - Non-small cell lung cancer",
                    Value = "NSCLC - Non-small cell lung cancer",
                    Id = 25
                },
                new FilterList {
                    Name = "Cutaneous mastocytosis",
                    Value = "Cutaneous mastocytosis",
                    Id = 26
                },
                new FilterList {
                    Name = "HER2 negative breast cancer",
                    Value = "HER2 negative breast cancer",
                    Id = 27
                },
                new FilterList {
                    Name = "Wound",
                    Value = "Wound",
                    Id = 28
                },
                new FilterList {
                    Name = "Anxiety disorder",
                    Value = "Anxiety disorder",
                    Id = 29
                },
                new FilterList {
                    Name = "Hormone receptor positive malignant neoplasm of breast",
                    Value = "Hormone receptor positive malignant neoplasm of breast",
                    Id = 30
                },
                new FilterList {
                    Name = "Alzheimer's disease",
                    Value = "Alzheimer's disease",
                    Id = 31
                },
                new FilterList {
                    Name = "Non-small cell lung cancer, positive for epidermal growth factor receptor expression",
                    Value = "Non-small cell lung cancer, positive for epidermal growth factor receptor expression",
                    Id = 32
                },
                new FilterList {
                    Name = "BRAF mutated melanoma",
                    Value = "BRAF mutated melanoma",
                    Id = 33
                },
                new FilterList {
                    Name = "Philadelphia chromosome positive chronic myelogenous leukemia",
                    Value = "Philadelphia chromosome positive chronic myelogenous leukemia",
                    Id = 34
                },
                new FilterList {
                    Name = "Solid tumor",
                    Value = "Solid tumor",
                    Id = 35
                },
                new FilterList {
                    Name = "BRAF mutated colorectal cancer",
                    Value = "BRAF mutated colorectal cancer",
                    Id = 36
                },
                new FilterList {
                    Name = "FLT3 AML",
                    Value = "FLT3 AML",
                    Id = 37
                },
                new FilterList {
                    Name = "Philadelphia chromosome - positive acute lymphoblastic leukemia",
                    Value = "Philadelphia chromosome - positive acute lymphoblastic leukemia",
                    Id = 38
                },
            };
        }

        public List<FilterList> GetDurationList()
        {
            return new List<FilterList>() {
                new FilterList {
                    Name = "At any time",
                    Value = "anyTime",
                    Id = 0
                },
                new FilterList {
                    Name = "In the last 3 Months",
                    Value = "3M",
                    Id = 1
                },
                new FilterList {
                    Name = "In the last Month",
                    Value = "1M",
                    Id = 2
                },
                new FilterList {
                    Name = "In the last Week",
                    Value = "1W",
                    Id = 3
                },
            };
        }

        public List<FilterList> GetUSStateList()
        {

            return new List<FilterList>() {
                new FilterList {
                    Name = "Alabama",
                    Value = "Alabama",
                    Code="US",
                    Id = 0
                },
                new FilterList {
                    Name = "Alaska",
                    Value = "Alaska",
                    Code="US",
                    Id = 1
                },
                new FilterList {
                    Name = "Arizona",
                    Value = "Arizona",
                    Code="US",
                    Id = 2
                },
                new FilterList {
                    Name = "Arkansas",
                    Value = "Arkansas",
                    Code="US",
                    Id = 3
                },
                new FilterList {
                    Name = "California",
                    Value = "California",
                    Code="US",
                    Id = 4
                },
                new FilterList {
                    Name = "Colorado",
                    Value = "Colorado",
                    Code="US",
                    Id = 5
                },
                new FilterList {
                    Name = "Connecticut",
                    Value = "Connecticut",
                    Code="US",
                    Id = 6
                },
                new FilterList {
                    Name = "Delaware",
                    Value = "Delaware",
                    Code="US",
                    Id = 7
                },
                new FilterList {
                    Name = "District Of Columbia",
                    Value = "District Of Columbia",
                    Code="US",
                    Id = 8
                },
                new FilterList {
                    Name = "Florida",
                    Value = "Florida",
                    Code="US",
                    Id = 9
                },
                new FilterList {
                    Name = "Georgia",
                    Value = "Georgia",
                    Code="US",
                    Id = 10
                },
                new FilterList {
                    Name = "Hawaii",
                    Value = "Hawaii",
                    Code="US",
                    Id = 11
                },
                new FilterList {
                    Name = "Idaho",
                    Value = "Idaho",
                    Code="US",
                    Id = 12
                },
                new FilterList {
                    Name = "Illinois",
                    Value = "Illinois",
                    Code="US",
                    Id = 13
                },
                new FilterList {
                    Name = "Indiana",
                    Value = "Indiana",
                    Code="US",
                    Id = 14
                },
                new FilterList {
                    Name = "Iowa",
                    Value = "Iowa",
                    Code="US",
                    Id = 15
                },
                new FilterList {
                    Name = "Kansas",
                    Value = "Kansas",
                    Code="US",
                    Id = 16
                },
                new FilterList {
                    Name = "Kentucky",
                    Value = "Kentucky",
                    Code="US",
                    Id = 17
                },
                new FilterList {
                    Name = "Louisiana",
                    Value = "Louisiana",
                    Code="US",
                    Id = 18
                },
                new FilterList {
                    Name = "Maine",
                    Value = "Maine",
                    Code="US",
                    Id = 19
                },
                new FilterList {
                    Name = "Maryland",
                    Value = "Maryland",
                    Code="US",
                    Id = 20
                },
                new FilterList {
                    Name = "Massachusetts",
                    Value = "Massachusetts",
                    Code="US",
                    Id = 21
                },
                new FilterList {
                    Name = "Michigan",
                    Value = "Michigan",
                    Code="US",
                    Id = 22
                },
                new FilterList {
                    Name = "Minnesota",
                    Value = "Minnesota",
                    Code="US",
                    Id = 23
                },
                new FilterList {
                    Name = "Mississippi",
                    Value = "Mississippi",
                    Code="US",
                    Id = 24
                },
                new FilterList {
                    Name = "Missouri",
                    Value = "Missouri",
                    Code="US",
                    Id = 25
                },
                new FilterList {
                    Name = "Montana",
                    Value = "Montana",
                    Code="US",
                    Id = 26
                },
                new FilterList {
                    Name = "Nebraska",
                    Value = "Nebraska",
                    Code="US",
                    Id = 27
                },
                new FilterList {
                    Name = "Nevada",
                    Value = "Nevada",
                    Code="US",
                    Id = 28
                },
                new FilterList {
                    Name = "New Hampshire",
                    Value = "New Hampshire",
                    Code="US",
                    Id = 29
                },
                new FilterList {
                    Name = "New Jersey",
                    Value = "New Jersey",
                    Code="US",
                    Id = 30
                },
                new FilterList {
                    Name = "New Mexico",
                    Value = "New Mexico",
                    Code="US",
                    Id = 31
                },
                new FilterList {
                    Name = "New York",
                    Value = "New York",
                    Code="US",
                    Id = 32
                },
                new FilterList {
                    Name = "North Carolina",
                    Value = "North Carolina",
                    Code="US",
                    Id = 33
                },
                new FilterList {
                    Name = "North Dakota",
                    Value = "North Dakota",
                    Code="US",
                    Id = 34
                },
                new FilterList {
                    Name = "Ohio",
                    Value = "Ohio",
                    Code="US",
                    Id = 35
                },
                new FilterList {
                    Name = "Oklahoma",
                    Value = "Oklahoma",
                    Code="US",
                    Id = 36
                },
                new FilterList {
                    Name = "Oregon",
                    Value = "Oregon",
                    Code="US",
                    Id = 37
                },
                new FilterList {
                    Name = "Pennsylvania",
                    Value = "Pennsylvania",
                    Code="US",
                    Id = 38
                },
                new FilterList {
                    Name = "Rhode Island",
                    Value = "Rhode Island",
                    Code="US",
                    Id = 39
                },
                new FilterList {
                    Name = "South Carolina",
                    Value = "South Carolina",
                    Code="US",
                    Id = 40
                },
                new FilterList {
                    Name = "South Dakota",
                    Value = "South Dakota",
                    Code="US",
                    Id = 41
                },
                new FilterList {
                    Name = "Tennessee",
                    Value = "Tennessee",
                    Code="US",
                    Id = 42
                },
                new FilterList {
                    Name = "Texas",
                    Value = "Texas",
                    Code="US",
                    Id = 43
                },
                new FilterList {
                    Name = "Utah",
                    Value = "Utah",
                    Code="US",
                    Id = 44
                },
                new FilterList {
                    Name = "Vermont",
                    Value = "Vermont",
                    Code="US",
                    Id = 45
                },
                new FilterList {
                    Name = "Virginia",
                    Value = "Virginia",
                    Code="US",
                    Id = 46
                },
                new FilterList {
                    Name = "Washington",
                    Value = "Washington",
                    Code="US",
                    Id = 47
                },
                new FilterList {
                    Name = "West Virginia",
                    Value = "West Virginia",
                    Code="US",
                    Id = 48
                },
                new FilterList {
                    Name = "Wisconsin",
                    Value = "Wisconsin",
                    Code="US",
                    Id = 49
                },
                new FilterList {
                    Name = "Wyoming",
                    Value = "Wyoming",
                    Code="US",
                    Id = 50
                } };
        }

        public List<FilterList> GetIndiaStateList()
        {

            return new List<FilterList>() {
                new FilterList {
                    Name = "Andhra Pradesh",
                    Value = "Andhra Pradesh",
                    Code="IND",
                    Id = 52
                },
                new FilterList {
                    Name = "Arunachal Pradesh",
                    Value = "Arunachal Pradesh",
                    Code="IND",
                    Id = 53
                },
                new FilterList {
                    Name = "Assam",
                    Value = "Assam",
                    Code="IND",
                    Id = 54
                },
                new FilterList {
                    Name = "Bihar",
                    Value = "Bihar",
                    Code="IND",
                    Id = 55
                },
                new FilterList {
                    Name = "Chhattisgarh",
                    Value = "Chhattisgarh",
                    Code="IND",
                    Id = 56
                },
                new FilterList {
                    Name = "New Delhi",
                    Value = "New Delhi",
                    Code="IND",
                    Id = 57
                },
                new FilterList {
                    Name = "GOA",
                    Value = "GOA",
                    Code="IND",
                    Id = 58
                },
                new FilterList {
                    Name = "Gujarat",
                    Value = "Gujarat",
                    Code="IND",
                    Id = 59
                },
                new FilterList {
                    Name = "Haryana",
                    Value = "Haryana",
                    Code="IND",
                    Id = 60
                },
                new FilterList {
                    Name = "Himachal Pradesh",
                    Value = "Himachal Pradesh",
                    Code="IND",
                    Id = 61
                },
                new FilterList {
                    Name = "Jammu & Kashmir",
                    Value = "Jammu & Kashmir",
                    Code="IND",
                    Id = 62
                },
                new FilterList {
                    Name = "Jharkhand",
                    Value = "Jharkhand",
                    Code="IND",
                    Id = 63
                },
                new FilterList {
                    Name = "Karnataka",
                    Value = "Karnataka",
                    Code="IND",
                    Id = 64
                },
                new FilterList {
                    Name = "Kerala",
                    Value = "Kerala",
                    Code="IND",
                    Id = 65
                },
                new FilterList {
                    Name = "Madhya Pradesh",
                    Value = "Madhya Pradesh",
                    Code="IND",
                    Id = 66
                },
                new FilterList {
                    Name = "Maharashtra",
                    Value = "Maharashtra",
                    Code="IND",
                    Id = 67
                },
                new FilterList {
                    Name = "Manipur",
                    Value = "Manipur",
                    Code="IND",
                    Id = 68
                },
                new FilterList {
                    Name = "Meghalaya",
                    Value = "Meghalaya",
                    Code="IND",
                    Id = 69
                },
                new FilterList {
                    Name = "Mizoram",
                    Value = "Mizoram",
                    Code="IND",
                    Id = 70
                },
                new FilterList {
                    Name = "Nagaland",
                    Value = "Nagaland",
                    Code="IND",
                    Id = 71
                },
                new FilterList {
                    Name = "Orissa",
                    Value = "Orissa",
                    Code="IND",
                    Id = 72
                },
                new FilterList {
                    Name = "Puducherry",
                    Value = "Puducherry",
                    Code="IND",
                    Id = 73
                },
                new FilterList {
                    Name = "Punjab",
                    Value = "Punjab",
                    Code="IND",
                    Id = 74
                },
                new FilterList {
                    Name = "Rajasthan",
                    Value = "Rajasthan",
                    Code="IND",
                    Id = 75
                },
                new FilterList {
                    Name = "Sikkim",
                    Value = "Sikkim",
                    Code="IND",
                    Id = 76
                },
                new FilterList {
                    Name = "Tamil Nadu",
                    Value = "Tamil Nadu",
                    Code="IND",
                    Id = 77
                },
                new FilterList {
                    Name = "Telangana",
                    Value = "Telangana",
                    Code="IND",
                    Id = 78
                },
                new FilterList {
                    Name = "Tripura",
                    Value = "Tripura",
                    Code="IND",
                    Id = 79
                },
                new FilterList {
                    Name = "Uttarakhand",
                    Value = "Uttarakhand",
                    Code="IND",
                    Id = 80
                },
                new FilterList {
                    Name = "Uttar Pradesh",
                    Value = "Uttar Pradesh",
                    Code="IND",
                    Id = 81
                },
                new FilterList {
                    Name = "West Bengal",
                    Value = "West Bengal",
                    Code="IND",
                    Id = 82
                }
            };
        }

        public List<FilterList> GetCountryList()
        {

            return new List<FilterList>() {
                new FilterList {
                    Name = "Argentina",
                    Value = "Argentina",
                    Id = 0
                },
                new FilterList {
                    Name = "Australia",
                    Value = "Australia",
                    Id = 1
                },
                new FilterList {
                    Name = "Austria",
                    Value = "Austria",
                    Id = 2
                },
                new FilterList {
                    Name = "Belgium",
                    Value = "Belgium",
                    Id = 3
                },
                new FilterList {
                    Name = "Bolivia",
                    Value = "Bolivia",
                    Id = 4
                },
                new FilterList {
                    Name = "Brazil",
                    Value = "Brazil",
                    Id = 5
                },
                new FilterList {
                    Name = "Canada",
                    Value = "Canada",
                    Id = 6
                },
                new FilterList {
                    Name = "Chile",
                    Value = "Chile",
                    Id = 7
                },
                new FilterList {
                    Name = "China",
                    Value = "China",
                    Id = 8
                },
                new FilterList {
                    Name = "Colombia",
                    Value = "Colombia",
                    Id = 9
                },
                new FilterList {
                    Name = "Costa Rica",
                    Value = "Costa Rica",
                    Id = 10
                },
                new FilterList {
                    Name = "Croatia",
                    Value = "Croatia",
                    Id = 11
                },
                new FilterList {
                    Name = "Cuba",
                    Value = "Cuba",
                    Id = 12
                },
                new FilterList {
                    Name = "Czech Republic",
                    Value = "Czech Republic",
                    Id = 13
                },
                new FilterList {
                    Name = "Denmark",
                    Value = "Denmark",
                    Id = 14
                },
                new FilterList {
                    Name = "Ecuador",
                    Value = "Ecuador",
                    Id = 15
                },
                new FilterList {
                    Name = "Egypt",
                    Value = "Egypt",
                    Id = 16
                },
                new FilterList {
                    Name = "Finland",
                    Value = "Finland",
                    Id = 17
                },
                new FilterList {
                    Name = "France",
                    Value = "France",
                    Id = 18
                },
                new FilterList {
                    Name = "Georgia",
                    Value = "Georgia",
                    Id = 19
                },
                new FilterList {
                    Name = "Germany",
                    Value = "Germany",
                    Id = 20
                },
                new FilterList {
                    Name = "Greece",
                    Value = "Greece",
                    Id = 21
                },
                new FilterList {
                    Name = "Hong Kong",
                    Value = "Hong Kong",
                    Id = 22
                },
                new FilterList {
                    Name = "Hungary",
                    Value = "Hungary",
                    Id = 23
                },
                new FilterList {
                    Name = "Iceland",
                    Value = "Iceland",
                    Id = 24
                },
                new FilterList {
                    Name = "India",
                    Value = "India",
                    Id = 25
                },
                new FilterList {
                    Name = "Indonesia",
                    Value = "Indonesia",
                    Id = 26
                },
                new FilterList {
                    Name = "Iran",
                    Value = "Iran",
                    Id = 27
                },
                new FilterList {
                    Name = "Ireland",
                    Value = "Ireland",
                    Id = 28
                },
                new FilterList {
                    Name = "Israel",
                    Value = "Israel",
                    Id = 29
                },
                new FilterList {
                    Name = "Italy",
                    Value = "Italy",
                    Id = 30
                },
                new FilterList {
                    Name = "Japan",
                    Value = "Japan",
                    Id = 31
                },
                new FilterList {
                    Name = "Jordan",
                    Value = "Jordan",
                    Id = 32
                },
                new FilterList {
                    Name = "Kazakhstan",
                    Value = "Kazakhstan",
                    Id = 33
                },
                new FilterList {
                    Name = "Kuwait",
                    Value = "Kuwait",
                    Id = 34
                },
                new FilterList {
                    Name = "Liechtenstein",
                    Value = "Liechtenstein",
                    Id = 35
                },
                new FilterList {
                    Name = "Lithuania",
                    Value = "Lithuania",
                    Id = 36
                },
                new FilterList {
                    Name = "Luxembourg",
                    Value = "Luxembourg",
                    Id = 37
                },
                new FilterList {
                    Name = "Mexico",
                    Value = "Mexico",
                    Id = 38
                },
                new FilterList {
                    Name = "Netherlands",
                    Value = "Netherlands",
                    Id = 39
                },
                new FilterList {
                    Name = "New Zealand",
                    Value = "New Zealand",
                    Id = 40
                },
                new FilterList {
                    Name = "Norway",
                    Value = "Norway",
                    Id = 41
                },
                new FilterList {
                    Name = "Pakistan",
                    Value = "Pakistan",
                    Id = 42
                },
                new FilterList {
                    Name = "Panama",
                    Value = "Panama",
                    Id = 43
                },
                new FilterList {
                    Name = "Paraguay",
                    Value = "Paraguay",
                    Id = 44
                },
                new FilterList {
                    Name = "Peru",
                    Value = "Peru",
                    Id = 45
                },
                new FilterList {
                    Name = "Philippines",
                    Value = "Philippines",
                    Id = 46
                },
                new FilterList {
                    Name = "Poland",
                    Value = "Poland",
                    Id = 47
                },
                new FilterList {
                    Name = "Portugal",
                    Value = "Portugal",
                    Id = 48
                },
                new FilterList {
                    Name = "Puerto Rico",
                    Value = "Puerto Rico",
                    Id = 49
                },
                new FilterList {
                    Name = "Qatar",
                    Value = "Qatar",
                    Id = 50
                },
                new FilterList {
                    Name = "Romania",
                    Value = "Romania",
                    Id = 51
                },
                new FilterList {
                    Name = "Russian Federation",
                    Value = "Russian Federation",
                    Id = 52
                },
                new FilterList {
                    Name = "Saudi Arabia",
                    Value = "Saudi Arabia",
                    Id = 53
                },
                new FilterList {
                    Name = "Slovakia",
                    Value = "Slovakia",
                    Id = 54
                },
                new FilterList {
                    Name = "Slovenia",
                    Value = "Slovenia",
                    Id = 55
                },
                new FilterList {
                    Name = "South Korea",
                    Value = "South Korea",
                    Id = 56
                },
                new FilterList {
                    Name = "Spain",
                    Value = "Spain",
                    Id = 57
                },
                new FilterList {
                    Name = "Sri Lanka",
                    Value = "Sri Lanka",
                    Id = 58
                },
                new FilterList {
                    Name = "Sweden",
                    Value = "Sweden",
                    Id = 59
                },
                new FilterList {
                    Name = "Switzerland",
                    Value = "Switzerland",
                    Id = 60
                },
                new FilterList {
                    Name = "Taiwan",
                    Value = "Taiwan",
                    Id = 61
                },
                new FilterList {
                    Name = "Thailand",
                    Value = "Thailand",
                    Id = 62
                },
                new FilterList {
                    Name = "Ukraine",
                    Value = "Ukraine",
                    Id = 63
                },
                new FilterList {
                    Name = "United Kingdom",
                    Value = "United Kingdom",
                    Id = 64
                },
                new FilterList {
                    Name = "United States",
                    Value = "United States",
                    Id = 65
                },
                new FilterList {
                    Name = "Venezuela",
                    Value = "Venezuela",
                    Id = 66
                },
                new FilterList {
                    Name = "Vietnam",
                    Value = "Vietnam",
                    Id = 67
                },
                new FilterList {
                    Name = "Vietnam",
                    Value = "Vietnam",
                    Id = 67
                }
            };
        }
    }
}