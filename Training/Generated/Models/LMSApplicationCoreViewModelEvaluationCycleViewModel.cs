// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelEvaluationCycleViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelEvaluationCycleViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelEvaluationCycleViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelEvaluationCycleViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelEvaluationCycleViewModel(int? id = default(int?), string organizationSchoolId = default(string), string name = default(string), System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?), bool? isActive = default(bool?), string uniqueIdentifier = default(string))
        {
            Id = id;
            OrganizationSchoolId = organizationSchoolId;
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            IsActive = isActive;
            UniqueIdentifier = uniqueIdentifier;
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
        [JsonProperty(PropertyName = "OrganizationSchoolId")]
        public string OrganizationSchoolId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StartDate")]
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EndDate")]
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UniqueIdentifier")]
        public string UniqueIdentifier { get; set; }

    }
}