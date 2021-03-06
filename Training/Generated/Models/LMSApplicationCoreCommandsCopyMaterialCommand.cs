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

    public partial class LMSApplicationCoreCommandsCopyMaterialCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsCopyMaterialCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsCopyMaterialCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsCopyMaterialCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsCopyMaterialCommand(IList<string> destinationSessionsIds = default(IList<string>), string materialId = default(string))
        {
            DestinationSessionsIds = destinationSessionsIds;
            MaterialId = materialId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DestinationSessionsIds")]
        public IList<string> DestinationSessionsIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaterialId")]
        public string MaterialId { get; set; }

    }
}
