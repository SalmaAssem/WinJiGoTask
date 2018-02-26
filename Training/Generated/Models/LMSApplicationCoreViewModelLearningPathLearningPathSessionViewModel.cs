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

    public partial class LMSApplicationCoreViewModelLearningPathLearningPathSessionViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelLearningPathLearningPathSessionViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelLearningPathLearningPathSessionViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelLearningPathLearningPathSessionViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelLearningPathLearningPathSessionViewModel(string id = default(string), string title = default(string), int? sessionStatus = default(int?), System.DateTime? date = default(System.DateTime?), IList<LMSApplicationCoreViewModelLearningPathLearningPathMaterialViewModel> materialList = default(IList<LMSApplicationCoreViewModelLearningPathLearningPathMaterialViewModel>), int? materialCount = default(int?), IList<LMSApplicationCoreViewModelLearningPathSessionLearnersViewModel> sessionPassedLearners = default(IList<LMSApplicationCoreViewModelLearningPathSessionLearnersViewModel>), IList<LMSApplicationCoreViewModelLearningPathSessionLearnersViewModel> sessionFailedLearners = default(IList<LMSApplicationCoreViewModelLearningPathSessionLearnersViewModel>), bool? isLocked = default(bool?))
        {
            Id = id;
            Title = title;
            SessionStatus = sessionStatus;
            Date = date;
            MaterialList = materialList;
            MaterialCount = materialCount;
            SessionPassedLearners = sessionPassedLearners;
            SessionFailedLearners = sessionFailedLearners;
            IsLocked = isLocked;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SessionStatus")]
        public int? SessionStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Date")]
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaterialList")]
        public IList<LMSApplicationCoreViewModelLearningPathLearningPathMaterialViewModel> MaterialList { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaterialCount")]
        public int? MaterialCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SessionPassedLearners")]
        public IList<LMSApplicationCoreViewModelLearningPathSessionLearnersViewModel> SessionPassedLearners { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SessionFailedLearners")]
        public IList<LMSApplicationCoreViewModelLearningPathSessionLearnersViewModel> SessionFailedLearners { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsLocked")]
        public bool? IsLocked { get; set; }

    }
}
