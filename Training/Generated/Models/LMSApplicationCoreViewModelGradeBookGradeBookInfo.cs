// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelGradeBookGradeBookInfo
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelGradeBookGradeBookInfo class.
        /// </summary>
        public LMSApplicationCoreViewModelGradeBookGradeBookInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelGradeBookGradeBookInfo class.
        /// </summary>
        public LMSApplicationCoreViewModelGradeBookGradeBookInfo(string title = default(string), string subtitle = default(string))
        {
            Title = title;
            Subtitle = subtitle;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Subtitle")]
        public string Subtitle { get; set; }

    }
}
