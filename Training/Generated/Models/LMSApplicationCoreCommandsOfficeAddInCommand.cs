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

    public partial class LMSApplicationCoreCommandsOfficeAddInCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsOfficeAddInCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsOfficeAddInCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsOfficeAddInCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsOfficeAddInCommand(string activityName = default(string), string description = default(string), int? courseId = default(int?), string sessionId = default(string), bool? isActive = default(bool?), int? grade = default(int?), double? passingScore = default(double?), int? assessmentStatus = default(int?), bool? isSpecificAssignees = default(bool?), IList<int?> assigneesIds = default(IList<int?>), string fileNameWithExtension = default(string), byte[] fileData = default(byte[]), System.DateTime? dueDate = default(System.DateTime?), bool? allowLateSubmission = default(bool?))
        {
            ActivityName = activityName;
            Description = description;
            CourseId = courseId;
            SessionId = sessionId;
            IsActive = isActive;
            Grade = grade;
            PassingScore = passingScore;
            AssessmentStatus = assessmentStatus;
            IsSpecificAssignees = isSpecificAssignees;
            AssigneesIds = assigneesIds;
            FileNameWithExtension = fileNameWithExtension;
            FileData = fileData;
            DueDate = dueDate;
            AllowLateSubmission = allowLateSubmission;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActivityName")]
        public string ActivityName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

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
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Grade")]
        public int? Grade { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PassingScore")]
        public double? PassingScore { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssessmentStatus")]
        public int? AssessmentStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsSpecificAssignees")]
        public bool? IsSpecificAssignees { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssigneesIds")]
        public IList<int?> AssigneesIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FileNameWithExtension")]
        public string FileNameWithExtension { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FileData")]
        public byte[] FileData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DueDate")]
        public System.DateTime? DueDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllowLateSubmission")]
        public bool? AllowLateSubmission { get; set; }

    }
}
