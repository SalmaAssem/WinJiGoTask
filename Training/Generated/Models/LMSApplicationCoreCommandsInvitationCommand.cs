// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsInvitationCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsInvitationCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsInvitationCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsInvitationCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsInvitationCommand(string invitationId = default(string), string rejectionReason = default(string))
        {
            InvitationId = invitationId;
            RejectionReason = rejectionReason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InvitationId")]
        public string InvitationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RejectionReason")]
        public string RejectionReason { get; set; }

    }
}