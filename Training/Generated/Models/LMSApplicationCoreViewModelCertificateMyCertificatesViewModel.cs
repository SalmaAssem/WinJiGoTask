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

    public partial class LMSApplicationCoreViewModelCertificateMyCertificatesViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelCertificateMyCertificatesViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelCertificateMyCertificatesViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelCertificateMyCertificatesViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelCertificateMyCertificatesViewModel(bool? isCertificateEnabled = default(bool?), IList<LMSApplicationCoreViewModelCertificateUserCertificateViewModel> userCertificates = default(IList<LMSApplicationCoreViewModelCertificateUserCertificateViewModel>))
        {
            IsCertificateEnabled = isCertificateEnabled;
            UserCertificates = userCertificates;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCertificateEnabled")]
        public bool? IsCertificateEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserCertificates")]
        public IList<LMSApplicationCoreViewModelCertificateUserCertificateViewModel> UserCertificates { get; set; }

    }
}
