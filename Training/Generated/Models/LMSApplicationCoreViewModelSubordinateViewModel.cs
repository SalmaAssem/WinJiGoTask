// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelSubordinateViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSubordinateViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelSubordinateViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSubordinateViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelSubordinateViewModel(string firstName = default(string), string fullName = default(string), string email = default(string), string profilePictureUrl = default(string))
        {
            FirstName = firstName;
            FullName = fullName;
            Email = email;
            ProfilePictureUrl = profilePictureUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FirstName")]
        public string FirstName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FullName")]
        public string FullName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProfilePictureUrl")]
        public string ProfilePictureUrl { get; private set; }

    }
}
