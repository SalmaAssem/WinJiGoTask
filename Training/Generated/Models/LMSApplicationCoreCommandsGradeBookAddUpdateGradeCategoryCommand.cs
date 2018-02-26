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

    public partial class LMSApplicationCoreCommandsGradeBookAddUpdateGradeCategoryCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsGradeBookAddUpdateGradeCategoryCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsGradeBookAddUpdateGradeCategoryCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsGradeBookAddUpdateGradeCategoryCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsGradeBookAddUpdateGradeCategoryCommand(string gradeCategoryId = default(string), string title = default(string), double? weight = default(double?), bool? isAutoDistributedWeights = default(bool?), int? calculationMode = default(int?), int? colorIndex = default(int?), int? subjectId = default(int?), int? gradeId = default(int?), string contextId = default(string), int? contexTypetId = default(int?), int? courseId = default(int?), IList<int?> subjectIds = default(IList<int?>), IList<int?> gradesIds = default(IList<int?>))
        {
            GradeCategoryId = gradeCategoryId;
            Title = title;
            Weight = weight;
            IsAutoDistributedWeights = isAutoDistributedWeights;
            CalculationMode = calculationMode;
            ColorIndex = colorIndex;
            SubjectId = subjectId;
            GradeId = gradeId;
            ContextId = contextId;
            ContexTypetId = contexTypetId;
            CourseId = courseId;
            SubjectIds = subjectIds;
            GradesIds = gradesIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradeCategoryId")]
        public string GradeCategoryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsAutoDistributedWeights")]
        public bool? IsAutoDistributedWeights { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CalculationMode")]
        public int? CalculationMode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ColorIndex")]
        public int? ColorIndex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubjectId")]
        public int? SubjectId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradeId")]
        public int? GradeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContextId")]
        public string ContextId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContexTypetId")]
        public int? ContexTypetId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseId")]
        public int? CourseId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubjectIds")]
        public IList<int?> SubjectIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradesIds")]
        public IList<int?> GradesIds { get; set; }

    }
}
