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

    public partial class LMSApplicationCoreCommandsRemoveFilesMaterialCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsRemoveFilesMaterialCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsRemoveFilesMaterialCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsRemoveFilesMaterialCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsRemoveFilesMaterialCommand(IList<string> filesIds = default(IList<string>))
        {
            FilesIds = filesIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FilesIds")]
        public IList<string> FilesIds { get; set; }

    }
}
