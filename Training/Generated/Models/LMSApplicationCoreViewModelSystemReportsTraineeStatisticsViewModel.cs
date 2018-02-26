// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelSystemReportsTraineeStatisticsViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsTraineeStatisticsViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsTraineeStatisticsViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsTraineeStatisticsViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsTraineeStatisticsViewModel(int? tracksCount = default(int?), int? trophiesCount = default(int?), int? badgesCount = default(int?), int? certificatesCount = default(int?), bool? isCertificateEnabled = default(bool?))
        {
            TracksCount = tracksCount;
            TrophiesCount = trophiesCount;
            BadgesCount = badgesCount;
            CertificatesCount = certificatesCount;
            IsCertificateEnabled = isCertificateEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TracksCount")]
        public int? TracksCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TrophiesCount")]
        public int? TrophiesCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BadgesCount")]
        public int? BadgesCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CertificatesCount")]
        public int? CertificatesCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCertificateEnabled")]
        public bool? IsCertificateEnabled { get; set; }

    }
}
