// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsGradeBookAddCourseCategoryCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsGradeBookAddCourseCategoryCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsGradeBookAddCourseCategoryCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsGradeBookAddCourseCategoryCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsGradeBookAddCourseCategoryCommand(string gradeCategoryId = default(string), int? courseId = default(int?))
        {
            GradeCategoryId = gradeCategoryId;
            CourseId = courseId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradeCategoryId")]
        public string GradeCategoryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseId")]
        public int? CourseId { get; set; }

    }
}