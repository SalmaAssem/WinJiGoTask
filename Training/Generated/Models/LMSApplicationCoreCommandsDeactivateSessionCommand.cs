// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsDeactivateSessionCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsDeactivateSessionCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsDeactivateSessionCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsDeactivateSessionCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsDeactivateSessionCommand(string sessionId = default(string))
        {
            SessionId = sessionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SessionId")]
        public string SessionId { get; set; }

    }
}
