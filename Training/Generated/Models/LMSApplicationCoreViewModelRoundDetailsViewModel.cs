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

    public partial class LMSApplicationCoreViewModelRoundDetailsViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelRoundDetailsViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelRoundDetailsViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelRoundDetailsViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelRoundDetailsViewModel(LMSDomainCoreModelsRoundBaseViewModel roundBasicInfo = default(LMSDomainCoreModelsRoundBaseViewModel), IList<LMSApplicationCoreViewModelSessionBasicViewModel> sessions = default(IList<LMSApplicationCoreViewModelSessionBasicViewModel>), IList<LMSApplicationCoreViewModelCourseStudentsViewModel> students = default(IList<LMSApplicationCoreViewModelCourseStudentsViewModel>), IList<LMSApplicationCoreViewModelCourseMembersViewModel> members = default(IList<LMSApplicationCoreViewModelCourseMembersViewModel>), LMSApplicationCoreViewModelMaterialDetailsViewModel finalAssessment = default(LMSApplicationCoreViewModelMaterialDetailsViewModel), IList<LMSApplicationCoreViewModelGradeBookGradeCategoryViewModel> gradeCategories = default(IList<LMSApplicationCoreViewModelGradeBookGradeCategoryViewModel>))
        {
            RoundBasicInfo = roundBasicInfo;
            Sessions = sessions;
            Students = students;
            Members = members;
            FinalAssessment = finalAssessment;
            GradeCategories = gradeCategories;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RoundBasicInfo")]
        public LMSDomainCoreModelsRoundBaseViewModel RoundBasicInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Sessions")]
        public IList<LMSApplicationCoreViewModelSessionBasicViewModel> Sessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Students")]
        public IList<LMSApplicationCoreViewModelCourseStudentsViewModel> Students { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Members")]
        public IList<LMSApplicationCoreViewModelCourseMembersViewModel> Members { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FinalAssessment")]
        public LMSApplicationCoreViewModelMaterialDetailsViewModel FinalAssessment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradeCategories")]
        public IList<LMSApplicationCoreViewModelGradeBookGradeCategoryViewModel> GradeCategories { get; set; }

    }
}
