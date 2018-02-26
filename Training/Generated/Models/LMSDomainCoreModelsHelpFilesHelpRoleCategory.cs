// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSDomainCoreModelsHelpFilesHelpRoleCategory
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSDomainCoreModelsHelpFilesHelpRoleCategory class.
        /// </summary>
        public LMSDomainCoreModelsHelpFilesHelpRoleCategory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSDomainCoreModelsHelpFilesHelpRoleCategory class.
        /// </summary>
        public LMSDomainCoreModelsHelpFilesHelpRoleCategory(LMSDomainCoreModelsHelpFilesHelpCategory helpCategoryId = default(LMSDomainCoreModelsHelpFilesHelpCategory), int? reoleCategoryId = default(int?), int? id = default(int?))
        {
            HelpCategoryId = helpCategoryId;
            ReoleCategoryId = reoleCategoryId;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HelpCategoryId")]
        public LMSDomainCoreModelsHelpFilesHelpCategory HelpCategoryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReoleCategoryId")]
        public int? ReoleCategoryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (HelpCategoryId != null)
            {
                HelpCategoryId.Validate();
            }
        }
    }
}
