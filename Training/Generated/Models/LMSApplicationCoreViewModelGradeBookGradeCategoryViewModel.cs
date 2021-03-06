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

    public partial class LMSApplicationCoreViewModelGradeBookGradeCategoryViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelGradeBookGradeCategoryViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelGradeBookGradeCategoryViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelGradeBookGradeCategoryViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelGradeBookGradeCategoryViewModel(string gradeCategoryId = default(string), string title = default(string), double? weight = default(double?), bool? isAutoDistributedWeights = default(bool?), int? calculationMode = default(int?), int? colorIndex = default(int?), int? subjectId = default(int?), int? gradeId = default(int?), bool? isOwner = default(bool?), IList<LMSApplicationCoreViewModelGradeBookGradableItemViewModel> gradableItems = default(IList<LMSApplicationCoreViewModelGradeBookGradableItemViewModel>), IList<LMSApplicationCoreViewModelGradeBookKeyValuePair> subjects = default(IList<LMSApplicationCoreViewModelGradeBookKeyValuePair>), IList<LMSApplicationCoreViewModelGradeBookKeyValuePair> grades = default(IList<LMSApplicationCoreViewModelGradeBookKeyValuePair>), string subjectsName = default(string), string gradesName = default(string), bool? isDeleted = default(bool?), bool? isSaved = default(bool?))
        {
            GradeCategoryId = gradeCategoryId;
            Title = title;
            Weight = weight;
            IsAutoDistributedWeights = isAutoDistributedWeights;
            CalculationMode = calculationMode;
            ColorIndex = colorIndex;
            SubjectId = subjectId;
            GradeId = gradeId;
            IsOwner = isOwner;
            GradableItems = gradableItems;
            Subjects = subjects;
            Grades = grades;
            SubjectsName = subjectsName;
            GradesName = gradesName;
            IsDeleted = isDeleted;
            IsSaved = isSaved;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradeCategoryId")]
        public string GradeCategoryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsAutoDistributedWeights")]
        public bool? IsAutoDistributedWeights { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CalculationMode")]
        public int? CalculationMode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ColorIndex")]
        public int? ColorIndex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubjectId")]
        public int? SubjectId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradeId")]
        public int? GradeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsOwner")]
        public bool? IsOwner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradableItems")]
        public IList<LMSApplicationCoreViewModelGradeBookGradableItemViewModel> GradableItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Subjects")]
        public IList<LMSApplicationCoreViewModelGradeBookKeyValuePair> Subjects { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Grades")]
        public IList<LMSApplicationCoreViewModelGradeBookKeyValuePair> Grades { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubjectsName")]
        public string SubjectsName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradesName")]
        public string GradesName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsDeleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsSaved")]
        public bool? IsSaved { get; set; }

    }
}
