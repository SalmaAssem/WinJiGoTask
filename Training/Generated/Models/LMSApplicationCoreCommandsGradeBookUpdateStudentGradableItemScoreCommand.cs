// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsGradeBookUpdateStudentGradableItemScoreCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsGradeBookUpdateStudentGradableItemScoreCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsGradeBookUpdateStudentGradableItemScoreCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsGradeBookUpdateStudentGradableItemScoreCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsGradeBookUpdateStudentGradableItemScoreCommand(string gradableItemId = default(string), double? score = default(double?))
        {
            GradableItemId = gradableItemId;
            Score = score;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradableItemId")]
        public string GradableItemId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Score")]
        public double? Score { get; set; }

    }
}
