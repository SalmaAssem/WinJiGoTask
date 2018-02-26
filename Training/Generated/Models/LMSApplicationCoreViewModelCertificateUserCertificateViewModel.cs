// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelCertificateUserCertificateViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelCertificateUserCertificateViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelCertificateUserCertificateViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelCertificateUserCertificateViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelCertificateUserCertificateViewModel(LMSApplicationCoreViewModelCertificateCertificateViewModel certificate = default(LMSApplicationCoreViewModelCertificateCertificateViewModel), int? courseGroupId = default(int?), int? courseId = default(int?), string courseName = default(string), string courseGroupName = default(string), string userDisplayName = default(string), string certificateNumber = default(string), string schoolName = default(string), System.DateTime? certificationDate = default(System.DateTime?), bool? isDeleted = default(bool?))
        {
            Certificate = certificate;
            CourseGroupId = courseGroupId;
            CourseId = courseId;
            CourseName = courseName;
            CourseGroupName = courseGroupName;
            UserDisplayName = userDisplayName;
            CertificateNumber = certificateNumber;
            SchoolName = schoolName;
            CertificationDate = certificationDate;
            IsDeleted = isDeleted;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Certificate")]
        public LMSApplicationCoreViewModelCertificateCertificateViewModel Certificate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseGroupId")]
        public int? CourseGroupId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseId")]
        public int? CourseId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseName")]
        public string CourseName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseGroupName")]
        public string CourseGroupName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserDisplayName")]
        public string UserDisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CertificateNumber")]
        public string CertificateNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchoolName")]
        public string SchoolName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CertificationDate")]
        public System.DateTime? CertificationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsDeleted")]
        public bool? IsDeleted { get; set; }

    }
}