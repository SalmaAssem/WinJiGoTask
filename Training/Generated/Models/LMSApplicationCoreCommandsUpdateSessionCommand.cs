// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsUpdateSessionCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsUpdateSessionCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsUpdateSessionCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsUpdateSessionCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsUpdateSessionCommand(System.DateTime? date = default(System.DateTime?), string id = default(string), string title = default(string), string objectives = default(string), int? duration = default(int?), string voiceNotefileId = default(string), int? type = default(int?), string objectiveFileId = default(string), LMSApplicationCoreCommandsSessionLessonPlanCommand lessonPlanTemplate = default(LMSApplicationCoreCommandsSessionLessonPlanCommand))
        {
            Date = date;
            Id = id;
            Title = title;
            Objectives = objectives;
            Duration = duration;
            VoiceNotefileId = voiceNotefileId;
            Type = type;
            ObjectiveFileId = objectiveFileId;
            LessonPlanTemplate = lessonPlanTemplate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Date")]
        public System.DateTime? Date { get; set; }

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
        [JsonProperty(PropertyName = "Objectives")]
        public string Objectives { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "VoiceNotefileId")]
        public string VoiceNotefileId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public int? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ObjectiveFileId")]
        public string ObjectiveFileId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LessonPlanTemplate")]
        public LMSApplicationCoreCommandsSessionLessonPlanCommand LessonPlanTemplate { get; set; }

    }
}
