// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelSystemReportsTeacherReportCourseReportInfo
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsTeacherReportCourseReportInfo
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsTeacherReportCourseReportInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsTeacherReportCourseReportInfo
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsTeacherReportCourseReportInfo(int? courseStatus = default(int?), string courseName = default(string), int? courseId = default(int?), int? numberOfLearners = default(int?), int? numberOfMaterials = default(int?), int? numberOfActivities = default(int?), bool? isInstructorReplaced = default(bool?))
        {
            CourseStatus = courseStatus;
            CourseName = courseName;
            CourseId = courseId;
            NumberOfLearners = numberOfLearners;
            NumberOfMaterials = numberOfMaterials;
            NumberOfActivities = numberOfActivities;
            IsInstructorReplaced = isInstructorReplaced;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseStatus")]
        public int? CourseStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseName")]
        public string CourseName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseId")]
        public int? CourseId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfLearners")]
        public int? NumberOfLearners { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfMaterials")]
        public int? NumberOfMaterials { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfActivities")]
        public int? NumberOfActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsInstructorReplaced")]
        public bool? IsInstructorReplaced { get; set; }

    }
}