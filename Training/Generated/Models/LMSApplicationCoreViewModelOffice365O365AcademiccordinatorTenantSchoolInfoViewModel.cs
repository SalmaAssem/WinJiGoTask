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

    public partial class LMSApplicationCoreViewModelOffice365O365AcademiccordinatorTenantSchoolInfoViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelOffice365O365AcademiccordinatorTenantSchoolInfoViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelOffice365O365AcademiccordinatorTenantSchoolInfoViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelOffice365O365AcademiccordinatorTenantSchoolInfoViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelOffice365O365AcademiccordinatorTenantSchoolInfoViewModel(string tenantName = default(string), string schoolName = default(string), string schoolId = default(string), bool? canApplyPermissionsOnSubSegements = default(bool?), LMSApplicationCoreViewModelOffice365O365TenantSchoolsViewModel school = default(LMSApplicationCoreViewModelOffice365O365TenantSchoolsViewModel), IList<LMSApplicationCoreViewModelOffice365O365TenantSchoolsViewModel> subSchools = default(IList<LMSApplicationCoreViewModelOffice365O365TenantSchoolsViewModel>), bool? isExternalUserIdEnabled = default(bool?))
        {
            TenantName = tenantName;
            SchoolName = schoolName;
            SchoolId = schoolId;
            CanApplyPermissionsOnSubSegements = canApplyPermissionsOnSubSegements;
            School = school;
            SubSchools = subSchools;
            IsExternalUserIdEnabled = isExternalUserIdEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TenantName")]
        public string TenantName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchoolName")]
        public string SchoolName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchoolId")]
        public string SchoolId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanApplyPermissionsOnSubSegements")]
        public bool? CanApplyPermissionsOnSubSegements { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "School")]
        public LMSApplicationCoreViewModelOffice365O365TenantSchoolsViewModel School { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubSchools")]
        public IList<LMSApplicationCoreViewModelOffice365O365TenantSchoolsViewModel> SubSchools { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsExternalUserIdEnabled")]
        public bool? IsExternalUserIdEnabled { get; set; }

    }
}