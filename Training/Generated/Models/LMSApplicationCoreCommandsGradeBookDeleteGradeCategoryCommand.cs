// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsGradeBookDeleteGradeCategoryCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsGradeBookDeleteGradeCategoryCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsGradeBookDeleteGradeCategoryCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsGradeBookDeleteGradeCategoryCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsGradeBookDeleteGradeCategoryCommand(string gradeCategoryId = default(string))
        {
            GradeCategoryId = gradeCategoryId;
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

    }
}
