// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsOfficeAddInOfficeAddInSubmitHandOutCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsOfficeAddInOfficeAddInSubmitHandOutCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsOfficeAddInOfficeAddInSubmitHandOutCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsOfficeAddInOfficeAddInSubmitHandOutCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsOfficeAddInOfficeAddInSubmitHandOutCommand(int? assessmentId = default(int?), string assessmentTitle = default(string), string assessmentMaterialId = default(string), int? courseId = default(int?), byte[] fileData = default(byte[]), string fileNameWithExtension = default(string), string comment = default(string))
        {
            AssessmentId = assessmentId;
            AssessmentTitle = assessmentTitle;
            AssessmentMaterialId = assessmentMaterialId;
            CourseId = courseId;
            FileData = fileData;
            FileNameWithExtension = fileNameWithExtension;
            Comment = comment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssessmentId")]
        public int? AssessmentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssessmentTitle")]
        public string AssessmentTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssessmentMaterialId")]
        public string AssessmentMaterialId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseId")]
        public int? CourseId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FileData")]
        public byte[] FileData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FileNameWithExtension")]
        public string FileNameWithExtension { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Comment")]
        public string Comment { get; set; }

    }
}
