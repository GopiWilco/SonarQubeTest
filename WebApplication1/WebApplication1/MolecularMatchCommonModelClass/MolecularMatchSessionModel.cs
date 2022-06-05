using WebApplication1.MolecularMatchCommonModelClass.Drug;
using WebApplication1.MolecularMatchCommonModelClass.Publication;
using WebApplication1.MolecularMatchCommonModelClass.Trial;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebApplication1.MolecularMatchCommonModelClass
{
    public class MolecularMatchSessionModel
    {

        public MolecularMatchSessionModel()
        {
            this.ClinicalTrail = new ClinicalTrail();
            this.Publications = new Publications();
            this.Drugs = new Drugs();

            this.ClinicalTrail.Rows = new List<Trial.Row>().ToArray();
            this.Publications.Rows = new List<Publication.Row>().ToArray();
            this.Drugs.Rows = new List<Drug.Row>().ToArray();
        }

        public MolecularMatchSessionModel(ClinicalTrail clinicalTrail, Publications publications, Drugs drugs)
        {
            this.ClinicalTrail = clinicalTrail;
            this.Publications = publications;
            this.Drugs = drugs;
        }

        public MolecularReportConfigurationModel molecularReportConfigurationModel { get; set; }
        public ClinicalTrail ClinicalTrail { get; set; }
        public Publications Publications { get; set; }
        public Drugs Drugs { get; set; }

        public List<ClinicTrialDetails> ClinicTrialDetails { get; set; }

        public bool IsClinicalTrialFiltered { get; set; }
        public bool IsPublicationFiltered { get; set; }
        public bool IsDrugFiltered { get; set; }
        public bool IsTaskCancelled { get; set; }
    }

    public class MolecularMatchResultReportModel
    {
        public MolecularReportConfigurationModel molecularReportConfigurationModel { get; set; }
        public MolecularMatchSessionModel MolecularMatchSessionModel { get; set; }

        public string PatientName { get; set; }
        public string PatientCode { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }

    public static class ExtensionMethods
    {
        public static T DeepCopy<T>(this T self)
        {
            var serialized = JsonConvert.SerializeObject(self);
            return JsonConvert.DeserializeObject<T>(serialized);
        }
    }

    public class MolecularMatchSession
    {
        public MolecularMatchSession(ClinicalTrail clinicalTrail, Publications publications, Drugs drugs)
        {
            this.ClinicalTrail = clinicalTrail;
            this.Publications = publications;
            this.Drugs = drugs;
        }

        public MolecularMatchSession()
        {

        }

        public ClinicalTrail ClinicalTrail { get; set; }
        public Publications Publications { get; set; }
        public Drugs Drugs { get; set; }

        public List<ClinicTrialDetails> ClinicTrialDetails { get; set; }

        public bool IsClinicalTrialFiltered { get; set; }
        public bool IsPublicationFiltered { get; set; }
        public bool IsDrugFiltered { get; set; }
    }

    public class MolecularMatchResultSessionSaved
    {
        public MolecularMatchResultSessionSaved()
        {
            this.OldMolecularMatchSessionModel = new MolecularMatchSessionModel();
            this.NewMolecularMatchSessionModel = new MolecularMatchSessionModel();
        }

        public MolecularMatchResultSessionSaved(MolecularMatchSessionModel OldMolecularMatchSessionModel, MolecularMatchSessionModel NewMolecularMatchSessionModel)
        {
            this.OldMolecularMatchSessionModel = OldMolecularMatchSessionModel;
            this.NewMolecularMatchSessionModel = NewMolecularMatchSessionModel;
        }

        public MolecularMatchResultSessionSaved(MolecularMatchSessionModel NewMolecularMatchSessionModel)
        {
            this.OldMolecularMatchSessionModel = new MolecularMatchSessionModel();
            this.NewMolecularMatchSessionModel = NewMolecularMatchSessionModel;
        }

        public MolecularMatchSessionModel OldMolecularMatchSessionModel { get; set; }
        public MolecularMatchSessionModel NewMolecularMatchSessionModel { get; set; }
    }
}