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

    public partial class LMSApplicationCoreViewModelAttendanceStatusViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelAttendanceStatusViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelAttendanceStatusViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelAttendanceStatusViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelAttendanceStatusViewModel(string statusId = default(string), int? statusColor = default(int?), string statusName = default(string), int? numberOfStudents = default(int?), IList<LMSApplicationCoreViewModelStudentSessionAttendanceViewModel> attendanceSessions = default(IList<LMSApplicationCoreViewModelStudentSessionAttendanceViewModel>))
        {
            StatusId = statusId;
            StatusColor = statusColor;
            StatusName = statusName;
            NumberOfStudents = numberOfStudents;
            AttendanceSessions = attendanceSessions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StatusId")]
        public string StatusId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StatusColor")]
        public int? StatusColor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StatusName")]
        public string StatusName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfStudents")]
        public int? NumberOfStudents { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AttendanceSessions")]
        public IList<LMSApplicationCoreViewModelStudentSessionAttendanceViewModel> AttendanceSessions { get; set; }

    }
}
