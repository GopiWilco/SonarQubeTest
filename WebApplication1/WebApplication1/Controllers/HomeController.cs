using WebApplication1.MolecularMatchCommonModelClass;
using WebApplication1.MolecularMatchCommonModelClass.Drug;
using WebApplication1.MolecularMatchCommonModelClass.Publication;
using WebApplication1.MolecularMatchCommonModelClass.Trial;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace WebApplication1.Controllers
{
    public class MolecularAnalyticsController : Controller
    {
        private static string _fileBasePath = @"F:\CTSIUpload";

        [HttpPost]
        public async Task<ActionResult> MolecularResult(MolecularResultReportModel molecularResultReportModel)
        {
            ////await _loggingService.LogInfo("Molecular Match", "MolecularResult Post", "MolecularResult Post", Newtonsoft.Json.JsonConvert.SerializeObject(molecularResultReportModel));

            return await MolecularResult(molecularResultReportModel.PatientName + "#" + molecularResultReportModel.PatientID, molecularResultReportModel.PatientAge, molecularResultReportModel.CinicalTrialFavList, molecularResultReportModel.PublicationFavList, molecularResultReportModel.DrugFavList, molecularResultReportModel.SessionID, molecularResultReportModel.Gender);
        }
        [HttpGet]
        public async Task<ActionResult> MolecularResult(string patient, int? Age, string clinicalTrialFavList, string publicationFavList, string drugFavList, string sessionID, string gender)
        {
            try
            {
                List<WebApplication1.MolecularMatchCommonModelClass.Filter> filters = new List<MolecularMatchCommonModelClass.Filter>();

                MolecularMatchSessionModel molecularMatchSessionModel = MolecularResult_GetMolecularReportCurrentResult(GetSessionData(sessionID).NewMolecularMatchSessionModel);

                List<WebApplication1.MolecularMatchCommonModelClass.Trial.Row> clinicalTrialRows = new List<MolecularMatchCommonModelClass.Trial.Row>();
                List<WebApplication1.MolecularMatchCommonModelClass.Publication.Row> publicationRows = new List<MolecularMatchCommonModelClass.Publication.Row>();
                List<WebApplication1.MolecularMatchCommonModelClass.Drug.Row> drugRows = new List<MolecularMatchCommonModelClass.Drug.Row>();
                MolecularMatchSessionModel reportModel = new MolecularMatchSessionModel();

                if (!string.IsNullOrEmpty(clinicalTrialFavList))
                {
                    foreach (var item in clinicalTrialFavList.Split(','))
                    {
                        clinicalTrialRows.Add(molecularMatchSessionModel.ClinicalTrail.Rows.FirstOrDefault(x => x.Id == item));
                        molecularMatchSessionModel.IsClinicalTrialFiltered = true;
                    }
                }

                if (!string.IsNullOrEmpty(publicationFavList))
                {
                    foreach (var item in publicationFavList.Split(','))
                    {
                        publicationRows.Add(molecularMatchSessionModel.Publications.Rows.FirstOrDefault(x => x.Id == item));
                        molecularMatchSessionModel.IsPublicationFiltered = true;
                    }
                }

                if (!string.IsNullOrEmpty(drugFavList))
                {
                    foreach (var item in drugFavList.Split(','))
                    {
                        drugRows.Add(molecularMatchSessionModel.Drugs.Rows.FirstOrDefault(x => x.Id == item));
                        molecularMatchSessionModel.IsDrugFiltered = true;
                    }
                }

                var pdfname = String.Format("{0}.pdf", Guid.NewGuid().ToString().Substring(0, 4));

                DateTime dateTime = DateTime.UtcNow;

                if (Session["Timezone"] != null)
                {
                    TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById(Session["Timezone"].ToString());
                    dateTime = TimeZoneInfo.ConvertTime(dateTime, cstZone);
                }

                var CustomSwitches = "--dpi 150 --footer-left \"" + Session["Name"] + " printed report on: " + dateTime.ToString("MM/dd/yyyy hh:mm tt") + "\" " + "--footer-right \"Page: [page] of [toPage]\" --footer-line --footer-font-size \"9\" --footer-spacing 5 --footer-font-name \"calibri light\"";

                reportModel.ClinicalTrail = new ClinicalTrail
                {
                    Rows = clinicalTrialRows.ToArray()
                };

                reportModel.Publications = new Publications
                {
                    Rows = publicationRows.ToArray()
                };

                reportModel.Drugs = new Drugs
                {
                    Rows = drugRows.ToArray(),
                    TieringTemplateLegend = molecularMatchSessionModel.Drugs.TieringTemplateLegend
                };

                var patientDetails = patient.Split(new string[] { "#" }, StringSplitOptions.None);


                reportModel.molecularReportConfigurationModel = GetMolecularReportConfiguration();


                if (reportModel.molecularReportConfigurationModel.ReportConfiguration == null)
                {
                    reportModel.molecularReportConfigurationModel.MolecularReportConfigJson = new MolecularReportConfigurationJson();
                }

                MolecularMatchResultReportModel molecularMatchResultModel = new MolecularMatchResultReportModel
                {
                    MolecularMatchSessionModel = reportModel,
                    PatientName = patientDetails[0],
                    PatientCode = patientDetails[1],
                    Gender = gender,
                    Age = Convert.ToInt32(Age)
                };

                
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private MolecularMatchSessionModel MolecularResult_GetMolecularReportCurrentResult(MolecularMatchSessionModel molecularMatchSessionModel)
        {
            if (molecularMatchSessionModel == null)
            {
                molecularMatchSessionModel = new MolecularMatchSessionModel();
                molecularMatchSessionModel.ClinicalTrail = new ClinicalTrail();
                molecularMatchSessionModel.Publications = new Publications();
                molecularMatchSessionModel.Drugs = new Drugs();
            }

            if (molecularMatchSessionModel.ClinicalTrail.Rows == null)
            {
                molecularMatchSessionModel.ClinicalTrail.Rows = new List<MolecularMatchCommonModelClass.Trial.Row>().ToArray();
            }

            if (molecularMatchSessionModel.Publications.Rows == null)
            {
                molecularMatchSessionModel.Publications.Rows = new List<MolecularMatchCommonModelClass.Publication.Row>().ToArray();
            }

            if (molecularMatchSessionModel.Drugs.Rows == null)
            {
                molecularMatchSessionModel.Drugs.Rows = new List<MolecularMatchCommonModelClass.Drug.Row>().ToArray();
            }

            return molecularMatchSessionModel;
        }


        private MolecularReportConfigurationModel GetMolecularReportConfiguration()
        {
            MolecularReportConfigurationModel model = new MolecularReportConfigurationModel();


            return model;
        }

        private string GetSaveMolecularSessionDataPath(string fileBasePath)
        {
            string DateFolderName = DateTime.UtcNow.ToString("yyyyMMdd");

            return Path.GetFullPath(Path.Combine(fileBasePath, "Organization/" + Convert.ToInt32(Session["OrganizationID"]) + "/MolecularResultData/Date/" + DateFolderName + "/Session/"));
        }

        private string GetSMolecularSessionFolderPath()
        {
            return Path.Combine(_fileBasePath, "Organization/" + Convert.ToInt32(Session["OrganizationID"]) + "/MolecularResultData/Date/");
        }

        private void RemoveOlderSessionData()
        {
            string DateFolderName = DateTime.UtcNow.ToString("yyyyMMdd");

            var baseFolderPath = GetSMolecularSessionFolderPath();

            string[] subdirs = Directory.GetDirectories(baseFolderPath);

            foreach (var item in subdirs)
            {
                var directory = new DirectoryInfo(item);

                if (Convert.ToInt64(item.Substring(item.Length - 8, 8)) + 2 < Convert.ToInt64(DateFolderName) && directory.Exists)
                {
                    Directory.Delete(item, true);
                }
            }
        }

        private MolecularMatchResultSessionSaved GetSessionData(string sessionID)
        {
            MolecularMatchResultSessionSaved currentMolecularMatchResultSessionSaved = new MolecularMatchResultSessionSaved(new MolecularMatchSessionModel(), new MolecularMatchSessionModel());
            try
            {
                string fileBasePath = Server.MapPath("~/Content/");
                string path = GetSaveMolecularSessionDataPath(fileBasePath) + Path.DirectorySeparatorChar + sessionID + ".json";
                var filePath = Path.GetFullPath(Path.Combine(path));

                if (!filePath.StartsWith(Path.GetFullPath(fileBasePath), StringComparison.Ordinal))
                {
                    throw new UnauthorizedAccessException();
                }
                else
                {
                    FileInfo ContentPath = new FileInfo(Path.GetFullPath(filePath));

                    if (ContentPath.Exists)
                    {
                        var fs = new FileStream(Path.GetFullPath(filePath), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                        JObject o2;

                        using (var sr = new StreamReader(fs))
                        {
                            using (JsonTextReader reader = new JsonTextReader(sr))
                            {
                                o2 = (JObject)JToken.ReadFrom(reader);
                            }
                        }

                        currentMolecularMatchResultSessionSaved = ConvertJObjectToMolecularMatch(o2);
                    }
                }
            }
            catch (Exception ex)
            {
                
            }

            return currentMolecularMatchResultSessionSaved;
        }

        private MolecularMatchResultSessionSaved ConvertJObjectToMolecularMatch(JObject o2)
        {
            var currentMolecularMatchResultSessionSaved = o2.ToObject<MolecularMatchResultSessionSaved>();

            if (currentMolecularMatchResultSessionSaved == null)
            {
                currentMolecularMatchResultSessionSaved = new MolecularMatchResultSessionSaved(new MolecularMatchSessionModel(), new MolecularMatchSessionModel());
            }
            else
            {
                if (currentMolecularMatchResultSessionSaved.OldMolecularMatchSessionModel == null)
                {
                    currentMolecularMatchResultSessionSaved.OldMolecularMatchSessionModel = new MolecularMatchSessionModel();
                }
                if (currentMolecularMatchResultSessionSaved.NewMolecularMatchSessionModel == null)
                {
                    currentMolecularMatchResultSessionSaved.NewMolecularMatchSessionModel = new MolecularMatchSessionModel();
                }
            }

            return currentMolecularMatchResultSessionSaved;
        }
    }
}