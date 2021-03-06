// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelOffice365CreateTenantViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelOffice365CreateTenantViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelOffice365CreateTenantViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelOffice365CreateTenantViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelOffice365CreateTenantViewModel(string organizationId = default(string), string organizationName = default(string), int? adminId = default(int?), string adminEmail = default(string), bool? isEmailAlreadyExist = default(bool?))
        {
            OrganizationId = organizationId;
            OrganizationName = organizationName;
            AdminId = adminId;
            AdminEmail = adminEmail;
            IsEmailAlreadyExist = isEmailAlreadyExist;
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
        [JsonProperty(PropertyName = "OrganizationName")]
        public string OrganizationName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AdminId")]
        public int? AdminId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AdminEmail")]
        public string AdminEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEmailAlreadyExist")]
        public bool? IsEmailAlreadyExist { get; set; }

    }
}
