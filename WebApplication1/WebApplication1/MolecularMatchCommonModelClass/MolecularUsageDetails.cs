// <copyright file="MolecularUsageDetails.cs" company="CTSI.">
// Copyright © CTSI All rights reserved.
// </copyright>

namespace WebApplication1.MolecularMatchCommonModelClass
{
    using System.Collections.Generic;

    /// <summary>
    /// Module Usage Result.
    /// </summary>
    public class MolecularUsageDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MolecularUsageDetails"/> class.
        /// </summary>
        public MolecularUsageDetails()
        {
            this.MolecularUsageByUsers = new List<MolecularUsageByUser>();
        }

        /// <summary>
        /// Gets or sets Molecular Usage By User.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Reviewed.")]
        public List<MolecularUsageByUser> MolecularUsageByUsers { get; set; }
    }
}
