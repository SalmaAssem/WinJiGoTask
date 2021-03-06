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

    public partial class LMSDomainCoreModelsOffice365Organization
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSDomainCoreModelsOffice365Organization class.
        /// </summary>
        public LMSDomainCoreModelsOffice365Organization()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSDomainCoreModelsOffice365Organization class.
        /// </summary>
        public LMSDomainCoreModelsOffice365Organization(string displayName, bool isActive, int tenantType, string edushareUrl = default(string), string licenseKey = default(string), string logoPictureId = default(string), bool? allowExternalUsers = default(bool?), int? learnersAccessLevel = default(int?), bool? applyLogoForAllSchools = default(bool?), string themeName = default(string), string tenantNameInUrl = default(string), bool? hideWinjiLogo = default(bool?), IList<LMSDomainCoreModelsOffice365OrganizationUser> office365UserTenants = default(IList<LMSDomainCoreModelsOffice365OrganizationUser>), bool? enableTraineeAsInstructor = default(bool?), bool? isEnableRounds = default(bool?), bool? isEnableTracks = default(bool?), bool? isEnableChatBetweenLearners = default(bool?), bool? isEnableLearnersToAddSpace = default(bool?), bool? isEnableAttendance = default(bool?), bool? isEnableCustomizeAttendnaceStatusInSegments = default(bool?), bool? isCertificateEnabled = default(bool?), string customThemeColors = default(string), string extraOffering = default(string), IList<LMSDomainCoreModelsAttendancesOrganizationSchoolAttendanceStatus> organizationSchoolAttendanceStatus = default(IList<LMSDomainCoreModelsAttendancesOrganizationSchoolAttendanceStatus>), bool? disableSwitchNotifications = default(bool?), bool? isEnableTimeTable = default(bool?), bool? isEnableGradebook = default(bool?), bool? isEnableScoreSheet = default(bool?), bool? isEnableGradebookCustomization = default(bool?), int? attendanceActiveMode = default(int?), string holidayFileId = default(string), bool? isEnableHelpFiles = default(bool?), bool? isEnableExternalUserId = default(bool?), System.DateTime? creationDate = default(System.DateTime?), int? createdBy = default(int?), System.DateTime? lastModificationDate = default(System.DateTime?), int? modifiedBy = default(int?), string id = default(string))
        {
            DisplayName = displayName;
            EdushareUrl = edushareUrl;
            LicenseKey = licenseKey;
            LogoPictureId = logoPictureId;
            AllowExternalUsers = allowExternalUsers;
            LearnersAccessLevel = learnersAccessLevel;
            ApplyLogoForAllSchools = applyLogoForAllSchools;
            ThemeName = themeName;
            IsActive = isActive;
            TenantNameInUrl = tenantNameInUrl;
            HideWinjiLogo = hideWinjiLogo;
            Office365UserTenants = office365UserTenants;
            EnableTraineeAsInstructor = enableTraineeAsInstructor;
            IsEnableRounds = isEnableRounds;
            IsEnableTracks = isEnableTracks;
            IsEnableChatBetweenLearners = isEnableChatBetweenLearners;
            IsEnableLearnersToAddSpace = isEnableLearnersToAddSpace;
            TenantType = tenantType;
            IsEnableAttendance = isEnableAttendance;
            IsEnableCustomizeAttendnaceStatusInSegments = isEnableCustomizeAttendnaceStatusInSegments;
            IsCertificateEnabled = isCertificateEnabled;
            CustomThemeColors = customThemeColors;
            ExtraOffering = extraOffering;
            OrganizationSchoolAttendanceStatus = organizationSchoolAttendanceStatus;
            DisableSwitchNotifications = disableSwitchNotifications;
            IsEnableTimeTable = isEnableTimeTable;
            IsEnableGradebook = isEnableGradebook;
            IsEnableScoreSheet = isEnableScoreSheet;
            IsEnableGradebookCustomization = isEnableGradebookCustomization;
            AttendanceActiveMode = attendanceActiveMode;
            HolidayFileId = holidayFileId;
            IsEnableHelpFiles = isEnableHelpFiles;
            IsEnableExternalUserId = isEnableExternalUserId;
            CreationDate = creationDate;
            CreatedBy = createdBy;
            LastModificationDate = lastModificationDate;
            ModifiedBy = modifiedBy;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EdushareUrl")]
        public string EdushareUrl { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LicenseKey")]
        public string LicenseKey { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LogoPictureId")]
        public string LogoPictureId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllowExternalUsers")]
        public bool? AllowExternalUsers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LearnersAccessLevel")]
        public int? LearnersAccessLevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ApplyLogoForAllSchools")]
        public bool? ApplyLogoForAllSchools { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ThemeName")]
        public string ThemeName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsActive")]
        public bool IsActive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TenantNameInUrl")]
        public string TenantNameInUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HideWinjiLogo")]
        public bool? HideWinjiLogo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Office365UserTenants")]
        public IList<LMSDomainCoreModelsOffice365OrganizationUser> Office365UserTenants { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EnableTraineeAsInstructor")]
        public bool? EnableTraineeAsInstructor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnableRounds")]
        public bool? IsEnableRounds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnableTracks")]
        public bool? IsEnableTracks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnableChatBetweenLearners")]
        public bool? IsEnableChatBetweenLearners { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnableLearnersToAddSpace")]
        public bool? IsEnableLearnersToAddSpace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TenantType")]
        public int TenantType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnableAttendance")]
        public bool? IsEnableAttendance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnableCustomizeAttendnaceStatusInSegments")]
        public bool? IsEnableCustomizeAttendnaceStatusInSegments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCertificateEnabled")]
        public bool? IsCertificateEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CustomThemeColors")]
        public string CustomThemeColors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExtraOffering")]
        public string ExtraOffering { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationSchoolAttendanceStatus")]
        public IList<LMSDomainCoreModelsAttendancesOrganizationSchoolAttendanceStatus> OrganizationSchoolAttendanceStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisableSwitchNotifications")]
        public bool? DisableSwitchNotifications { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnableTimeTable")]
        public bool? IsEnableTimeTable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnableGradebook")]
        public bool? IsEnableGradebook { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnableScoreSheet")]
        public bool? IsEnableScoreSheet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnableGradebookCustomization")]
        public bool? IsEnableGradebookCustomization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AttendanceActiveMode")]
        public int? AttendanceActiveMode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HolidayFileId")]
        public string HolidayFileId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnableHelpFiles")]
        public bool? IsEnableHelpFiles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnableExternalUserId")]
        public bool? IsEnableExternalUserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreationDate")]
        public System.DateTime? CreationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatedBy")]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastModificationDate")]
        public System.DateTime? LastModificationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ModifiedBy")]
        public int? ModifiedBy { get; set; }

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
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Office365UserTenants != null)
            {
                foreach (var element in Office365UserTenants)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (OrganizationSchoolAttendanceStatus != null)
            {
                foreach (var element1 in OrganizationSchoolAttendanceStatus)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
