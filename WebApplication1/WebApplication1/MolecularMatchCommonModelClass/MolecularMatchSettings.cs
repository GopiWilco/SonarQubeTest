// <copyright file="MolecularMatchSettings.cs" company="CTSI.">
// Copyright © CTSI All rights reserved.
// </copyright>

namespace WebApplication1.MolecularMatchCommonModelClass
{
    using System;

    /// <summary>
    /// Molecular Match OnBoard.
    /// </summary>
    public class MolecularMatchSettings
    {
        /// <summary>
        /// Gets or sets Organization ID.
        /// </summary>
        public int OrganizationID { get; set; }

        /// <summary>
        /// Gets or sets Onboard Date.
        /// </summary>
        public DateTime? ContractDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or set Clinical Trial.
        /// </summary>
        public bool HasClinicalTrial { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or set Publication.
        /// </summary>
        public bool HasPublication { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or set Drug.
        /// </summary>
        public bool HasDrugs { get; set; }

        /// <summary>
        /// Gets or sets User ID.
        /// </summary>
        public long UserID { get; set; }
    }
}
