// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class LMSDomainCoreModelsHelpFilesHelpCategory
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSDomainCoreModelsHelpFilesHelpCategory class.
        /// </summary>
        public LMSDomainCoreModelsHelpFilesHelpCategory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSDomainCoreModelsHelpFilesHelpCategory class.
        /// </summary>
        public LMSDomainCoreModelsHelpFilesHelpCategory(string name, IList<LMSDomainCoreModelsHelpFilesHelpContent> helpFiles = default(IList<LMSDomainCoreModelsHelpFilesHelpContent>), IList<LMSDomainCoreModelsHelpFilesHelpRoleCategory> helpRoleCategories = default(IList<LMSDomainCoreModelsHelpFilesHelpRoleCategory>), int? id = default(int?))
        {
            Name = name;
            HelpFiles = helpFiles;
            HelpRoleCategories = helpRoleCategories;
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
        [JsonProperty(PropertyName = "HelpFiles")]
        public IList<LMSDomainCoreModelsHelpFilesHelpContent> HelpFiles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HelpRoleCategories")]
        public IList<LMSDomainCoreModelsHelpFilesHelpRoleCategory> HelpRoleCategories { get; set; }

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
            if (HelpFiles != null)
            {
                foreach (var element in HelpFiles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (HelpRoleCategories != null)
            {
                foreach (var element1 in HelpRoleCategories)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
