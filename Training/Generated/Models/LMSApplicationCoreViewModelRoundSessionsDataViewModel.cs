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

    public partial class LMSApplicationCoreViewModelRoundSessionsDataViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelRoundSessionsDataViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelRoundSessionsDataViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelRoundSessionsDataViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelRoundSessionsDataViewModel(int? roundId = default(int?), string roundName = default(string), IList<LMSApplicationCoreViewModelSessionMainData> sessionsData = default(IList<LMSApplicationCoreViewModelSessionMainData>))
        {
            RoundId = roundId;
            RoundName = roundName;
            SessionsData = sessionsData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RoundId")]
        public int? RoundId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RoundName")]
        public string RoundName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SessionsData")]
        public IList<LMSApplicationCoreViewModelSessionMainData> SessionsData { get; set; }

    }
}
