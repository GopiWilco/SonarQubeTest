// <copyright file="MolecularUsageResult.cs" company="CTSI.">
// Copyright © CTSI All rights reserved.
// </copyright>

namespace WebApplication1.MolecularMatchCommonModelClass
{
    using System;

    /// <summary>
    /// Module Usage Result.
    /// </summary>
    public class MolecularUsageResult
    {
        /// <summary>
        /// Gets or sets Organization ID.
        /// </summary>
        public int OrganizationID { get; set; }

        /// <summary>
        /// Gets or sets User ID.
        /// </summary>
        public long? UserID { get; set; }

        /// <summary>
        /// Gets or sets Clinical Trail Count.
        /// </summary>
        public long ClinicalTrailCount { get; set; }

        /// <summary>
        /// Gets or sets Publication Count.
        /// </summary>
        public long PublicationCount { get; set; }

        /// <summary>
        /// Gets or sets Drug Count.
        /// </summary>
        public long DrugCount { get; set; }

        /// <summary>
        /// Gets or sets Suggestion Count.
        /// </summary>
        public long SuggestionCount { get; set; }

        /// <summary>
        /// Gets or sets Drug Count.
        /// </summary>
        public long Total { get; set; }

        /// <summary>
        /// Gets or sets Notes.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets Organization Name.
        /// </summary>
        public string OrganizationName { get; set; }

        /// <summary>
        /// Gets or sets Last Accessed.
        /// </summary>
        public DateTime? LastAccessed { get; set; }

        /// <summary>
        /// Gets or sets Onboard Date.
        /// </summary>
        public DateTime? OnBoardDate { get; set; }

        /// <summary>
        /// Gets or sets Contract Date.
        /// </summary>
        public DateTime? ContractDate { get; set; }
    }
}
