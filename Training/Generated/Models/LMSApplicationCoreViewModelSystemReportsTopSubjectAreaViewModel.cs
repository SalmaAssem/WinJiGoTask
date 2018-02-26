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

    public partial class LMSApplicationCoreViewModelSystemReportsTopSubjectAreaViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsTopSubjectAreaViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsTopSubjectAreaViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsTopSubjectAreaViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsTopSubjectAreaViewModel(int? coursesGroupsCount = default(int?), int? courseRoundsCount = default(int?), IList<LMSApplicationCoreViewModelSystemReportsTopVisitedCourseGroupSubjectViewModel> subjectAreaCourses = default(IList<LMSApplicationCoreViewModelSystemReportsTopVisitedCourseGroupSubjectViewModel>))
        {
            CoursesGroupsCount = coursesGroupsCount;
            CourseRoundsCount = courseRoundsCount;
            SubjectAreaCourses = subjectAreaCourses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CoursesGroupsCount")]
        public int? CoursesGroupsCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseRoundsCount")]
        public int? CourseRoundsCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubjectAreaCourses")]
        public IList<LMSApplicationCoreViewModelSystemReportsTopVisitedCourseGroupSubjectViewModel> SubjectAreaCourses { get; set; }

    }
}
