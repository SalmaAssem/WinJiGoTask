// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelSystemReportsUserViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsUserViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsUserViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsUserViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsUserViewModel(int? id = default(int?), string name = default(string), string email = default(string), string imageUrl = default(string), string schoolId = default(string), string schoolName = default(string))
        {
            Id = id;
            Name = name;
            Email = email;
            ImageUrl = imageUrl;
            SchoolId = schoolId;
            SchoolName = schoolName;
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
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ImageUrl")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchoolId")]
        public string SchoolId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchoolName")]
        public string SchoolName { get; set; }

    }
}