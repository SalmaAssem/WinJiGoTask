// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelTimeTableLectureInfoViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelTimeTableLectureInfoViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelTimeTableLectureInfoViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelTimeTableLectureInfoViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelTimeTableLectureInfoViewModel(int? lectureId = default(int?), string subject = default(string))
        {
            LectureId = lectureId;
            Subject = subject;
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
        [JsonProperty(PropertyName = "Subject")]
        public string Subject { get; set; }

    }
}