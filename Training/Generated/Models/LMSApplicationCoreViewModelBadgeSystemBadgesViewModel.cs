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

    public partial class LMSApplicationCoreViewModelBadgeSystemBadgesViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelBadgeSystemBadgesViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelBadgeSystemBadgesViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelBadgeSystemBadgesViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelBadgeSystemBadgesViewModel(IList<LMSDomainCoreModelsBadgesBadgePack> badgePacks = default(IList<LMSDomainCoreModelsBadgesBadgePack>), IList<LMSDomainCoreModelsBadgesBadge> badges = default(IList<LMSDomainCoreModelsBadgesBadge>))
        {
            BadgePacks = badgePacks;
            Badges = badges;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BadgePacks")]
        public IList<LMSDomainCoreModelsBadgesBadgePack> BadgePacks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Badges")]
        public IList<LMSDomainCoreModelsBadgesBadge> Badges { get; set; }

    }
}
