// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelStudentsStudentViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelStudentsStudentViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelStudentsStudentViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelStudentsStudentViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelStudentsStudentViewModel(string code = default(string), string firstName = default(string), string familyName = default(string), string fullName = default(string), string email = default(string), string profilePictureUrl = default(string), string numberOfUpcomingActivitiesToday = default(string), double? presencePercent = default(double?), int? numberOfPositiveBehaviors = default(int?), int? numberOfNegativeBehaviors = default(int?), bool? isSelected = default(bool?))
        {
            Code = code;
            FirstName = firstName;
            FamilyName = familyName;
            FullName = fullName;
            Email = email;
            ProfilePictureUrl = profilePictureUrl;
            NumberOfUpcomingActivitiesToday = numberOfUpcomingActivitiesToday;
            PresencePercent = presencePercent;
            NumberOfPositiveBehaviors = numberOfPositiveBehaviors;
            NumberOfNegativeBehaviors = numberOfNegativeBehaviors;
            IsSelected = isSelected;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Code")]
        public string Code { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FirstName")]
        public string FirstName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FamilyName")]
        public string FamilyName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FullName")]
        public string FullName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProfilePictureUrl")]
        public string ProfilePictureUrl { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfUpcomingActivitiesToday")]
        public string NumberOfUpcomingActivitiesToday { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PresencePercent")]
        public double? PresencePercent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfPositiveBehaviors")]
        public int? NumberOfPositiveBehaviors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfNegativeBehaviors")]
        public int? NumberOfNegativeBehaviors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsSelected")]
        public bool? IsSelected { get; set; }

    }
}
