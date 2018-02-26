// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelAuthorViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelAuthorViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelAuthorViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelAuthorViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelAuthorViewModel(int? id = default(int?), string name = default(string), string bio = default(string), string pictureUrl = default(string), string authorPictureUrlSmall = default(string), bool? isCurrentUserCanEditAuthor = default(bool?), int? courseGroupsCount = default(int?), int? courseGroupsStudentsCount = default(int?), bool? isReturnCourseGroupsStudents = default(bool?))
        {
            Id = id;
            Name = name;
            Bio = bio;
            PictureUrl = pictureUrl;
            AuthorPictureUrlSmall = authorPictureUrlSmall;
            IsCurrentUserCanEditAuthor = isCurrentUserCanEditAuthor;
            CourseGroupsCount = courseGroupsCount;
            CourseGroupsStudentsCount = courseGroupsStudentsCount;
            IsReturnCourseGroupsStudents = isReturnCourseGroupsStudents;
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
        [JsonProperty(PropertyName = "Bio")]
        public string Bio { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PictureUrl")]
        public string PictureUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AuthorPictureUrlSmall")]
        public string AuthorPictureUrlSmall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCurrentUserCanEditAuthor")]
        public bool? IsCurrentUserCanEditAuthor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseGroupsCount")]
        public int? CourseGroupsCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseGroupsStudentsCount")]
        public int? CourseGroupsStudentsCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsReturnCourseGroupsStudents")]
        public bool? IsReturnCourseGroupsStudents { get; set; }

    }
}
