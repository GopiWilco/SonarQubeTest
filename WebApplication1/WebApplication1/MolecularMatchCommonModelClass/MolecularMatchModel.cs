using WebApplication1.CDSCommonModelClass;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace WebApplication1.MolecularMatchCommonModelClass
{
    public class MolecularMatchModel : MolecularMatchBase
    {
        public MolecularMatchModel()
        {
            DiagnosisList = new List<string>();
            GeneList = new List<string>();
            PatientMutationList = new List<string>();
            PatientDrugList = new List<string>();
            MolecularPhaseList = new List<string>();
            ResistanceList = new List<string>();
        }

        public string Country { get; set; }

        public Guid? PatientID { get; set; }
        public string PatientCode { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string AttachmentPath { get; set; }
        public List<MutationListItems> PatientMutation { get; set; }
        public string PatientName { get; set; }
        public string PrimaryClinicanName { get; set; }
        public string SearchKey { get; set; }
        public string ZipCode { get; set; }
        public int NumberOfMiles { get; set; }
        public List<string> DiagnosisList { get; set; }
        public List<string> GeneList { get; set; }
        public string CountryName { get; set; }
        public bool IsPatientLocationBasedSearch { get; set; }
        public bool IsPatientPhaseBasedSearch { get; set; }
        public bool HasPhase { get; set; }
        public string PrimaryDisease { get; set; }
        public string Stage { get; set; }
        public string Ecog { get; set; }
        public bool HasMutation { get; set; }
        public string PatientMutations { get; set; }
        public string DrugUsedInPreviousTreatment { get; set; }
        public List<string> PatientMutationList { get; set; }
        public List<string> PatientDrugList { get; set; }
        public string MolecularPhase { get; set; }
        public List<string> MolecularPhaseList { get; set; }
        public List<string> ResistanceList { get; set; }
        public string Histology { get; set; }
        public string SearchString { get; set; }

        public SelectList DiagnosisDDList { get; set; }
    }

    public class MolecularMatchBase
    {
        public List<FilterList> TrialTypes { get; set; }
        public List<FilterList> TrialStatus { get; set; }
        public List<FilterList> Condition { get; set; }
        public List<FilterList> Gene { get; set; }
        public List<FilterList> Mutation { get; set; }
        public List<FilterList> Drug { get; set; }
        public List<FilterList> DrugClass { get; set; }
        public List<FilterList> Resistance { get; set; }
        public List<FilterList> Institution { get; set; }
        public List<FilterList> Phase { get; set; }
        public List<FilterList> PublicationType { get; set; }
        public List<FilterList> Journal { get; set; }
        public List<FilterList> Findings { get; set; }
        public List<FilterList> Duration { get; set; }
        public List<FilterList> StateList { get; set; }
        public List<FilterList> CountryList { get; set; }

    }

}