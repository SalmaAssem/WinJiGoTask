// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSDomainCoreModelsMaterialsMaterialType
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSDomainCoreModelsMaterialsMaterialType class.
        /// </summary>
        public LMSDomainCoreModelsMaterialsMaterialType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSDomainCoreModelsMaterialsMaterialType class.
        /// </summary>
        public LMSDomainCoreModelsMaterialsMaterialType(string namespaceProperty, string title, int category, string description, int? id = default(int?))
        {
            Id = id;
            NamespaceProperty = namespaceProperty;
            Title = title;
            Category = category;
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
        public int? Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Namespace")]
        public string NamespaceProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Category")]
        public int Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NamespaceProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NamespaceProperty");
            }
            if (Title == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Title");
            }
            if (Description == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Description");
            }
        }
    }
}
