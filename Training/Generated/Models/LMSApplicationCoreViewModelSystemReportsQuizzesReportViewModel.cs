// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelSystemReportsQuizzesReportViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsQuizzesReportViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsQuizzesReportViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsQuizzesReportViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsQuizzesReportViewModel(int? totalTakenCount = default(int?), int? passedCount = default(int?), int? failedCount = default(int?), int? pendingGradingCount = default(int?), int? totalPublishedCount = default(int?), int? takenCount = default(int?))
        {
            TotalTakenCount = totalTakenCount;
            PassedCount = passedCount;
            FailedCount = failedCount;
            PendingGradingCount = pendingGradingCount;
            TotalPublishedCount = totalPublishedCount;
            TakenCount = takenCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TotalTakenCount")]
        public int? TotalTakenCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PassedCount")]
        public int? PassedCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FailedCount")]
        public int? FailedCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PendingGradingCount")]
        public int? PendingGradingCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TotalPublishedCount")]
        public int? TotalPublishedCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TakenCount")]
        public int? TakenCount { get; set; }

    }
}
