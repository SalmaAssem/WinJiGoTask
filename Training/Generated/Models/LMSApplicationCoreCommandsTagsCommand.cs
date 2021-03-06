// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsTagsCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsTagsCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsTagsCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsTagsCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsTagsCommand(int? contextTypeId = default(int?), int? contextId = default(int?), IList<string> tagsName = default(IList<string>))
        {
            ContextTypeId = contextTypeId;
            ContextId = contextId;
            TagsName = tagsName;
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
        public int? ContextId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TagsName")]
        public IList<string> TagsName { get; set; }

    }
}
