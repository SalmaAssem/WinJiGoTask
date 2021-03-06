// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSDomainCoreModelsOffice365OrganizationUser
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSDomainCoreModelsOffice365OrganizationUser class.
        /// </summary>
        public LMSDomainCoreModelsOffice365OrganizationUser()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSDomainCoreModelsOffice365OrganizationUser class.
        /// </summary>
        public LMSDomainCoreModelsOffice365OrganizationUser(string organizationId, int userId, int roleId, string userObjectId = default(string), string nameIdentifer = default(string), LMSDomainCoreModelsOffice365Organization organization = default(LMSDomainCoreModelsOffice365Organization), LMSDomainCoreModelsUser user = default(LMSDomainCoreModelsUser), LMSDomainCoreModelsRole role = default(LMSDomainCoreModelsRole), string organizationSchoolId = default(string), bool? isDeleted = default(bool?), LMSDomainCoreModelsOffice365OrganizationSchool organizationSchool = default(LMSDomainCoreModelsOffice365OrganizationSchool), string id = default(string))
        {
            OrganizationId = organizationId;
            UserId = userId;
            RoleId = roleId;
            UserObjectId = userObjectId;
            NameIdentifer = nameIdentifer;
            Organization = organization;
            User = user;
            Role = role;
            OrganizationSchoolId = organizationSchoolId;
            IsDeleted = isDeleted;
            OrganizationSchool = organizationSchool;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationId")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public int UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RoleId")]
        public int RoleId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserObjectId")]
        public string UserObjectId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NameIdentifer")]
        public string NameIdentifer { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Organization")]
        public LMSDomainCoreModelsOffice365Organization Organization { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "User")]
        public LMSDomainCoreModelsUser User { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Role")]
        public LMSDomainCoreModelsRole Role { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationSchoolId")]
        public string OrganizationSchoolId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsDeleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationSchool")]
        public LMSDomainCoreModelsOffice365OrganizationSchool OrganizationSchool { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (OrganizationId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OrganizationId");
            }
            if (Organization != null)
            {
                Organization.Validate();
            }
            if (User != null)
            {
                User.Validate();
            }
            if (OrganizationSchool != null)
            {
                OrganizationSchool.Validate();
            }
        }
    }
}
