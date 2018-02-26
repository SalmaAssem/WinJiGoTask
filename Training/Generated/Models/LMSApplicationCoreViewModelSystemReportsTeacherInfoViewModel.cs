// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelSystemReportsTeacherInfoViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsTeacherInfoViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsTeacherInfoViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsTeacherInfoViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsTeacherInfoViewModel(int? id = default(int?), string fullName = default(string), string email = default(string), string schoolId = default(string), string schoolName = default(string), int? courses = default(int?), System.DateTime? joinDate = default(System.DateTime?), int? numberOfLearners = default(int?), int? numberOfMaterials = default(int?), int? numberOfActivities = default(int?), int? numberOfQuizes = default(int?), int? discussionsCount = default(int?), System.DateTime? lastLoginDate = default(System.DateTime?))
        {
            Id = id;
            FullName = fullName;
            Email = email;
            SchoolId = schoolId;
            SchoolName = schoolName;
            Courses = courses;
            JoinDate = joinDate;
            NumberOfLearners = numberOfLearners;
            NumberOfMaterials = numberOfMaterials;
            NumberOfActivities = numberOfActivities;
            NumberOfQuizes = numberOfQuizes;
            DiscussionsCount = discussionsCount;
            LastLoginDate = lastLoginDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FullName")]
        public string FullName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchoolId")]
        public string SchoolId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchoolName")]
        public string SchoolName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Courses")]
        public int? Courses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "JoinDate")]
        public System.DateTime? JoinDate { get; set; }

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
        [JsonProperty(PropertyName = "NumberOfQuizes")]
        public int? NumberOfQuizes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DiscussionsCount")]
        public int? DiscussionsCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastLoginDate")]
        public System.DateTime? LastLoginDate { get; set; }

    }
}
