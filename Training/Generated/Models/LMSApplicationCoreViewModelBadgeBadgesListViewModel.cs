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

    public partial class LMSApplicationCoreViewModelBadgeBadgesListViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelBadgeBadgesListViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelBadgeBadgesListViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelBadgeBadgesListViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelBadgeBadgesListViewModel(LMSApplicationCoreViewModelBadgeSystemBadgesViewModel systemBadges = default(LMSApplicationCoreViewModelBadgeSystemBadgesViewModel), IList<LMSDomainCoreModelsBadgesBadge> userDefinedBadges = default(IList<LMSDomainCoreModelsBadgesBadge>))
        {
            SystemBadges = systemBadges;
            UserDefinedBadges = userDefinedBadges;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SystemBadges")]
        public LMSApplicationCoreViewModelBadgeSystemBadgesViewModel SystemBadges { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserDefinedBadges")]
        public IList<LMSDomainCoreModelsBadgesBadge> UserDefinedBadges { get; set; }

    }
}