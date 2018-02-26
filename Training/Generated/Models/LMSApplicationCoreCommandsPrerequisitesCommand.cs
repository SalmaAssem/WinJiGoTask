// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsPrerequisitesCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsPrerequisitesCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsPrerequisitesCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsPrerequisitesCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsPrerequisitesCommand(int? contextTypeId = default(int?), string contextId = default(string), int? contentTypeId = default(int?), string content = default(string), bool? isDeleted = default(bool?), bool? isMandatory = default(bool?))
        {
            ContextTypeId = contextTypeId;
            ContextId = contextId;
            ContentTypeId = contentTypeId;
            Content = content;
            IsDeleted = isDeleted;
            IsMandatory = isMandatory;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContextTypeId")]
        public int? ContextTypeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContextId")]
        public string ContextId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContentTypeId")]
        public int? ContentTypeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Content")]
        public string Content { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsDeleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsMandatory")]
        public bool? IsMandatory { get; set; }

    }
}
