// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelTimeTableTimeTableInfo
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelTimeTableTimeTableInfo class.
        /// </summary>
        public LMSApplicationCoreViewModelTimeTableTimeTableInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelTimeTableTimeTableInfo class.
        /// </summary>
        public LMSApplicationCoreViewModelTimeTableTimeTableInfo(int? lectureId = default(int?), int? day = default(int?), string subject = default(string), int? subjectId = default(int?), string className = default(string))
        {
            LectureId = lectureId;
            Day = day;
            Subject = subject;
            SubjectId = subjectId;
            ClassName = className;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LectureId")]
        public int? LectureId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Day")]
        public int? Day { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Subject")]
        public string Subject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubjectId")]
        public int? SubjectId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClassName")]
        public string ClassName { get; set; }

    }
}
