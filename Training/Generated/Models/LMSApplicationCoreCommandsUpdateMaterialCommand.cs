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

    public partial class LMSApplicationCoreCommandsUpdateMaterialCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsUpdateMaterialCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsUpdateMaterialCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsUpdateMaterialCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsUpdateMaterialCommand(int? materialTypeId = default(int?), string description = default(string), object content = default(object), string title = default(string), string id = default(string), string type = default(string), string url = default(string), bool? showThumbnail = default(bool?), IList<LMSApplicationCoreCommandsLearningObjectiveCommand> learningObjectives = default(IList<LMSApplicationCoreCommandsLearningObjectiveCommand>), string voiceNotefileId = default(string), System.DateTime? publishingDate = default(System.DateTime?), bool? isSpecificAssignees = default(bool?), IList<int?> assigneesIds = default(IList<int?>))
        {
            MaterialTypeId = materialTypeId;
            Description = description;
            Content = content;
            Title = title;
            Id = id;
            Type = type;
            Url = url;
            ShowThumbnail = showThumbnail;
            LearningObjectives = learningObjectives;
            VoiceNotefileId = voiceNotefileId;
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
        [JsonProperty(PropertyName = "materialTypeId")]
        public int? MaterialTypeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Content")]
        public object Content { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Url")]
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ShowThumbnail")]
        public bool? ShowThumbnail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LearningObjectives")]
        public IList<LMSApplicationCoreCommandsLearningObjectiveCommand> LearningObjectives { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "VoiceNotefileId")]
        public string VoiceNotefileId { get; set; }

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
