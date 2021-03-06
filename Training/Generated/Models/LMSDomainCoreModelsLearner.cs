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

    public partial class LMSDomainCoreModelsLearner
    {
        /// <summary>
        /// Initializes a new instance of the LMSDomainCoreModelsLearner class.
        /// </summary>
        public LMSDomainCoreModelsLearner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LMSDomainCoreModelsLearner class.
        /// </summary>
        public LMSDomainCoreModelsLearner(LMSDomainCoreModelsGrade grade = default(LMSDomainCoreModelsGrade), bool? isCertified = default(bool?), int? id = default(int?), string identityUserId = default(string), string firstName = default(string), string lastName = default(string), string profilePictureUrl = default(string), string email = default(string), string profilePictureUrlSmall = default(string), bool? isCurrentUser = default(bool?), bool? isActive = default(bool?), string role = default(string), int? roleId = default(int?), string category = default(string), bool? canManageMentees = default(bool?), LMSDomainCoreModelsTitle title = default(LMSDomainCoreModelsTitle), string fullName = default(string), IList<LMSDomainCoreModelsMemberCourse> courses = default(IList<LMSDomainCoreModelsMemberCourse>))
        {
            Grade = grade;
            IsCertified = isCertified;
            Id = id;
            IdentityUserId = identityUserId;
            FirstName = firstName;
            LastName = lastName;
            ProfilePictureUrl = profilePictureUrl;
            Email = email;
            ProfilePictureUrlSmall = profilePictureUrlSmall;
            IsCurrentUser = isCurrentUser;
            IsActive = isActive;
            Role = role;
            RoleId = roleId;
            Category = category;
            CanManageMentees = canManageMentees;
            Title = title;
            FullName = fullName;
            Courses = courses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Grade")]
        public LMSDomainCoreModelsGrade Grade { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCertified")]
        public bool? IsCertified { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IdentityUserId")]
        public string IdentityUserId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FirstName")]
        public string FirstName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastName")]
        public string LastName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProfilePictureUrl")]
        public string ProfilePictureUrl { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProfilePictureUrlSmall")]
        public string ProfilePictureUrlSmall { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCurrentUser")]
        public bool? IsCurrentUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Role")]
        public string Role { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RoleId")]
        public int? RoleId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanManageMentees")]
        public bool? CanManageMentees { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public LMSDomainCoreModelsTitle Title { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FullName")]
        public string FullName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Courses")]
        public IList<LMSDomainCoreModelsMemberCourse> Courses { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Grade != null)
            {
                Grade.Validate();
            }
            if (Title != null)
            {
                Title.Validate();
            }
        }
    }
}
