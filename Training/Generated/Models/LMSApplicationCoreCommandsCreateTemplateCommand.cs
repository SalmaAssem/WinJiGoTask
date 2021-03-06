// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsCreateTemplateCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsCreateTemplateCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsCreateTemplateCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsCreateTemplateCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsCreateTemplateCommand(string id = default(string), string title = default(string), int? subjectId = default(int?), int? gradeId = default(int?), string body = default(string), int? status = default(int?), int? templateType = default(int?))
        {
            Id = id;
            Title = title;
            SubjectId = subjectId;
            GradeId = gradeId;
            Body = body;
            Status = status;
            TemplateType = templateType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubjectId")]
        public int? SubjectId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradeId")]
        public int? GradeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Body")]
        public string Body { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public int? Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TemplateType")]
        public int? TemplateType { get; set; }

    }
}
