// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsPollChoiceAddCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsPollChoiceAddCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsPollChoiceAddCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsPollChoiceAddCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsPollChoiceAddCommand(string pollChoiceId = default(string), string pollId = default(string))
        {
            PollChoiceId = pollChoiceId;
            PollId = pollId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pollChoiceId")]
        public string PollChoiceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pollId")]
        public string PollId { get; set; }

    }
}
