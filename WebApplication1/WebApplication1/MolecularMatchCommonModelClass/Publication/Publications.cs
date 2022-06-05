using System;
using Newtonsoft.Json;

namespace WebApplication1.MolecularMatchCommonModelClass.Publication
{
    public class Publications
    {
        [JsonProperty("searchKey")]
        public string SearchKey { get; set; }

        [JsonProperty("institutionId")]
        public object InstitutionId { get; set; }

        [JsonProperty("caseId")]
        public object CaseId { get; set; }

        [JsonProperty("showingResultsFor")]
        public ShowingResultsFor ShowingResultsFor { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("totalPages")]
        public long TotalPages { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("rows")]
        public Row[] Rows { get; set; }

        [JsonProperty("searchInsteadFor")]
        public object[] SearchInsteadFor { get; set; }

        [JsonProperty("lastUpdated")]
        public DateTimeOffset LastUpdated { get; set; }
    }

    public class Row
    {
        [JsonProperty("_score")]
        public double Score { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("journalName")]
        public string JournalName { get; set; }

        [JsonProperty("journalISOAbbreviation")]
        public string JournalIsoAbbreviation { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("purpose", NullValueHandling = NullValueHandling.Ignore)]
        public string Purpose { get; set; }

        [JsonProperty("methods")]
        public string Methods { get; set; }

        [JsonProperty("results")]
        public string Results { get; set; }

        [JsonProperty("conclusion")]
        public string Conclusion { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("citation")]
        public string Citation { get; set; }

        [JsonProperty("citation_date")]
        public DateTimeOffset CitationDate { get; set; }

        [JsonProperty("link")]
        public Uri Link { get; set; }

        [JsonProperty("chemicals")]
        public string[] Chemicals { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("publicationType")]
        public string[] PublicationType { get; set; }

        [JsonProperty("authors")]
        public Author[] Authors { get; set; }

        [JsonProperty("molecularAlterations")]
        public MolecularAlteration[] MolecularAlterations { get; set; }

        [JsonProperty("missing")]
        public PublicationMissing[] Missing { get; set; }

        [JsonProperty("matching")]
        public PublicationMatching[] Matching { get; set; }

        [JsonProperty("_scoring")]
        public object[] Scoring { get; set; }

        [JsonProperty("background", NullValueHandling = NullValueHandling.Ignore)]
        public string Background { get; set; }
    }

    public class PublicationMatching
    {
        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("rootTerm")]
        public string RootTerm { get; set; }

        [JsonProperty("facet")]
        public string Facet { get; set; }

        [JsonProperty("filterType")]
        public string FilterType { get; set; }

        [JsonProperty("relationship")]
        public string Relationship { get; set; }

        [JsonProperty("explanation")]
        public string Explanation { get; set; }

        public string IndirectMatching { get; set; }

        public string DirectMatching { get; set; }
    }

    public class Author
    {
        [JsonProperty("collectiveName")]
        public object CollectiveName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("affiliation")]
        public string Affiliation { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }
    }

    public class ShowingResultsFor
    {
        [JsonProperty("rationalized")]
        public Ized[] Rationalized { get; set; }

        [JsonProperty("unrecognized")]
        public Ized[] Unrecognized { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class Ized
    {
        [JsonProperty("facet")]
        public string Facet { get; set; }

        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("filterType")]
        public string FilterType { get; set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }
    }

    public class MolecularAlteration
    {
        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("facet")]
        public string Facet { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }
    }

    public class PublicationDetails
    {
        [JsonProperty("journalName")]
        public string JournalName { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("citation")]
        public string Citation { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("methods")]
        public string Methods { get; set; }

        [JsonProperty("link")]
        public Uri Link { get; set; }

        [JsonProperty("publicationType")]
        public string[] PublicationType { get; set; }

        [JsonProperty("journalISOAbbreviation")]
        public string JournalIsoAbbreviation { get; set; }

        [JsonProperty("citation_date")]
        public DateTimeOffset CitationDate { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("conclusion")]
        public string Conclusion { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("chemicals")]
        public string[] Chemicals { get; set; }

        [JsonProperty("results")]
        public string Results { get; set; }

        [JsonProperty("authors")]
        public Author[] Authors { get; set; }
    }

    public class PublicationMissing
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
}