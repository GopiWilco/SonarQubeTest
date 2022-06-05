using System;
using System.Configuration;

namespace WebApplication1.MolecularMatchCommonModelClass
{
    public class AuditLog
    {
        public AuditLog()
        {
            this.Source = ConfigurationManager.AppSettings["Application"].ToString();
        }

        public int? PatientID { get; set; }
        public DateTime TransactionDate { get; set; }
        public bool WithSearchKey { get; set; }
        public string Source { get; set; }
    }
}