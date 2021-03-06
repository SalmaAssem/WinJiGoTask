// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelSystemReportsTraineesAllActivitiesProgressViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsTraineesAllActivitiesProgressViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsTraineesAllActivitiesProgressViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsTraineesAllActivitiesProgressViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsTraineesAllActivitiesProgressViewModel(double? totalLearnersCount = default(double?), double? totalGrade = default(double?), double? userGrade = default(double?), double? allAssessmentsCount = default(double?), double? completedAssessments = default(double?), double? assignedAssessments = default(double?), double? allVideosCount = default(double?), double? completedVideos = default(double?), double? assignedVideos = default(double?), double? seenMaterialsNonVideos = default(double?), double? allMaterialsNonVideos = default(double?), double? allMaterialsCount = default(double?), double? seenMaterialsCount = default(double?), double? videoMaterialsCount = default(double?), double? seenVideosCount = default(double?), double? assessmentMaterialsCount = default(double?), double? seenAssessmentsCount = default(double?), double? otherMaterialsCount = default(double?), double? seenOtherMaterialsCount = default(double?), double? coursesCount = default(double?))
        {
            TotalLearnersCount = totalLearnersCount;
            TotalGrade = totalGrade;
            UserGrade = userGrade;
            AllAssessmentsCount = allAssessmentsCount;
            CompletedAssessments = completedAssessments;
            AssignedAssessments = assignedAssessments;
            AllVideosCount = allVideosCount;
            CompletedVideos = completedVideos;
            AssignedVideos = assignedVideos;
            SeenMaterialsNonVideos = seenMaterialsNonVideos;
            AllMaterialsNonVideos = allMaterialsNonVideos;
            AllMaterialsCount = allMaterialsCount;
            SeenMaterialsCount = seenMaterialsCount;
            VideoMaterialsCount = videoMaterialsCount;
            SeenVideosCount = seenVideosCount;
            AssessmentMaterialsCount = assessmentMaterialsCount;
            SeenAssessmentsCount = seenAssessmentsCount;
            OtherMaterialsCount = otherMaterialsCount;
            SeenOtherMaterialsCount = seenOtherMaterialsCount;
            CoursesCount = coursesCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TotalLearnersCount")]
        public double? TotalLearnersCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TotalGrade")]
        public double? TotalGrade { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserGrade")]
        public double? UserGrade { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllAssessmentsCount")]
        public double? AllAssessmentsCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CompletedAssessments")]
        public double? CompletedAssessments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssignedAssessments")]
        public double? AssignedAssessments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllVideosCount")]
        public double? AllVideosCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CompletedVideos")]
        public double? CompletedVideos { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssignedVideos")]
        public double? AssignedVideos { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SeenMaterialsNonVideos")]
        public double? SeenMaterialsNonVideos { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllMaterialsNonVideos")]
        public double? AllMaterialsNonVideos { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllMaterialsCount")]
        public double? AllMaterialsCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SeenMaterialsCount")]
        public double? SeenMaterialsCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "VideoMaterialsCount")]
        public double? VideoMaterialsCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SeenVideosCount")]
        public double? SeenVideosCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssessmentMaterialsCount")]
        public double? AssessmentMaterialsCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SeenAssessmentsCount")]
        public double? SeenAssessmentsCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OtherMaterialsCount")]
        public double? OtherMaterialsCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SeenOtherMaterialsCount")]
        public double? SeenOtherMaterialsCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CoursesCount")]
        public double? CoursesCount { get; set; }

    }
}
