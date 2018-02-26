// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelStudentsLearnerAssessmentViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelStudentsLearnerAssessmentViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelStudentsLearnerAssessmentViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelStudentsLearnerAssessmentViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelStudentsLearnerAssessmentViewModel(string assessmentId = default(string), string title = default(string), string description = default(string), double? totalScore = default(double?), double? passingScore = default(double?), string type = default(string), string practiceType = default(string), System.DateTime? dueDate = default(System.DateTime?), bool? allowLateSubmission = default(bool?), string learnerSubmissionStatus = default(string), double? learnerScore = default(double?), string sessionTitle = default(string), System.DateTime? sessionDate = default(System.DateTime?), string sessionId = default(string), int? sessionLockStatus = default(int?), int? learnerId = default(int?), bool? isGraded = default(bool?), bool? isFinalAssessment = default(bool?))
        {
            AssessmentId = assessmentId;
            Title = title;
            Description = description;
            TotalScore = totalScore;
            PassingScore = passingScore;
            Type = type;
            PracticeType = practiceType;
            DueDate = dueDate;
            AllowLateSubmission = allowLateSubmission;
            LearnerSubmissionStatus = learnerSubmissionStatus;
            LearnerScore = learnerScore;
            SessionTitle = sessionTitle;
            SessionDate = sessionDate;
            SessionId = sessionId;
            SessionLockStatus = sessionLockStatus;
            LearnerId = learnerId;
            IsGraded = isGraded;
            IsFinalAssessment = isFinalAssessment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssessmentId")]
        public string AssessmentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TotalScore")]
        public double? TotalScore { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PassingScore")]
        public double? PassingScore { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PracticeType")]
        public string PracticeType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DueDate")]
        public System.DateTime? DueDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllowLateSubmission")]
        public bool? AllowLateSubmission { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LearnerSubmissionStatus")]
        public string LearnerSubmissionStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LearnerScore")]
        public double? LearnerScore { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SessionTitle")]
        public string SessionTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SessionDate")]
        public System.DateTime? SessionDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SessionLockStatus")]
        public int? SessionLockStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LearnerId")]
        public int? LearnerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsGraded")]
        public bool? IsGraded { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsFinalAssessment")]
        public bool? IsFinalAssessment { get; set; }

    }
}