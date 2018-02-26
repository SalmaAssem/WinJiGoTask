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

    public partial class LMSApplicationCoreViewModelReportCourseInfoReportViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelReportCourseInfoReportViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelReportCourseInfoReportViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelReportCourseInfoReportViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelReportCourseInfoReportViewModel(int? courseId = default(int?), string courseName = default(string), string subject = default(string), string grade = default(string), string teacherName = default(string), int? teacherId = default(int?), IList<LMSApplicationCoreViewModelInstructorViewModel> instructors = default(IList<LMSApplicationCoreViewModelInstructorViewModel>), int? numberOfLearners = default(int?), string schoolName = default(string), int? numberOfRounds = default(int?), int? noOfVisitors = default(int?), int? noOfMaterials = default(int?), int? certificatesCount = default(int?), bool? isCertificateEnabled = default(bool?), int? launchedDays = default(int?), double? complationDuration = default(double?), string allInstructorNames = default(string))
        {
            CourseId = courseId;
            CourseName = courseName;
            Subject = subject;
            Grade = grade;
            TeacherName = teacherName;
            TeacherId = teacherId;
            Instructors = instructors;
            NumberOfLearners = numberOfLearners;
            SchoolName = schoolName;
            NumberOfRounds = numberOfRounds;
            NoOfVisitors = noOfVisitors;
            NoOfMaterials = noOfMaterials;
            CertificatesCount = certificatesCount;
            IsCertificateEnabled = isCertificateEnabled;
            LaunchedDays = launchedDays;
            ComplationDuration = complationDuration;
            AllInstructorNames = allInstructorNames;
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
        [JsonProperty(PropertyName = "CourseName")]
        public string CourseName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Subject")]
        public string Subject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Grade")]
        public string Grade { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TeacherName")]
        public string TeacherName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TeacherId")]
        public int? TeacherId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Instructors")]
        public IList<LMSApplicationCoreViewModelInstructorViewModel> Instructors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfLearners")]
        public int? NumberOfLearners { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchoolName")]
        public string SchoolName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfRounds")]
        public int? NumberOfRounds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NoOfVisitors")]
        public int? NoOfVisitors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NoOfMaterials")]
        public int? NoOfMaterials { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CertificatesCount")]
        public int? CertificatesCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCertificateEnabled")]
        public bool? IsCertificateEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LaunchedDays")]
        public int? LaunchedDays { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ComplationDuration")]
        public double? ComplationDuration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllInstructorNames")]
        public string AllInstructorNames { get; private set; }

    }
}
