using WebApplication1.CDSCommonModelClass;
using WebApplication1.MolecularMatchCommonModelClass.Drug;
using WebApplication1.MolecularMatchCommonModelClass.Publication;
using WebApplication1.MolecularMatchCommonModelClass.Trial;

namespace WebApplication1.MolecularMatchCommonModelClass
{
    public class MolecularMatchResultModel
    {
        public PatientModel Patient { get; set; }
        public ClinicalTrail ClinicalTrails { get; set; }
        public ClinicTrialDetails ClinicTrialDetails { get; set; }
        public Publications Publications { get; set; }
        public Drugs Drugs { get; set; }

        public bool IsClinicalTrialFiltered { get; set; }
        public bool IsPublicationFiltered { get; set; }
        public bool IsDrugFiltered { get; set; }
    }
}