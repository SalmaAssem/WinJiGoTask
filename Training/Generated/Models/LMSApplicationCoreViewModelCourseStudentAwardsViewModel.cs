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

    public partial class LMSApplicationCoreViewModelCourseStudentAwardsViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelCourseStudentAwardsViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelCourseStudentAwardsViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelCourseStudentAwardsViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelCourseStudentAwardsViewModel(string fullName = default(string), string profilePictureUrl = default(string), int? userId = default(int?), IList<LMSApplicationCoreViewModelAwardViewModel> awards = default(IList<LMSApplicationCoreViewModelAwardViewModel>), string grade = default(string), string profilePictureUrlSmall = default(string), int? totalNumberOfPoints = default(int?), int? totalNumberOfBadges = default(int?))
        {
            FullName = fullName;
            ProfilePictureUrl = profilePictureUrl;
            UserId = userId;
            Awards = awards;
            Grade = grade;
            ProfilePictureUrlSmall = profilePictureUrlSmall;
            TotalNumberOfPoints = totalNumberOfPoints;
            TotalNumberOfBadges = totalNumberOfBadges;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FullName")]
        public string FullName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProfilePictureUrl")]
        public string ProfilePictureUrl { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public int? UserId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Awards")]
        public IList<LMSApplicationCoreViewModelAwardViewModel> Awards { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Grade")]
        public string Grade { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProfilePictureUrlSmall")]
        public string ProfilePictureUrlSmall { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TotalNumberOfPoints")]
        public int? TotalNumberOfPoints { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TotalNumberOfBadges")]
        public int? TotalNumberOfBadges { get; private set; }

    }
}