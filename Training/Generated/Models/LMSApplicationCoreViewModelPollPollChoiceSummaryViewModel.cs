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

    public partial class LMSApplicationCoreViewModelPollPollChoiceSummaryViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelPollPollChoiceSummaryViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelPollPollChoiceSummaryViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelPollPollChoiceSummaryViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelPollPollChoiceSummaryViewModel(string choiceId = default(string), string choiceTxt = default(string), System.DateTime? choiceCreationDate = default(System.DateTime?), int? chosenBy = default(int?), double? chosenByPercentage = default(double?), IList<LMSApplicationCoreViewModelPollPollerViewModel> users = default(IList<LMSApplicationCoreViewModelPollPollerViewModel>))
        {
            ChoiceId = choiceId;
            ChoiceTxt = choiceTxt;
            ChoiceCreationDate = choiceCreationDate;
            ChosenBy = chosenBy;
            ChosenByPercentage = chosenByPercentage;
            Users = users;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ChoiceId")]
        public string ChoiceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ChoiceTxt")]
        public string ChoiceTxt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ChoiceCreationDate")]
        public System.DateTime? ChoiceCreationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ChosenBy")]
        public int? ChosenBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ChosenByPercentage")]
        public double? ChosenByPercentage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Users")]
        public IList<LMSApplicationCoreViewModelPollPollerViewModel> Users { get; set; }

    }
}
