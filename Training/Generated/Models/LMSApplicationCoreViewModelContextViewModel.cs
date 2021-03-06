// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelContextViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelContextViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelContextViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelContextViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelContextViewModel(string id = default(string), string name = default(string), string roundName = default(string), string color = default(string), string contextType = default(string), string roundId = default(string), string holidayFileName = default(string), string holidayFilePlayURL = default(string), string holidayFileId = default(string))
        {
            Id = id;
            Name = name;
            RoundName = roundName;
            Color = color;
            ContextType = contextType;
            RoundId = roundId;
            HolidayFileName = holidayFileName;
            HolidayFilePlayURL = holidayFilePlayURL;
            HolidayFileId = holidayFileId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RoundName")]
        public string RoundName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Color")]
        public string Color { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContextType")]
        public string ContextType { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RoundId")]
        public string RoundId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HolidayFileName")]
        public string HolidayFileName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HolidayFilePlayURL")]
        public string HolidayFilePlayURL { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HolidayFileId")]
        public string HolidayFileId { get; set; }

    }
}
