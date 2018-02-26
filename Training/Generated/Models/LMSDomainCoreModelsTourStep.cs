// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSDomainCoreModelsTourStep
    {
        /// <summary>
        /// Initializes a new instance of the LMSDomainCoreModelsTourStep
        /// class.
        /// </summary>
        public LMSDomainCoreModelsTourStep()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LMSDomainCoreModelsTourStep
        /// class.
        /// </summary>
        public LMSDomainCoreModelsTourStep(int order, int roleId, int tourPageId, int? id = default(int?), string content = default(string), LMSDomainCoreModelsRole role = default(LMSDomainCoreModelsRole), LMSDomainCoreModelsTourPage tourPage = default(LMSDomainCoreModelsTourPage))
        {
            Id = id;
            Order = order;
            Content = content;
            RoleId = roleId;
            Role = role;
            TourPageId = tourPageId;
            TourPage = tourPage;
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
        [JsonProperty(PropertyName = "Order")]
        public int Order { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Content")]
        public string Content { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RoleId")]
        public int RoleId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Role")]
        public LMSDomainCoreModelsRole Role { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TourPageId")]
        public int TourPageId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TourPage")]
        public LMSDomainCoreModelsTourPage TourPage { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TourPage != null)
            {
                TourPage.Validate();
            }
        }
    }
}
