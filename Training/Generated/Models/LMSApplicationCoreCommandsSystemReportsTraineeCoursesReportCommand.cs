// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsSystemReportsTraineeCoursesReportCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsSystemReportsTraineeCoursesReportCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsSystemReportsTraineeCoursesReportCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsSystemReportsTraineeCoursesReportCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsSystemReportsTraineeCoursesReportCommand(int? traineeId = default(int?), string selectedSchoolId = default(string), string selectedOrgId = default(string), System.DateTime? durationStartDate = default(System.DateTime?), System.DateTime? durationEndDate = default(System.DateTime?), int? duration = default(int?), int? pageSize = default(int?), int? pageNumber = default(int?))
        {
            TraineeId = traineeId;
            SelectedSchoolId = selectedSchoolId;
            SelectedOrgId = selectedOrgId;
            DurationStartDate = durationStartDate;
            DurationEndDate = durationEndDate;
            Duration = duration;
            PageSize = pageSize;
            PageNumber = pageNumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TraineeId")]
        public int? TraineeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SelectedSchoolId")]
        public string SelectedSchoolId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SelectedOrgId")]
        public string SelectedOrgId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DurationStartDate")]
        public System.DateTime? DurationStartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DurationEndDate")]
        public System.DateTime? DurationEndDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PageNumber")]
        public int? PageNumber { get; set; }

    }
}
