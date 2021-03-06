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

    public partial class LMSApplicationCoreCommandsSystemReportsTraineeStatisticsReportCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsSystemReportsTraineeStatisticsReportCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsSystemReportsTraineeStatisticsReportCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsSystemReportsTraineeStatisticsReportCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsSystemReportsTraineeStatisticsReportCommand(int? traineeId = default(int?), string schoolId = default(string), string orgId = default(string), IList<int?> enrolledCoursesIds = default(IList<int?>), int? duration = default(int?), System.DateTime? durationStartDate = default(System.DateTime?), System.DateTime? durationEndDate = default(System.DateTime?))
        {
            TraineeId = traineeId;
            SchoolId = schoolId;
            OrgId = orgId;
            EnrolledCoursesIds = enrolledCoursesIds;
            Duration = duration;
            DurationStartDate = durationStartDate;
            DurationEndDate = durationEndDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traineeId")]
        public int? TraineeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schoolId")]
        public string SchoolId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orgId")]
        public string OrgId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enrolledCoursesIds")]
        public IList<int?> EnrolledCoursesIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "durationStartDate")]
        public System.DateTime? DurationStartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "durationEndDate")]
        public System.DateTime? DurationEndDate { get; set; }

    }
}
