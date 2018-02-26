// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsGradeBookAddUpdateGradableItemCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsGradeBookAddUpdateGradableItemCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsGradeBookAddUpdateGradableItemCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsGradeBookAddUpdateGradableItemCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsGradeBookAddUpdateGradableItemCommand(string gradableItemId = default(string), string title = default(string), string description = default(string), System.DateTime? date = default(System.DateTime?), double? mark = default(double?), double? weight = default(double?), string gradeCategoryId = default(string))
        {
            GradableItemId = gradableItemId;
            Title = title;
            Description = description;
            Date = date;
            Mark = mark;
            Weight = weight;
            GradeCategoryId = gradeCategoryId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradableItemId")]
        public string GradableItemId { get; set; }

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
        [JsonProperty(PropertyName = "Date")]
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Mark")]
        public double? Mark { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradeCategoryId")]
        public string GradeCategoryId { get; set; }

    }
}