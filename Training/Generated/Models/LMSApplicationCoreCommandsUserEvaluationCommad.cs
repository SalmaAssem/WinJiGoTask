// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsUserEvaluationCommad
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsUserEvaluationCommad class.
        /// </summary>
        public LMSApplicationCoreCommandsUserEvaluationCommad()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsUserEvaluationCommad class.
        /// </summary>
        public LMSApplicationCoreCommandsUserEvaluationCommad(string fileId = default(string), string oldFileId = default(string), int? userId = default(int?))
        {
            FileId = fileId;
            OldFileId = oldFileId;
            UserId = userId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OldFileId")]
        public string OldFileId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public int? UserId { get; set; }

    }
}