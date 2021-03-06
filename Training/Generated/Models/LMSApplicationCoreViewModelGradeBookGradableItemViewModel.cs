// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelGradeBookGradableItemViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelGradeBookGradableItemViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelGradeBookGradableItemViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelGradeBookGradableItemViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelGradeBookGradableItemViewModel(string itemId = default(string), string title = default(string), string description = default(string), double? weight = default(double?), System.DateTime? date = default(System.DateTime?), double? mark = default(double?))
        {
            ItemId = itemId;
            Title = title;
            Description = description;
            Weight = weight;
            Date = date;
            Mark = mark;
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
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Date")]
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Mark")]
        public double? Mark { get; set; }

    }
}
