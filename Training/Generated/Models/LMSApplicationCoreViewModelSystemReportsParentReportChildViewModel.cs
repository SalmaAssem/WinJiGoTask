// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelSystemReportsParentReportChildViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsParentReportChildViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsParentReportChildViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsParentReportChildViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsParentReportChildViewModel(LMSApplicationCoreViewModelSystemReportsUserViewModel childBasicInfo = default(LMSApplicationCoreViewModelSystemReportsUserViewModel), double? presencePercent = default(double?), int? numberOfPositiveBehaviors = default(int?), int? numberOfNegativeBehaviors = default(int?))
        {
            ChildBasicInfo = childBasicInfo;
            PresencePercent = presencePercent;
            NumberOfPositiveBehaviors = numberOfPositiveBehaviors;
            NumberOfNegativeBehaviors = numberOfNegativeBehaviors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ChildBasicInfo")]
        public LMSApplicationCoreViewModelSystemReportsUserViewModel ChildBasicInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PresencePercent")]
        public double? PresencePercent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfPositiveBehaviors")]
        public int? NumberOfPositiveBehaviors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfNegativeBehaviors")]
        public int? NumberOfNegativeBehaviors { get; set; }

    }
}
