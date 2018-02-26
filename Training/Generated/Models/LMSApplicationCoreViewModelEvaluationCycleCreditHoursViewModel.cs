// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelEvaluationCycleCreditHoursViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelEvaluationCycleCreditHoursViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelEvaluationCycleCreditHoursViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelEvaluationCycleCreditHoursViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelEvaluationCycleCreditHoursViewModel(int? id = default(int?), string evaluationCycleUniqueIdentifier = default(string), int? evaluationCycleId = default(int?), string evaluationCycleName = default(string), int? creditHours = default(int?), string gradeUniqueIdentifier = default(string), int? gradeId = default(int?), string gradeName = default(string), string schoolId = default(string))
        {
            Id = id;
            EvaluationCycleUniqueIdentifier = evaluationCycleUniqueIdentifier;
            EvaluationCycleId = evaluationCycleId;
            EvaluationCycleName = evaluationCycleName;
            CreditHours = creditHours;
            GradeUniqueIdentifier = gradeUniqueIdentifier;
            GradeId = gradeId;
            GradeName = gradeName;
            SchoolId = schoolId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EvaluationCycleUniqueIdentifier")]
        public string EvaluationCycleUniqueIdentifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EvaluationCycleId")]
        public int? EvaluationCycleId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EvaluationCycleName")]
        public string EvaluationCycleName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreditHours")]
        public int? CreditHours { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradeUniqueIdentifier")]
        public string GradeUniqueIdentifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradeId")]
        public int? GradeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradeName")]
        public string GradeName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchoolId")]
        public string SchoolId { get; set; }

    }
}