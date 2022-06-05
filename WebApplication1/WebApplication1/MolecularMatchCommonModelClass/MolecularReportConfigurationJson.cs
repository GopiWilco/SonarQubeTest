using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.MolecularMatchCommonModelClass
{
    public class MolecularReportConfigurationJson
    {
        public bool IsSelectAll { get; set; } = true;
        public bool IsIntroduction { get; set; } = true;
        public bool IsPurpose { get; set; } = true;
        public bool IsArm { get; set; } = true;
        public bool IsDescription { get; set; } = true;
        public bool IsOverview { get; set; } = false;
        public bool IsDrugs { get; set; } = false;
        public bool IsCondition { get; set; } = false;
        public bool IsStudyID { get; set; } = false;
        public bool IsStudyStartDate { get; set; } = false;
        public bool IsSponsor { get; set; } = false;
        public bool IsStudyType { get; set; } = false;
        public bool IsEligibility { get; set; } = false;
        public bool IsInclusionCriteria { get; set; } = false;
        public bool IsExclusionCriteria { get; set; } = false;
        public bool IsLocations { get; set; } = false;
        public bool IsFacilityName { get; set; } = false;
        public bool IsFacilityAddress { get; set; } = false;
        public bool IsFacilityPhone { get; set; } = false;
        public bool IsFacilityEmail { get; set; } = false;
        public bool IsFacilityDistance { get; set; } = false;
    }
}