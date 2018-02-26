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

    public partial class LMSApplicationCoreCommandsCopySessionsCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsCopySessionsCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsCopySessionsCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsCopySessionsCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsCopySessionsCommand(IList<int?> coursesIds = default(IList<int?>), IList<string> sessionsIds = default(IList<string>))
        {
            CoursesIds = coursesIds;
            SessionsIds = sessionsIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CoursesIds")]
        public IList<int?> CoursesIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SessionsIds")]
        public IList<string> SessionsIds { get; set; }

    }
}