// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelAssessmentAttributes
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelAssessmentAttributes class.
        /// </summary>
        public LMSApplicationCoreViewModelAssessmentAttributes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelAssessmentAttributes class.
        /// </summary>
        public LMSApplicationCoreViewModelAssessmentAttributes(int? id = default(int?), int? assessmentId = default(int?), string key = default(string), string value = default(string))
        {
            Id = id;
            AssessmentId = assessmentId;
            Key = key;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssessmentId")]
        public int? AssessmentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public string Key { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

    }
}
