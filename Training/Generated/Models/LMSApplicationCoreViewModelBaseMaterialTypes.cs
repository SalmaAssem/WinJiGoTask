// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelBaseMaterialTypes
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelBaseMaterialTypes class.
        /// </summary>
        public LMSApplicationCoreViewModelBaseMaterialTypes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelBaseMaterialTypes class.
        /// </summary>
        public LMSApplicationCoreViewModelBaseMaterialTypes(int? id = default(int?), string namespaceProperty = default(string), string shortName = default(string), string title = default(string), string description = default(string))
        {
            Id = id;
            NamespaceProperty = namespaceProperty;
            ShortName = shortName;
            Title = title;
            Description = description;
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
        [JsonProperty(PropertyName = "Namespace")]
        public string NamespaceProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ShortName")]
        public string ShortName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

    }
}