// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsNotiificationsActivitySubmitCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsNotiificationsActivitySubmitCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsNotiificationsActivitySubmitCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsNotiificationsActivitySubmitCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsNotiificationsActivitySubmitCommand(int? courseId = default(int?), string activityTitle = default(string), string assessmentMaterialId = default(string), int? assessmentMode = default(int?))
        {
            CourseId = courseId;
            ActivityTitle = activityTitle;
            AssessmentMaterialId = assessmentMaterialId;
            AssessmentMode = assessmentMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseId")]
        public int? CourseId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActivityTitle")]
        public string ActivityTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssessmentMaterialId")]
        public string AssessmentMaterialId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssessmentMode")]
        public int? AssessmentMode { get; set; }

    }
}
