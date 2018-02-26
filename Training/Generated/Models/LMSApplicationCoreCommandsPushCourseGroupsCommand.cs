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

    public partial class LMSApplicationCoreCommandsPushCourseGroupsCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsPushCourseGroupsCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsPushCourseGroupsCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsPushCourseGroupsCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsPushCourseGroupsCommand(string organizationId = default(string), IList<LMSApplicationCoreViewModelCourseGroupToPushViewModel> courseGroups = default(IList<LMSApplicationCoreViewModelCourseGroupToPushViewModel>))
        {
            OrganizationId = organizationId;
            CourseGroups = courseGroups;
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
        [JsonProperty(PropertyName = "CourseGroups")]
        public IList<LMSApplicationCoreViewModelCourseGroupToPushViewModel> CourseGroups { get; set; }

    }
}