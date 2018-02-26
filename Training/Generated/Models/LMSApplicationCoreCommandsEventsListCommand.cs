// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsEventsListCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsEventsListCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsEventsListCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsEventsListCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsEventsListCommand(string contextId = default(string), int? contextTypeId = default(int?), System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?), bool? getFutureEvents = default(bool?))
        {
            ContextId = contextId;
            ContextTypeId = contextTypeId;
            StartDate = startDate;
            EndDate = endDate;
            GetFutureEvents = getFutureEvents;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContextId")]
        public string ContextId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContextTypeId")]
        public int? ContextTypeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StartDate")]
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EndDate")]
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GetFutureEvents")]
        public bool? GetFutureEvents { get; set; }

    }
}
