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

    public partial class LMSApplicationCoreViewModelPointsLeaderboardViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelPointsLeaderboardViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelPointsLeaderboardViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelPointsLeaderboardViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelPointsLeaderboardViewModel(IList<LMSApplicationCoreViewModelLeaderboardLevelViewModel> levels = default(IList<LMSApplicationCoreViewModelLeaderboardLevelViewModel>))
        {
            Levels = levels;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Levels")]
        public IList<LMSApplicationCoreViewModelLeaderboardLevelViewModel> Levels { get; set; }

    }
}
