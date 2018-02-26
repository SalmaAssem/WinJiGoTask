// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelBadgeActivityBadgeViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelBadgeActivityBadgeViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelBadgeActivityBadgeViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelBadgeActivityBadgeViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelBadgeActivityBadgeViewModel(string id = default(string), string materialId = default(string), int? percentage = default(int?), string badgeTitle = default(string), string badgeImageUrl = default(string), string badgeId = default(string), int? badgeParentId = default(int?), int? badgeParentTypeId = default(int?), int? badgeShapeId = default(int?))
        {
            Id = id;
            MaterialId = materialId;
            Percentage = percentage;
            BadgeTitle = badgeTitle;
            BadgeImageUrl = badgeImageUrl;
            BadgeId = badgeId;
            BadgeParentId = badgeParentId;
            BadgeParentTypeId = badgeParentTypeId;
            BadgeShapeId = badgeShapeId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaterialId")]
        public string MaterialId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Percentage")]
        public int? Percentage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BadgeTitle")]
        public string BadgeTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BadgeImageUrl")]
        public string BadgeImageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BadgeId")]
        public string BadgeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BadgeParentId")]
        public int? BadgeParentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BadgeParentTypeId")]
        public int? BadgeParentTypeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BadgeShapeId")]
        public int? BadgeShapeId { get; set; }

    }
}
