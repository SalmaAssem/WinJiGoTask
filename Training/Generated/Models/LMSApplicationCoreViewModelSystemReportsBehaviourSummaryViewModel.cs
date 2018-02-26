// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelSystemReportsBehaviourSummaryViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsBehaviourSummaryViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsBehaviourSummaryViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsBehaviourSummaryViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsBehaviourSummaryViewModel(string behaviourType = default(string), int? behaviourReasonsCount = default(int?))
        {
            BehaviourType = behaviourType;
            BehaviourReasonsCount = behaviourReasonsCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BehaviourType")]
        public string BehaviourType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BehaviourReasonsCount")]
        public int? BehaviourReasonsCount { get; set; }

    }
}