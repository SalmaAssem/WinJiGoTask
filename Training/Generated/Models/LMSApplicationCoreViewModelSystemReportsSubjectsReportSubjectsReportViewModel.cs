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

    public partial class LMSApplicationCoreViewModelSystemReportsSubjectsReportSubjectsReportViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsSubjectsReportSubjectsReportViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsSubjectsReportSubjectsReportViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSystemReportsSubjectsReportSubjectsReportViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelSystemReportsSubjectsReportSubjectsReportViewModel(string gradeName = default(string), IList<LMSApplicationCoreViewModelSystemReportsSubjectsReportSubjectClassesViewModel> subjects = default(IList<LMSApplicationCoreViewModelSystemReportsSubjectsReportSubjectClassesViewModel>))
        {
            GradeName = gradeName;
            Subjects = subjects;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GradeName")]
        public string GradeName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Subjects")]
        public IList<LMSApplicationCoreViewModelSystemReportsSubjectsReportSubjectClassesViewModel> Subjects { get; set; }

    }
}
