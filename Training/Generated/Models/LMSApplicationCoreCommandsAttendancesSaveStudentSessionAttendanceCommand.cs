// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsAttendancesSaveStudentSessionAttendanceCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsAttendancesSaveStudentSessionAttendanceCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsAttendancesSaveStudentSessionAttendanceCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsAttendancesSaveStudentSessionAttendanceCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsAttendancesSaveStudentSessionAttendanceCommand(int? courseId = default(int?), string sessionId = default(string), bool? allDayAttendance = default(bool?), LMSApplicationCoreCommandsAttendancesSaveUserAttendanceCommand userAttendance = default(LMSApplicationCoreCommandsAttendancesSaveUserAttendanceCommand))
        {
            CourseId = courseId;
            SessionId = sessionId;
            AllDayAttendance = allDayAttendance;
            UserAttendance = userAttendance;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseId")]
        public int? CourseId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllDayAttendance")]
        public bool? AllDayAttendance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserAttendance")]
        public LMSApplicationCoreCommandsAttendancesSaveUserAttendanceCommand UserAttendance { get; set; }

    }
}