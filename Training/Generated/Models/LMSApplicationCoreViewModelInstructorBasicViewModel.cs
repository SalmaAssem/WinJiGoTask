// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelInstructorBasicViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelInstructorBasicViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelInstructorBasicViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelInstructorBasicViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelInstructorBasicViewModel(int? id = default(int?), string fullName = default(string))
        {
            Id = id;
            FullName = fullName;
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
        [JsonProperty(PropertyName = "FullName")]
        public string FullName { get; set; }

    }
}
