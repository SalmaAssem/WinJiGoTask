// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class LMSDomainCoreModelsUser
    {
        /// <summary>
        /// Initializes a new instance of the LMSDomainCoreModelsUser class.
        /// </summary>
        public LMSDomainCoreModelsUser()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LMSDomainCoreModelsUser class.
        /// </summary>
        public LMSDomainCoreModelsUser(string email, int? id = default(int?), string firstName = default(string), string lastName = default(string), System.DateTime? registrationDate = default(System.DateTime?), IList<LMSDomainCoreModelsRole> roles = default(IList<LMSDomainCoreModelsRole>), string identityUserId = default(string), int? gradeId = default(int?), LMSDomainCoreModelsGrade grade = default(LMSDomainCoreModelsGrade), int? titleId = default(int?), LMSDomainCoreModelsTitle title = default(LMSDomainCoreModelsTitle), System.DateTime? lastLoginTime = default(System.DateTime?), int? loginsCount = default(int?), string parentAccessCode = default(string), LMSDomainCoreModelsUserProfile userProfile = default(LMSDomainCoreModelsUserProfile), IList<LMSDomainCoreModelsUserPrivacy> userPrivacies = default(IList<LMSDomainCoreModelsUserPrivacy>), string externalUserId = default(string), System.DateTime? lastInactiveMail = default(System.DateTime?), int? provisionedUserStatus = default(int?), bool? isActive = default(bool?), bool? isPrefered = default(bool?), string notificationEmail = default(string), string fullName = default(string))
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            RegistrationDate = registrationDate;
            Roles = roles;
            IdentityUserId = identityUserId;
            GradeId = gradeId;
            Grade = grade;
            TitleId = titleId;
            Title = title;
            LastLoginTime = lastLoginTime;
            LoginsCount = loginsCount;
            ParentAccessCode = parentAccessCode;
            UserProfile = userProfile;
            UserPrivacies = userPrivacies;
            ExternalUserId = externalUserId;
            LastInactiveMail = lastInactiveMail;
            ProvisionedUserStatus = provisionedUserStatus;
            IsActive = isActive;
            IsPrefered = isPrefered;
            NotificationEmail = notificationEmail;
            FullName = fullName;
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
        [JsonProperty(PropertyName = "FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastName")]
        public string LastName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RegistrationDate")]
        public System.DateTime? RegistrationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Roles")]
        public IList<LMSDomainCoreModelsRole> Roles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IdentityUserId")]
        public string IdentityUserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradeId")]
        public int? GradeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Grade")]
        public LMSDomainCoreModelsGrade Grade { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TitleId")]
        public int? TitleId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public LMSDomainCoreModelsTitle Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastLoginTime")]
        public System.DateTime? LastLoginTime { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LoginsCount")]
        public int? LoginsCount { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ParentAccessCode")]
        public string ParentAccessCode { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserProfile")]
        public LMSDomainCoreModelsUserProfile UserProfile { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserPrivacies")]
        public IList<LMSDomainCoreModelsUserPrivacy> UserPrivacies { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExternalUserId")]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastInactiveMail")]
        public System.DateTime? LastInactiveMail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProvisionedUserStatus")]
        public int? ProvisionedUserStatus { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsPrefered")]
        public bool? IsPrefered { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NotificationEmail")]
        public string NotificationEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FullName")]
        public string FullName { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Email == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Email");
            }
            if (Grade != null)
            {
                Grade.Validate();
            }
            if (Title != null)
            {
                Title.Validate();
            }
            if (UserProfile != null)
            {
                UserProfile.Validate();
            }
        }
    }
}