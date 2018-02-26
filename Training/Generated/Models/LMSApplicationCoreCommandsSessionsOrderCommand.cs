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

    public partial class LMSApplicationCoreCommandsSessionsOrderCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsSessionsOrderCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsSessionsOrderCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsSessionsOrderCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsSessionsOrderCommand(IList<LMSApplicationCoreCommandsSessionOrderCommand> sessionsOrders = default(IList<LMSApplicationCoreCommandsSessionOrderCommand>), int? courseId = default(int?))
        {
            SessionsOrders = sessionsOrders;
            CourseId = courseId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SessionsOrders")]
        public IList<LMSApplicationCoreCommandsSessionOrderCommand> SessionsOrders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseId")]
        public int? CourseId { get; set; }

    }
}