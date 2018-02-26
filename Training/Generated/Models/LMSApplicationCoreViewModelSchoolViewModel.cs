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

    public partial class LMSApplicationCoreViewModelSchoolViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSchoolViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelSchoolViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSchoolViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelSchoolViewModel(int? totalCount = default(int?), IList<LMSApplicationCoreViewModelSchoolInfo> schoolsInfo = default(IList<LMSApplicationCoreViewModelSchoolInfo>))
        {
            TotalCount = totalCount;
            SchoolsInfo = schoolsInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TotalCount")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchoolsInfo")]
        public IList<LMSApplicationCoreViewModelSchoolInfo> SchoolsInfo { get; set; }

    }
}