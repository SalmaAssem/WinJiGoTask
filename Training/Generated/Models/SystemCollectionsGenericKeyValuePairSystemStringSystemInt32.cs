// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SystemCollectionsGenericKeyValuePairSystemStringSystemInt32
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SystemCollectionsGenericKeyValuePairSystemStringSystemInt32 class.
        /// </summary>
        public SystemCollectionsGenericKeyValuePairSystemStringSystemInt32()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SystemCollectionsGenericKeyValuePairSystemStringSystemInt32 class.
        /// </summary>
        public SystemCollectionsGenericKeyValuePairSystemStringSystemInt32(string key = default(string), int? value = default(int?))
        {
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
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public int? Value { get; set; }

    }
}
