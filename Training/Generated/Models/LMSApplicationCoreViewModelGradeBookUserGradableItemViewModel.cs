// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelGradeBookUserGradableItemViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelGradeBookUserGradableItemViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelGradeBookUserGradableItemViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelGradeBookUserGradableItemViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelGradeBookUserGradableItemViewModel(string itemId = default(string), string itemName = default(string), double? itemTotalScore = default(double?), double? userScore = default(double?))
        {
            ItemId = itemId;
            ItemName = itemName;
            ItemTotalScore = itemTotalScore;
            UserScore = userScore;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ItemId")]
        public string ItemId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ItemName")]
        public string ItemName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ItemTotalScore")]
        public double? ItemTotalScore { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserScore")]
        public double? UserScore { get; set; }

    }
}
