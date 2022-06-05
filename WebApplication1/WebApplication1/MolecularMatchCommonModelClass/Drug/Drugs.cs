using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace WebApplication1.MolecularMatchCommonModelClass.Drug
{
    public class Drugs
    {
        [JsonProperty("searchKey")]
        public string SearchKey { get; set; }

        [JsonProperty("institutionId")]
        public object InstitutionId { get; set; }

        [JsonProperty("caseId")]
        public object CaseId { get; set; }

        [JsonProperty("tieringTemplate")]
        public string TieringTemplate { get; set; }

        [JsonProperty("tieringTemplateLegend")]
        public TieringTemplateLegend TieringTemplateLegend { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("totalPages")]
        public long TotalPages { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("rationalized")]
        public Rationalized[] Rationalized { get; set; }

        [JsonProperty("unrecognized")]
        public object[] Unrecognized { get; set; }

        [JsonProperty("filterNarrative")]
        public string FilterNarrative { get; set; }

        [JsonProperty("ambiguousNarrative")]
        public object[] AmbiguousNarrative { get; set; }

        [JsonProperty("showingResultsFor")]
        public ShowingResultsFor ShowingResultsFor { get; set; }

        [JsonProperty("searchInsteadFor")]
        public object[] SearchInsteadFor { get; set; }

        [JsonProperty("rows")]
        public Row[] Rows { get; set; }
    }

    public partial class ShowingResultsFor
    {
        [JsonProperty("rationalized")]
        public Rationalized[] Rationalized { get; set; }

        [JsonProperty("unrecognized")]
        public Unrecognized[] Unrecognized { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public partial class Rationalized
    {
        [JsonProperty("facet")]
        public string Facet { get; set; }

        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("filterType")]
        public string FilterType { get; set; }

        [JsonProperty("rootTerm")]
        public string RootTerm { get; set; }
    }

    public partial class Row
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("synonyms")]
        public Synonym[] Synonyms { get; set; }

        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("brands")]
        public Brand[] Brands { get; set; }

        [JsonProperty("externalIds")]
        public ExternalId[] ExternalIds { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("pharmacology")]
        public Pharmacology Pharmacology { get; set; }

        [JsonProperty("prices")]
        public object[] Prices { get; set; }

        [JsonProperty("dosages")]
        public object[] Dosages { get; set; }

        [JsonProperty("availability")]
        public Availability[] Availability { get; set; }

        [JsonProperty("drugclass")]
        public Drugclass[] Drugclass { get; set; }

        [JsonProperty("molecularAlterations")]
        public Alteration[] MolecularAlterations { get; set; }

        [JsonProperty("contraindicatedAlterations")]
        public Alteration[] ContraindicatedAlterations { get; set; }

        [JsonProperty("_score")]
        public long Score { get; set; }

        [JsonProperty("assertions", NullValueHandling = NullValueHandling.Ignore)]
        public Assertion[] Assertions { get; set; }

        [JsonProperty("bestTier")]
        public string BestTier { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        ////[JsonProperty("metTier")]
        ////public string MetTier { get; set; }

        [JsonProperty("metTier")]
        public string MetTier
        {
            get
            {
                return this.Tier;
            }
        }

        public bool IsResistance
        {
            get
            {
                if (!string.IsNullOrEmpty(this.MetTier) && this.Assertions != null && !this.Assertions.Any(x => x.CriteriaUnmet.Any()) && this.Assertions.Any(x => x.ClinicalSignificance != null && x.ClinicalSignificance.ToLower().Trim() == "resistant"))
                {
                    return true;
                }

                return false;
            }
        }

        public string CustomDrugID { get; set; }
    }

    public class Assertion
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("clinicalSignificance")]
        public string ClinicalSignificance { get; set; }

        [JsonProperty("criteriaUnmet")]
        public Unrecognized[] CriteriaUnmet { get; set; }

        [JsonProperty("biomarkerClass")]
        public string Biomarker { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("sources")]
        public Source[] Sources { get; set; }

        [JsonProperty("variantInfo")]
        public VariantInfo[] VarianInfos { get; set; }

        [JsonProperty("prevalence")]
        public Prevalence[] Prevalences { get; set; }

    }

    public class Unrecognized
    {
        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("facet")]
        public string Facet { get; set; }

        [JsonProperty("filterType")]
        public string FilterType { get; set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }
    }

    public class Source
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pubId")]
        public string PubId { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("subType")]
        public string SubType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class VariantInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gene")]
        public string Gene { get; set; }

        [JsonProperty("transcript")]
        public string Transcript { get; set; }

        [JsonProperty("consequences")]
        public string[] Consequences { get; set; }

        [JsonProperty("popFreqMax")]
        public double PopFreqMax { get; set; }

        [JsonProperty("COSMIC_ID")]
        public string CosmicId { get; set; }

        [JsonProperty("locations")]
        public Location[] Locations { get; set; }
    }

    public class Location
    {
        [JsonProperty("amino_acid_change")]
        public string ProteinChange { get; set; }

        [JsonProperty("cdna")]
        public string CDNAChange { get; set; }

        [JsonProperty("chr")]
        public string Chromosome { get; set; }

        [JsonProperty("alt")]
        public string Alt { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("stop")]
        public string Stop { get; set; }

        [JsonProperty("strand")]
        public string Strand { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("exonNumber")]
        public string[] ExonNumber { get; set; }

        [JsonProperty("intronNumber")]
        public string[] IntronNumber { get; set; }
    }

    public class Prevalence
    {
        [JsonProperty("count")]
        public string Cnt { get; set; }

        [JsonProperty("studyId")]
        public string StudyID { get; set; }

        [JsonProperty("percent")]
        public string Percent { get; set; }

        [JsonProperty("samples")]
        public string Samples { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

    }

    public class Pharmacology
    {
        [JsonProperty("route_of_elimination")]
        public string RouteOfElimination { get; set; }

        [JsonProperty("volume_of_distribution")]
        public string VolumeODistribution { get; set; }

        [JsonProperty("toxicity")]
        public string ToxiCity { get; set; }

        [JsonProperty("half_life")]
        public string HalfLife { get; set; }

        [JsonProperty("mechanism_of_action")]
        public string MechanismOfAction { get; set; }

        [JsonProperty("absorption")]
        public string Absorption { get; set; }

        [JsonProperty("pharmacodynamics")]
        public string PharmaCodynamics { get; set; }

        [JsonProperty("protein_binding")]
        public string ProteinBinding { get; set; }

        [JsonProperty("metabolism")]
        public string Metabolism { get; set; }

        [JsonProperty("indication")]
        public string Indication { get; set; }
    }

    public partial class Availability
    {
        [JsonProperty("pre_market_cancelled")]
        public bool PreMarketCancelled { get; set; }

        [JsonProperty("marketed_prescription")]
        public bool MarketedPrescription { get; set; }

        [JsonProperty("post_market_cancelled")]
        public bool PostMarketCancelled { get; set; }

        [JsonProperty("generic_available")]
        public bool GenericAvailable { get; set; }

        [JsonProperty("max_phase")]
        public long MaxPhase { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }
    }

    public partial class Brand
    {
        [JsonProperty("indications")]
        public string Indications { get; set; }

        [JsonProperty("compositeKey")]
        public string CompositeKey { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mechanism")]
        public string Mechanism { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }
    }

    public partial class Alteration
    {
        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("facet")]
        public string Facet { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }
    }

    public partial class Drugclass
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public partial class ExternalId
    {
        [JsonProperty("identifier")]
        public object Identifier { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class Synonym
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class TieringTemplateLegend
    {
        [JsonProperty("3")]
        public The1_A The3 { get; set; }

        [JsonProperty("4")]
        public The1_A The4 { get; set; }

        [JsonProperty("1A")]
        public The1_A The1A { get; set; }

        [JsonProperty("1B")]
        public The1_A The1B { get; set; }

        [JsonProperty("2C")]
        public The1_A The2C { get; set; }

        [JsonProperty("2D")]
        public The1_A The2D { get; set; }

        [JsonProperty("IND")]
        public The1_A IND { get; set; }

        [JsonProperty("NE")]
        public The1_A NE { get; set; }

        [JsonProperty("N/A")]
        public The1_A NA { get; set; }
    }

    public partial class The1_A
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}