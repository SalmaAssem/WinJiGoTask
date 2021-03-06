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

    public partial class LMSApplicationCoreViewModelTimeTableTimeTableViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelTimeTableTimeTableViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelTimeTableTimeTableViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelTimeTableTimeTableViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelTimeTableTimeTableViewModel(IList<string> days = default(IList<string>), IList<LMSApplicationCoreViewModelTimeTableTimeTableInfo> timeTableInfo = default(IList<LMSApplicationCoreViewModelTimeTableTimeTableInfo>), IList<string> lectures = default(IList<string>), string classId = default(string), string className = default(string), IList<string> subjects = default(IList<string>))
        {
            Days = days;
            TimeTableInfo = timeTableInfo;
            Lectures = lectures;
            ClassId = classId;
            ClassName = className;
            Subjects = subjects;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Days")]
        public IList<string> Days { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TimeTableInfo")]
        public IList<LMSApplicationCoreViewModelTimeTableTimeTableInfo> TimeTableInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Lectures")]
        public IList<string> Lectures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClassId")]
        public string ClassId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClassName")]
        public string ClassName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Subjects")]
        public IList<string> Subjects { get; set; }

    }
}
