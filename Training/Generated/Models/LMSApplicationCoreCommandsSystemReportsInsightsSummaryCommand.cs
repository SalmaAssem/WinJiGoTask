// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsSystemReportsInsightsSummaryCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsSystemReportsInsightsSummaryCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsSystemReportsInsightsSummaryCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsSystemReportsInsightsSummaryCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsSystemReportsInsightsSummaryCommand(string organizationId = default(string), string schoolId = default(string), int? dateDuration = default(int?), System.DateTime? durationStartDate = default(System.DateTime?), System.DateTime? durationEndDate = default(System.DateTime?), bool? applyOnSubSchools = default(bool?))
        {
            OrganizationId = organizationId;
            SchoolId = schoolId;
            DateDuration = dateDuration;
            DurationStartDate = durationStartDate;
            DurationEndDate = durationEndDate;
            ApplyOnSubSchools = applyOnSubSchools;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationId")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchoolId")]
        public string SchoolId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DateDuration")]
        public int? DateDuration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DurationStartDate")]
        public System.DateTime? DurationStartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DurationEndDate")]
        public System.DateTime? DurationEndDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ApplyOnSubSchools")]
        public bool? ApplyOnSubSchools { get; set; }

    }
}
