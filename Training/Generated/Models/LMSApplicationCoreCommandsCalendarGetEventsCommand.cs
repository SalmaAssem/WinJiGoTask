// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsCalendarGetEventsCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsCalendarGetEventsCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsCalendarGetEventsCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsCalendarGetEventsCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsCalendarGetEventsCommand(System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?))
        {
            StartDate = startDate;
            EndDate = endDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StartDate")]
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EndDate")]
        public System.DateTime? EndDate { get; set; }

    }
}
