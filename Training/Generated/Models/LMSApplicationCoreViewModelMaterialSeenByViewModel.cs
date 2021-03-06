// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelMaterialSeenByViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelMaterialSeenByViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelMaterialSeenByViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelMaterialSeenByViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelMaterialSeenByViewModel(string materialId = default(string), int? userId = default(int?), string fullName = default(string), string email = default(string), string profilePictureUrlSmall = default(string))
        {
            MaterialId = materialId;
            UserId = userId;
            FullName = fullName;
            Email = email;
            ProfilePictureUrlSmall = profilePictureUrlSmall;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaterialId")]
        public string MaterialId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public int? UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FullName")]
        public string FullName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProfilePictureUrlSmall")]
        public string ProfilePictureUrlSmall { get; set; }

    }
}
