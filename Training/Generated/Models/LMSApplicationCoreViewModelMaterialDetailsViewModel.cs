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

    public partial class LMSApplicationCoreViewModelMaterialDetailsViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelMaterialDetailsViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelMaterialDetailsViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelMaterialDetailsViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelMaterialDetailsViewModel(string id = default(string), string title = default(string), IList<int?> materialSeenByUsers = default(IList<int?>), string description = default(string), int? materialTypeId = default(int?), string contextId = default(string), string contextType = default(string), string typeUniqueName = default(string), string typeShortName = default(string), string content = default(string), IList<LMSDomainCoreModelsLearningObjective> learningObjectives = default(IList<LMSDomainCoreModelsLearningObjective>), System.DateTime? lastModificationDate = default(System.DateTime?), string modifiedByUser = default(string), bool? isOwner = default(bool?), bool? isMaterialSeenByCurrentUser = default(bool?), LMSApplicationCoreViewModelVoiceNoteViewModel voiceNote = default(LMSApplicationCoreViewModelVoiceNoteViewModel), string videoCurrentTime = default(string), bool? isVideoCompleted = default(bool?), System.DateTime? publishingDate = default(System.DateTime?), bool? isSpecificAssignees = default(bool?), IList<int?> assigneesIds = default(IList<int?>))
        {
            Id = id;
            Title = title;
            MaterialSeenByUsers = materialSeenByUsers;
            Description = description;
            MaterialTypeId = materialTypeId;
            ContextId = contextId;
            ContextType = contextType;
            TypeUniqueName = typeUniqueName;
            TypeShortName = typeShortName;
            Content = content;
            LearningObjectives = learningObjectives;
            LastModificationDate = lastModificationDate;
            ModifiedByUser = modifiedByUser;
            IsOwner = isOwner;
            IsMaterialSeenByCurrentUser = isMaterialSeenByCurrentUser;
            VoiceNote = voiceNote;
            VideoCurrentTime = videoCurrentTime;
            IsVideoCompleted = isVideoCompleted;
            PublishingDate = publishingDate;
            IsSpecificAssignees = isSpecificAssignees;
            AssigneesIds = assigneesIds;
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
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaterialSeenByUsers")]
        public IList<int?> MaterialSeenByUsers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaterialTypeId")]
        public int? MaterialTypeId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContextId")]
        public string ContextId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContextType")]
        public string ContextType { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TypeUniqueName")]
        public string TypeUniqueName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TypeShortName")]
        public string TypeShortName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Content")]
        public string Content { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LearningObjectives")]
        public IList<LMSDomainCoreModelsLearningObjective> LearningObjectives { get; private set; }

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
        [JsonProperty(PropertyName = "IsOwner")]
        public bool? IsOwner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsMaterialSeenByCurrentUser")]
        public bool? IsMaterialSeenByCurrentUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "VoiceNote")]
        public LMSApplicationCoreViewModelVoiceNoteViewModel VoiceNote { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "VideoCurrentTime")]
        public string VideoCurrentTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsVideoCompleted")]
        public bool? IsVideoCompleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PublishingDate")]
        public System.DateTime? PublishingDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsSpecificAssignees")]
        public bool? IsSpecificAssignees { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssigneesIds")]
        public IList<int?> AssigneesIds { get; set; }

    }
}