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

    public partial class LMSApplicationCoreCommandsTrackAddDeleteCourseToTrackCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsTrackAddDeleteCourseToTrackCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsTrackAddDeleteCourseToTrackCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsTrackAddDeleteCourseToTrackCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsTrackAddDeleteCourseToTrackCommand(string trackId = default(string), IList<int?> courseGroupIdList = default(IList<int?>))
        {
            TrackId = trackId;
            CourseGroupIdList = courseGroupIdList;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TrackId")]
        public string TrackId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseGroupIdList")]
        public IList<int?> CourseGroupIdList { get; set; }

    }
}
