using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private static string _fileBasePath = BuildFilePathSetUp().StartingPath;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            JObject jObject= GetSessionData("11");

            ViewBag.jObject = jObject;

            return View();
        }

        private JObject GetSessionData(string sessionID)
        {
            JObject o2 = new JObject();
            string path = GetSaveMolecularSessionDataPath() + Path.DirectorySeparatorChar + sessionID + ".json";
            var filePath = Path.GetFullPath(Path.Combine(path));

            if (!filePath.StartsWith(Path.GetFullPath(_fileBasePath), StringComparison.Ordinal))
            {
                throw new UnauthorizedAccessException();
            }
            else
            {
                FileInfo ContentPath = new FileInfo(Path.GetFullPath(filePath));

                if (ContentPath.Exists)
                {
                    var fs = new FileStream(Path.GetFullPath(filePath), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                    using (var sr = new StreamReader(fs))
                    {
                        using (JsonTextReader reader = new JsonTextReader(sr))
                        {
                            o2 = (JObject)JToken.ReadFrom(reader);
                        }
                    }
                }
            }

            return o2;
        }

        private string GetSaveMolecularSessionDataPath()
        {
            string DateFolderName = DateTime.UtcNow.ToString("yyyyMMdd");

            return Path.GetFullPath(Path.Combine(_fileBasePath, "Organization/" + Convert.ToInt32(Session["OrganizationID"]) + "/MolecularResultData/Date/" + DateFolderName + "/Session/"));
        }

        private static FilePathSetup BuildFilePathSetUp()
        {
            var filePathModel = new FilePathSetup();

            filePathModel.StartingPath = @"F:\CTSIUpload";

            return filePathModel;
        }
    }
}