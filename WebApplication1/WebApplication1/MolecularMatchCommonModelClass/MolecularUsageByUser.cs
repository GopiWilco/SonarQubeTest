// <copyright file="MolecularUsageByUser.cs" company="CTSI.">
// Copyright © CTSI All rights reserved.
// </copyright>

namespace WebApplication1.MolecularMatchCommonModelClass
{
    using System;

    /// <summary>
    /// Module Usage Details By User.
    /// </summary>
    public class MolecularUsageByUser
    {
        /// <summary>
        /// Gets or sets User ID.
        /// </summary>
        public long? UserID { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Email Address.
        /// </summary>
        public string EmailAddress { get; set; }

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
        /// Gets or sets Last Accessed.
        /// </summary>
        public DateTime? LastAccessed { get; set; }
    }
}
