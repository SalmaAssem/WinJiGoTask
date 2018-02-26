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

    public partial class LMSApplicationCoreAssignLearnerCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreAssignLearnerCommand class.
        /// </summary>
        public LMSApplicationCoreAssignLearnerCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreAssignLearnerCommand class.
        /// </summary>
        public LMSApplicationCoreAssignLearnerCommand(int? courseId = default(int?), bool? searchBySpace = default(bool?), IList<LMSApplicationCoreAssignCourseSearchCrieteria> allSearchedCriterias = default(IList<LMSApplicationCoreAssignCourseSearchCrieteria>))
        {
            CourseId = courseId;
            SearchBySpace = searchBySpace;
            AllSearchedCriterias = allSearchedCriterias;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseId")]
        public int? CourseId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SearchBySpace")]
        public bool? SearchBySpace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllSearchedCriterias")]
        public IList<LMSApplicationCoreAssignCourseSearchCrieteria> AllSearchedCriterias { get; set; }

    }
}
