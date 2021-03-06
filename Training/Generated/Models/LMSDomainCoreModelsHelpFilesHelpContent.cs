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

    public partial class LMSDomainCoreModelsHelpFilesHelpContent
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSDomainCoreModelsHelpFilesHelpContent class.
        /// </summary>
        public LMSDomainCoreModelsHelpFilesHelpContent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSDomainCoreModelsHelpFilesHelpContent class.
        /// </summary>
        public LMSDomainCoreModelsHelpFilesHelpContent(string title, string fileType, string uRL, string languageCultureName, bool isActive, string description = default(string), string thumbnailURL = default(string), IList<LMSDomainCoreModelsHelpFilesHelpCategory> helpCategories = default(IList<LMSDomainCoreModelsHelpFilesHelpCategory>), int? id = default(int?))
        {
            Title = title;
            Description = description;
            FileType = fileType;
            URL = uRL;
            ThumbnailURL = thumbnailURL;
            LanguageCultureName = languageCultureName;
            IsActive = isActive;
            HelpCategories = helpCategories;
            Id = id;
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
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FileType")]
        public string FileType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "URL")]
        public string URL { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ThumbnailURL")]
        public string ThumbnailURL { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LanguageCultureName")]
        public string LanguageCultureName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsActive")]
        public bool IsActive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HelpCategories")]
        public IList<LMSDomainCoreModelsHelpFilesHelpCategory> HelpCategories { get; set; }

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
            if (Title == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Title");
            }
            if (FileType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FileType");
            }
            if (URL == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "URL");
            }
            if (LanguageCultureName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LanguageCultureName");
            }
            if (HelpCategories != null)
            {
                foreach (var element in HelpCategories)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
