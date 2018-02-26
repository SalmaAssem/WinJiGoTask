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

    public partial class LMSDomainCoreModelsGrade
    {
        /// <summary>
        /// Initializes a new instance of the LMSDomainCoreModelsGrade class.
        /// </summary>
        public LMSDomainCoreModelsGrade()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LMSDomainCoreModelsGrade class.
        /// </summary>
        public LMSDomainCoreModelsGrade(string name, string contextId = default(string), int? contextTypeId = default(int?), int? instituteTypeId = default(int?), bool? isActive = default(bool?), string translationKey = default(string), string uniqueIdentifier = default(string), int? order = default(int?), int? id = default(int?))
        {
            Name = name;
            ContextId = contextId;
            ContextTypeId = contextTypeId;
            InstituteTypeId = instituteTypeId;
            IsActive = isActive;
            TranslationKey = translationKey;
            UniqueIdentifier = uniqueIdentifier;
            Order = order;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContextId")]
        public string ContextId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContextTypeId")]
        public int? ContextTypeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InstituteTypeId")]
        public int? InstituteTypeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TranslationKey")]
        public string TranslationKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UniqueIdentifier")]
        public string UniqueIdentifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Order")]
        public int? Order { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}