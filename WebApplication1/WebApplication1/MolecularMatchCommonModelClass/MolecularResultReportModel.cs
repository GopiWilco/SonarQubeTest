using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.MolecularMatchCommonModelClass
{
    public class MolecularResultReportModel
    {
        public string PatientName { get; set; }
        public string PatientID { get; set; }
        public int? PatientAge { get; set; }
        public string CinicalTrialFavList { get; set; }
        public string PublicationFavList { get; set; }
        public string DrugFavList { get; set; }
        public string SessionID { get; set; }
        public string Gender { get; set; }
    }
}