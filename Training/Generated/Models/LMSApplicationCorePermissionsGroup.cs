// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCorePermissionsGroup
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCorePermissionsGroup class.
        /// </summary>
        public LMSApplicationCorePermissionsGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCorePermissionsGroup class.
        /// </summary>
        public LMSApplicationCorePermissionsGroup(string title = default(string), string nameSpaceProperty = default(string), bool? isSelected = default(bool?))
        {
            Title = title;
            NameSpaceProperty = nameSpaceProperty;
            IsSelected = isSelected;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NameSpace")]
        public string NameSpaceProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsSelected")]
        public bool? IsSelected { get; set; }

    }
}
