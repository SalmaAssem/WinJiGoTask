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

    public partial class LMSApplicationCoreViewModelTrackTrackViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelTrackTrackViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelTrackTrackViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelTrackTrackViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelTrackTrackViewModel(string id = default(string), string title = default(string), string description = default(string), int? membersCount = default(int?), int? coursesCount = default(int?), IList<LMSApplicationCoreViewModelTrackCourseViewModel> courses = default(IList<LMSApplicationCoreViewModelTrackCourseViewModel>), string ownerName = default(string), bool? trackOwner = default(bool?))
        {
            Id = id;
            Title = title;
            Description = description;
            MembersCount = membersCount;
            CoursesCount = coursesCount;
            Courses = courses;
            OwnerName = ownerName;
            TrackOwner = trackOwner;
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
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MembersCount")]
        public int? MembersCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CoursesCount")]
        public int? CoursesCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Courses")]
        public IList<LMSApplicationCoreViewModelTrackCourseViewModel> Courses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OwnerName")]
        public string OwnerName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TrackOwner")]
        public bool? TrackOwner { get; set; }

    }
}
