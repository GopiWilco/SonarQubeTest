using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.MolecularMatchCommonModelClass
{
    public class MolecularReportConfigurationModel
    {
        /// <summary>
        /// Gets or sets MolecularReportConfiguration ID.
        /// </summary>
        public int MolecularReportConfigurationID { get; set; }

        /// <summary>
        /// Gets or sets Organization ID.
        /// </summary>
        public int OrganizationID { get; set; }

        /// <summary>
        /// Gets or sets User ID.
        /// </summary>
        public long? UserID { get; set; }

        /// <summary>
        /// Gets or sets Modified Date.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets Report Configuration Json.
        /// </summary>
        public string ReportConfiguration { get; set; }
        public MolecularReportConfigurationJson MolecularReportConfigJson { get; set; }
    }
}