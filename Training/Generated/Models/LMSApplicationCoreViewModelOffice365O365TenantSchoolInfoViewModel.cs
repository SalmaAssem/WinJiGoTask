// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelOffice365O365TenantSchoolInfoViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelOffice365O365TenantSchoolInfoViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelOffice365O365TenantSchoolInfoViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelOffice365O365TenantSchoolInfoViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelOffice365O365TenantSchoolInfoViewModel(int? numberOfCourses = default(int?), int? numberOfLearners = default(int?), int? numberOfTeachers = default(int?), int? numberOfAcademicCoordinators = default(int?))
        {
            NumberOfCourses = numberOfCourses;
            NumberOfLearners = numberOfLearners;
            NumberOfTeachers = numberOfTeachers;
            NumberOfAcademicCoordinators = numberOfAcademicCoordinators;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfCourses")]
        public int? NumberOfCourses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfLearners")]
        public int? NumberOfLearners { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfTeachers")]
        public int? NumberOfTeachers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfAcademicCoordinators")]
        public int? NumberOfAcademicCoordinators { get; set; }

    }
}