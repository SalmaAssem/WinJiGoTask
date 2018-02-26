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

    public partial class LMSApplicationCoreViewModelUserSettingsViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelUserSettingsViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelUserSettingsViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelUserSettingsViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelUserSettingsViewModel(string prefferedLanguageName = default(string), string prefferedCalendarName = default(string), string prefferedLanguage = default(string), string prefferedRole = default(string), int? prefferedCalendar = default(int?), string roleName = default(string), IList<string> supportedNotificationTypes = default(IList<string>), bool? isStudent = default(bool?), bool? isRoundEnabled = default(bool?), bool? isOrgUser = default(bool?), bool? needToRestPassword = default(bool?), bool? isUserLicenseExpire = default(bool?), string offeringType = default(string), string offeringName = default(string), string prefferedRoleName = default(string))
        {
            PrefferedLanguageName = prefferedLanguageName;
            PrefferedCalendarName = prefferedCalendarName;
            PrefferedLanguage = prefferedLanguage;
            PrefferedRole = prefferedRole;
            PrefferedCalendar = prefferedCalendar;
            RoleName = roleName;
            SupportedNotificationTypes = supportedNotificationTypes;
            IsStudent = isStudent;
            IsRoundEnabled = isRoundEnabled;
            IsOrgUser = isOrgUser;
            NeedToRestPassword = needToRestPassword;
            IsUserLicenseExpire = isUserLicenseExpire;
            OfferingType = offeringType;
            OfferingName = offeringName;
            PrefferedRoleName = prefferedRoleName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrefferedLanguageName")]
        public string PrefferedLanguageName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrefferedCalendarName")]
        public string PrefferedCalendarName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrefferedLanguage")]
        public string PrefferedLanguage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrefferedRole")]
        public string PrefferedRole { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrefferedCalendar")]
        public int? PrefferedCalendar { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RoleName")]
        public string RoleName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SupportedNotificationTypes")]
        public IList<string> SupportedNotificationTypes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsStudent")]
        public bool? IsStudent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsRoundEnabled")]
        public bool? IsRoundEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsOrgUser")]
        public bool? IsOrgUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NeedToRestPassword")]
        public bool? NeedToRestPassword { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsUserLicenseExpire")]
        public bool? IsUserLicenseExpire { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OfferingType")]
        public string OfferingType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OfferingName")]
        public string OfferingName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrefferedRoleName")]
        public string PrefferedRoleName { get; set; }

    }
}