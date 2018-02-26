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

    public partial class LMSApplicationCoreViewModelSystemReportsTopVisitedViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsTopVisitedViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsTopVisitedViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsTopVisitedViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsTopVisitedViewModel(IList<LMSDomainCoreViewModelsTopVisitedCourseGroup> courseGroupVisited = default(IList<LMSDomainCoreViewModelsTopVisitedCourseGroup>), int? totalVisitsCount = default(int?))
        {
            CourseGroupVisited = courseGroupVisited;
            TotalVisitsCount = totalVisitsCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseGroupVisited")]
        public IList<LMSDomainCoreViewModelsTopVisitedCourseGroup> CourseGroupVisited { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TotalVisitsCount")]
        public int? TotalVisitsCount { get; set; }

    }
}
