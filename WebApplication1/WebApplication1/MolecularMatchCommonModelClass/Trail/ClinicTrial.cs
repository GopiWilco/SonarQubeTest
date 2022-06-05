using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WebApplication1.MolecularMatchCommonModelClass.Trial
{
    public class ClinicalTrail
    {
        [JsonProperty("searchKey")]
        public string SearchKey { get; set; }

        [JsonProperty("institutionId")]
        public object InstitutionId { get; set; }

        [JsonProperty("caseId")]
        public object CaseId { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("totalPages")]
        public long TotalPages { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("showingResultsFor")]
        public ShowingResultsFor ShowingResultsFor { get; set; }

        [JsonProperty("rows")]
        public Row[] Rows { get; set; }

        [JsonProperty("searchInsteadFor")]
        public object[] SearchInsteadFor { get; set; }

        [JsonProperty("lastUpdated")]
        public DateTimeOffset LastUpdated { get; set; }

        ////MolecularReportConfigurationModel molecularReportConfigurationModel = new MolecularReportConfigurationModel();
    }

    public class Row
    {
        [JsonProperty("_score")]
        public double Score { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("institutionId")]
        public object InstitutionId { get; set; }

        [JsonProperty("institutionStudyId")]
        public object InstitutionStudyId { get; set; }

        [JsonProperty("briefTitle")]
        public string BriefTitle { get; set; }

        [JsonProperty("briefSummaryPreserved")]
        public string BriefSummaryPreserved { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonProperty("studyType")]
        public string StudyType { get; set; }

        [JsonProperty("startDate")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("completionDate")]
        public DateTimeOffset CompletionDate { get; set; }

        [JsonProperty("lastChangedDate")]
        public DateTimeOffset LastChangedDate { get; set; }

        [JsonProperty("firstReceivedDate")]
        public DateTimeOffset FirstReceivedDate { get; set; }

        [JsonProperty("locations")]
        public Location[] Locations { get; set; }

        [JsonProperty("interventions")]
        public Intervention[] Interventions { get; set; }

        [JsonProperty("overallContact")]
        public OverallContact OverallContact { get; set; }

        [JsonProperty("molecularAlterations")]
        public object[] MolecularAlterations { get; set; }

        [JsonProperty("link")]
        public Uri Link { get; set; }

        [JsonProperty("missing")]
        public Missing[] Missing { get; set; }

        [JsonProperty("matching")]
        public Matching[] Matching { get; set; }

        [JsonProperty("sponsors")]
        public Sponsor[] Sponsors { get; set; }

        [JsonProperty("_scoring")]
        public Scoring[] Scoring { get; set; }

        [JsonProperty("locationSummary")]
        public LocationSummary LocationSummary { get; set; }

        public ClinicTrialDetails lstClinicTrialDetails { get; set; }
    }
    public class LocationSummary
    {
        [JsonProperty("us")]
        public bool Us { get; set; }

        [JsonProperty("intl")]
        public bool Intl { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("recruitingCount")]
        public long RecruitingCount { get; set; }

        [JsonProperty("countries")]
        public Country[] Countries { get; set; }

        [JsonProperty("nearestLocation")]
        public NearestLocation NearestLocation { get; set; }

        [JsonProperty("nearestLocationDistance")]
        public double NearestLocationDistance { get; set; }
    }

    public class NearestLocation
    {
        public string zip { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public object lon { get; set; }
        public object po_box { get; set; }
        public List<object> includeCountry0 { get; set; }
        public List<Tag> tags { get; set; }
        public List<string> includeCountry1 { get; set; }
        public Geo geo { get; set; }
        public List<object> excludeCountry { get; set; }
        public List<object> excludeMedicalgroup { get; set; }
        public object street { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public string state { get; set; }
        public List<string> includeMedicalgroup1 { get; set; }
        public List<string> includeMedicalgroup0 { get; set; }
        public object lat { get; set; }
        public string status { get; set; }
        public double distance { get; set; }
        public string distanceUOM { get; set; }
        public string email_backup { get; set; }
        public string last_name_backup { get; set; }
        public string phone_backup { get; set; }
        public string email { get; set; }
        public string last_name { get; set; }
        public string phone { get; set; }
    }

    public class Missing
    {
        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("rootTerm")]
        public string RootTerm { get; set; }

        [JsonProperty("facet")]
        public string Facet { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        public string MustIncludeHTML
        {
            get
            {
                if (!string.IsNullOrEmpty(this.Term) && !string.IsNullOrEmpty(this.Facet))
                {
                    return "<a class='missing_filter' data-facet='" + this.Facet + "' data-term='" + this.Term + "' data-rootterm='" + this.RootTerm + "'>" + this.Term + "</a>";
                }

                return string.Empty;
            }
        }

    }

    public class Intervention
    {
        [JsonProperty("intervention_type")]
        public string InterventionType { get; set; }

        [JsonProperty("arm_group_label")]
        public string[] ArmGroupLabel { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("other_name")]
        public string[] OtherName { get; set; }

        [JsonProperty("intervention_name")]
        public string InterventionName { get; set; }
    }

    public class Location
    {
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("lon")]
        public object Lon { get; set; }

        [JsonProperty("po_box")]
        public object PoBox { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("geo", NullValueHandling = NullValueHandling.Ignore)]
        public Geo Geo { get; set; }

        [JsonProperty("excludeCountry")]
        public object[] ExcludeCountry { get; set; }

        [JsonProperty("excludeMedicalgroup")]
        public object[] ExcludeMedicalgroup { get; set; }

        [JsonProperty("street")]
        public object Street { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("includeMedicalgroup1", NullValueHandling = NullValueHandling.Ignore)]
        public object[] IncludeMedicalgroup1 { get; set; }

        [JsonProperty("includeMedicalgroup0", NullValueHandling = NullValueHandling.Ignore)]
        public object[] IncludeMedicalgroup0 { get; set; }

        [JsonProperty("lat")]
        public object Lat { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("distance", NullValueHandling = NullValueHandling.Ignore)]
        public double? Distance { get; set; }

        [JsonProperty("distanceUOM", NullValueHandling = NullValueHandling.Ignore)]
        public string DistanceUom { get; set; }
    }

    public class Geo
    {
        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }
    }

    public class Tag
    {
        [JsonProperty("custom")]
        public bool Custom { get; set; }

        [JsonProperty("compositeKey")]
        public object CompositeKey { get; set; }

        [JsonProperty("alias")]
        public object Alias { get; set; }

        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("suppress")]
        public bool Suppress { get; set; }

        [JsonProperty("filterType")]
        public string FilterType { get; set; }

        [JsonProperty("priority")]
        public object Priority { get; set; }

        [JsonProperty("generatedBy")]
        public string GeneratedBy { get; set; }

        [JsonProperty("facet")]
        public string Facet { get; set; }

        [JsonProperty("generatedByTerm")]
        public string GeneratedByTerm { get; set; }
    }

    public class Matching
    {
        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("rootTerm")]
        public string RootTerm { get; set; }

        [JsonProperty("facet")]
        public string Facet { get; set; }

        [JsonProperty("filterType")]
        public string FilterType { get; set; }

        [JsonProperty("relatedTerm", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedTerm { get; set; }

        [JsonProperty("relationship")]
        public string Relationship { get; set; }

        [JsonProperty("explanation")]
        public string Explanation { get; set; }

        public string IndirectMatching { get; set; }

        public string DirectMatching { get; set; }
    }

    public class OverallContact
    {
        [JsonProperty("role")]
        public object Role { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("affiliation")]
        public object Affiliation { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("middle_name")]
        public object MiddleName { get; set; }

        [JsonProperty("first_name")]
        public object FirstName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("degrees")]
        public object Degrees { get; set; }

        [JsonProperty("phone_ext")]
        public object PhoneExt { get; set; }
    }

    public class Scoring
    {
        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ShowingResultsFor
    {
        [JsonProperty("rationalized")]
        public Rationalized[] Rationalized { get; set; }

        [JsonProperty("unrecognized")]
        public object[] Unrecognized { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class Rationalized
    {
        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("rootTerm")]
        public string RootTerm { get; set; }

        [JsonProperty("facet")]
        public string Facet { get; set; }

        [JsonProperty("synonyms", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Synonyms { get; set; }

        [JsonProperty("filterType")]
        public string FilterType { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public Code[] Code { get; set; }
    }

    public class Code
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
    public class ClinicTrialDetails
    {
        [JsonProperty("gender")]
        public string[] Gender { get; set; }

        [JsonProperty("studyDesign")]
        public StudyDesign StudyDesign { get; set; }

        [JsonProperty("link")]
        public Uri Link { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("briefSummaryPreserved")]
        public string BriefSummaryPreserved { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("exclusionCriteria")]
        public string ExclusionCriteria { get; set; }

        [JsonProperty("overallContact")]
        public Overall OverallContact { get; set; }

        [JsonProperty("armGroups")]
        public ArmGroup[] ArmGroups { get; set; }

        [JsonProperty("exclusionCriteriaPreserved")]
        public string ExclusionCriteriaPreserved { get; set; }

        [JsonProperty("sponsors")]
        public Sponsor[] Sponsors { get; set; }

        [JsonProperty("studyType")]
        public string StudyType { get; set; }

        [JsonProperty("briefTitle")]
        public string BriefTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonProperty("secondaryOutcomes")]
        public SecondaryOutcome[] SecondaryOutcomes { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }


        [JsonProperty("briefSummary")]
        public string BriefSummary { get; set; }

        [JsonProperty("synonyms")]
        public Synonym[] Synonyms { get; set; }

        [JsonProperty("countries")]
        public Country[] Countries { get; set; }

        [JsonProperty("inclusionCriteria")]
        public string InclusionCriteria { get; set; }

        [JsonProperty("enrollment")]
        public long Enrollment { get; set; }

        [JsonProperty("overallOfficial")]
        public Overall[] OverallOfficial { get; set; }

        [JsonProperty("interventions")]
        public Intervention[] Interventions { get; set; }

        [JsonProperty("maxAge")]
        public long MaxAge { get; set; }

        [JsonProperty("minAge")]
        public long MinAge { get; set; }

        [JsonProperty("locations")]
        public Location[] Locations { get; set; }

        [JsonProperty("inclusionCriteriaPreserved")]
        public string InclusionCriteriaPreserved { get; set; }

        [JsonProperty("conditions")]
        public string[] Conditions { get; set; }

        [JsonProperty("startDate")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("molecularAlterations")]
        public MolecularAlteration[] MolecularAlterations { get; set; }
    }

    public class ArmGroup
    {
        [JsonProperty("arm_group_label")]
        public string ArmGroupLabel { get; set; }

        [JsonProperty("arm_group_type")]
        public string ArmGroupType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class Country
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class MolecularAlteration
    {
        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }
    }

    public class Overall
    {
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public object FirstName { get; set; }

        [JsonProperty("middle_name")]
        public object MiddleName { get; set; }

        [JsonProperty("degrees")]
        public object Degrees { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("affiliation")]
        public string Affiliation { get; set; }

        [JsonProperty("phone_ext")]
        public object PhoneExt { get; set; }
    }

    public class SecondaryOutcome
    {
        [JsonProperty("measure")]
        public string Measure { get; set; }

        [JsonProperty("time_frame")]
        public string TimeFrame { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class Sponsor
    {
        [JsonProperty("lead_sponsor")]
        public LeadSponsor LeadSponsor { get; set; }

        [JsonProperty("collaborator")]
        public object[] Collaborator { get; set; }
    }

    public class LeadSponsor
    {
        [JsonProperty("agency")]
        public string Agency { get; set; }

        [JsonProperty("agency_class")]
        public string[] AgencyClass { get; set; }
    }

    public class StudyDesign
    {
        [JsonProperty("allocation")]
        public string Allocation { get; set; }

        [JsonProperty("intervention_model")]
        public string InterventionModel { get; set; }

        [JsonProperty("primary_purpose")]
        public string PrimaryPurpose { get; set; }

        [JsonProperty("masking")]
        public string Masking { get; set; }

        [JsonProperty("intervention_model_description")]
        public object InterventionModelDescription { get; set; }

        [JsonProperty("observational_model")]
        public object ObservationalModel { get; set; }

        [JsonProperty("time_perspective")]
        public object TimePerspective { get; set; }

        [JsonProperty("masking_description")]
        public object MaskingDescription { get; set; }
    }

    public class Synonym
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}