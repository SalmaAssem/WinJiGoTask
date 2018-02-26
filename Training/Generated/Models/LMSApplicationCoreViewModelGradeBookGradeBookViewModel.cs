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

    public partial class LMSApplicationCoreViewModelGradeBookGradeBookViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelGradeBookGradeBookViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelGradeBookGradeBookViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelGradeBookGradeBookViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelGradeBookGradeBookViewModel(int? courseId = default(int?), int? totalCount = default(int?), IList<LMSApplicationCoreViewModelGradeBookGradeBookInfo> gradeBooks = default(IList<LMSApplicationCoreViewModelGradeBookGradeBookInfo>), IList<LMSApplicationCoreViewModelGradeBookUserGradeBooks> userGradeBooks = default(IList<LMSApplicationCoreViewModelGradeBookUserGradeBooks>))
        {
            CourseId = courseId;
            TotalCount = totalCount;
            GradeBooks = gradeBooks;
            UserGradeBooks = userGradeBooks;
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
        [JsonProperty(PropertyName = "TotalCount")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradeBooks")]
        public IList<LMSApplicationCoreViewModelGradeBookGradeBookInfo> GradeBooks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserGradeBooks")]
        public IList<LMSApplicationCoreViewModelGradeBookUserGradeBooks> UserGradeBooks { get; set; }

    }
}