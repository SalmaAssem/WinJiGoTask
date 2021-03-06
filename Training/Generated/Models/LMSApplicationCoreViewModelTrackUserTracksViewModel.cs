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

    public partial class LMSApplicationCoreViewModelTrackUserTracksViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelTrackUserTracksViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelTrackUserTracksViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelTrackUserTracksViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelTrackUserTracksViewModel(string id = default(string), string title = default(string), string description = default(string), int? coursesCount = default(int?), IList<LMSApplicationCoreViewModelTrackMyTrackCoursesViewModel> courses = default(IList<LMSApplicationCoreViewModelTrackMyTrackCoursesViewModel>), IList<int?> allCoursesIds = default(IList<int?>), bool? trackOwner = default(bool?))
        {
            Id = id;
            Title = title;
            Description = description;
            CoursesCount = coursesCount;
            Courses = courses;
            AllCoursesIds = allCoursesIds;
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
        [JsonProperty(PropertyName = "CoursesCount")]
        public int? CoursesCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Courses")]
        public IList<LMSApplicationCoreViewModelTrackMyTrackCoursesViewModel> Courses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllCoursesIds")]
        public IList<int?> AllCoursesIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TrackOwner")]
        public bool? TrackOwner { get; set; }

    }
}
