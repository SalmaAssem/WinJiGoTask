// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelReportOverallReportViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelReportOverallReportViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelReportOverallReportViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelReportOverallReportViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelReportOverallReportViewModel(int? numberOfAllSessions = default(int?), int? numberOfActiveSessions = default(int?), int? numberOfActivities = default(int?), int? numberOfDiscussions = default(int?), int? numberOfAllPosts = default(int?), int? numberOfAssignedBadges = default(int?))
        {
            NumberOfAllSessions = numberOfAllSessions;
            NumberOfActiveSessions = numberOfActiveSessions;
            NumberOfActivities = numberOfActivities;
            NumberOfDiscussions = numberOfDiscussions;
            NumberOfAllPosts = numberOfAllPosts;
            NumberOfAssignedBadges = numberOfAssignedBadges;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfAllSessions")]
        public int? NumberOfAllSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfActiveSessions")]
        public int? NumberOfActiveSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfActivities")]
        public int? NumberOfActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfDiscussions")]
        public int? NumberOfDiscussions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfAllPosts")]
        public int? NumberOfAllPosts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfAssignedBadges")]
        public int? NumberOfAssignedBadges { get; set; }

    }
}
