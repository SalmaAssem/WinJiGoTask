// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelSystemReportsTraineesProgressViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsTraineesProgressViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsTraineesProgressViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsTraineesProgressViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsTraineesProgressViewModel(int? traineesCount = default(int?), int? traineesProgressTotalCount = default(int?), int? traineesCurrentlyEnrolledCount = default(int?), int? traineesPassedCount = default(int?), int? traineesFailedCount = default(int?), int? traineesInProgressCount = default(int?), IList<LMSApplicationCoreViewModelSystemReportsTraineesStatusViewModel> traineesStatuses = default(IList<LMSApplicationCoreViewModelSystemReportsTraineesStatusViewModel>))
        {
            TraineesCount = traineesCount;
            TraineesProgressTotalCount = traineesProgressTotalCount;
            TraineesCurrentlyEnrolledCount = traineesCurrentlyEnrolledCount;
            TraineesPassedCount = traineesPassedCount;
            TraineesFailedCount = traineesFailedCount;
            TraineesInProgressCount = traineesInProgressCount;
            TraineesStatuses = traineesStatuses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TraineesCount")]
        public int? TraineesCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TraineesProgressTotalCount")]
        public int? TraineesProgressTotalCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TraineesCurrentlyEnrolledCount")]
        public int? TraineesCurrentlyEnrolledCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TraineesPassedCount")]
        public int? TraineesPassedCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TraineesFailedCount")]
        public int? TraineesFailedCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TraineesInProgressCount")]
        public int? TraineesInProgressCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TraineesStatuses")]
        public IList<LMSApplicationCoreViewModelSystemReportsTraineesStatusViewModel> TraineesStatuses { get; set; }

    }
}
