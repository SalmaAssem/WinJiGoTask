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

    public partial class LMSApplicationCoreViewModelUserProfileUserHierarchy
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelUserProfileUserHierarchy class.
        /// </summary>
        public LMSApplicationCoreViewModelUserProfileUserHierarchy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelUserProfileUserHierarchy class.
        /// </summary>
        public LMSApplicationCoreViewModelUserProfileUserHierarchy(string roleName = default(string), IList<string> schoolsTree = default(IList<string>))
        {
            RoleName = roleName;
            SchoolsTree = schoolsTree;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RoleName")]
        public string RoleName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchoolsTree")]
        public IList<string> SchoolsTree { get; set; }

    }
}
