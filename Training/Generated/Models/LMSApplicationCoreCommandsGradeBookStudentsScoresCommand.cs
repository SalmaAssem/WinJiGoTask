// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsGradeBookStudentsScoresCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsGradeBookStudentsScoresCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsGradeBookStudentsScoresCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsGradeBookStudentsScoresCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsGradeBookStudentsScoresCommand(int? studentId = default(int?), double? score = default(double?))
        {
            StudentId = studentId;
            Score = score;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StudentId")]
        public int? StudentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Score")]
        public double? Score { get; set; }

    }
}