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

    public partial class LMSApplicationCoreViewModelAssessmentActivityDataViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelAssessmentActivityDataViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelAssessmentActivityDataViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelAssessmentActivityDataViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelAssessmentActivityDataViewModel(string id = default(string), IList<LMSDomainCoreModelsLearningObjective> learningObjectives = default(IList<LMSDomainCoreModelsLearningObjective>), string authorizationData = default(string), System.DateTime? lastModificationDate = default(System.DateTime?), string modifiedByUser = default(string), IList<int?> materialSeenByUsers = default(IList<int?>))
        {
            Id = id;
            LearningObjectives = learningObjectives;
            AuthorizationData = authorizationData;
            LastModificationDate = lastModificationDate;
            ModifiedByUser = modifiedByUser;
            MaterialSeenByUsers = materialSeenByUsers;
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
        [JsonProperty(PropertyName = "LearningObjectives")]
        public IList<LMSDomainCoreModelsLearningObjective> LearningObjectives { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AuthorizationData")]
        public string AuthorizationData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastModificationDate")]
        public System.DateTime? LastModificationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ModifiedByUser")]
        public string ModifiedByUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaterialSeenByUsers")]
        public IList<int?> MaterialSeenByUsers { get; set; }

    }
}
