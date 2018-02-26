// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsSessionLessonPlanCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsSessionLessonPlanCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsSessionLessonPlanCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsSessionLessonPlanCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsSessionLessonPlanCommand(int? courseId = default(int?), string sessionId = default(string), string templateId = default(string), string body = default(string))
        {
            CourseId = courseId;
            SessionId = sessionId;
            TemplateId = templateId;
            Body = body;
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
        [JsonProperty(PropertyName = "SessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TemplateId")]
        public string TemplateId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Body")]
        public string Body { get; set; }

    }
}