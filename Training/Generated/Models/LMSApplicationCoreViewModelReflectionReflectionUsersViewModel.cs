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

    public partial class LMSApplicationCoreViewModelReflectionReflectionUsersViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelReflectionReflectionUsersViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelReflectionReflectionUsersViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelReflectionReflectionUsersViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelReflectionReflectionUsersViewModel(IList<LMSApplicationCoreViewModelUserProfileBasicInfoViewModel> reflectionUsers = default(IList<LMSApplicationCoreViewModelUserProfileBasicInfoViewModel>), int? totalCount = default(int?))
        {
            ReflectionUsers = reflectionUsers;
            TotalCount = totalCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReflectionUsers")]
        public IList<LMSApplicationCoreViewModelUserProfileBasicInfoViewModel> ReflectionUsers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TotalCount")]
        public int? TotalCount { get; set; }

    }
}