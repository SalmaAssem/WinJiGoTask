// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsDiscussionReplyAddCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsDiscussionReplyAddCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsDiscussionReplyAddCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsDiscussionReplyAddCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsDiscussionReplyAddCommand(string discussionId = default(string), string body = default(string))
        {
            DiscussionId = discussionId;
            Body = body;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DiscussionId")]
        public string DiscussionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Body")]
        public string Body { get; set; }

    }
}
