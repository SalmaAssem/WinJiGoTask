// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelSessionBasicViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSessionBasicViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelSessionBasicViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSessionBasicViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelSessionBasicViewModel(string id = default(string), bool? isActive = default(bool?), string title = default(string), string description = default(string), System.DateTime? date = default(System.DateTime?), int? duration = default(int?), int? numberOfAssessments = default(int?), System.DateTime? creationDate = default(System.DateTime?), int? sessionLockStatus = default(int?), bool? isEnabled = default(bool?), int? numberOfSubmittedAssessments = default(int?))
        {
            Id = id;
            IsActive = isActive;
            Title = title;
            Description = description;
            Date = date;
            Duration = duration;
            NumberOfAssessments = numberOfAssessments;
            CreationDate = creationDate;
            SessionLockStatus = sessionLockStatus;
            IsEnabled = isEnabled;
            NumberOfSubmittedAssessments = numberOfSubmittedAssessments;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Date")]
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfAssessments")]
        public int? NumberOfAssessments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreationDate")]
        public System.DateTime? CreationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SessionLockStatus")]
        public int? SessionLockStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfSubmittedAssessments")]
        public int? NumberOfSubmittedAssessments { get; set; }

    }
}
