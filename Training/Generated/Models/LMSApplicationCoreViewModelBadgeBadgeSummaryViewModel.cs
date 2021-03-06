// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelBadgeBadgeSummaryViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelBadgeBadgeSummaryViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelBadgeBadgeSummaryViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelBadgeBadgeSummaryViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelBadgeBadgeSummaryViewModel(string id = default(string), string imageUrl = default(string), string title = default(string), int? pointsPerBadge = default(int?), int? count = default(int?), int? shapeId = default(int?), string message = default(string))
        {
            Id = id;
            ImageUrl = imageUrl;
            Title = title;
            PointsPerBadge = pointsPerBadge;
            Count = count;
            ShapeId = shapeId;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ImageUrl")]
        public string ImageUrl { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PointsPerBadge")]
        public int? PointsPerBadge { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Count")]
        public int? Count { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ShapeId")]
        public int? ShapeId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }

    }
}
