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

    public partial class LMSApplicationCoreViewModelTourPageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelTourPageViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelTourPageViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelTourPageViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelTourPageViewModel(string pageName = default(string), bool? isVisited = default(bool?), IList<LMSDomainCoreModelsTourStep> tourSteps = default(IList<LMSDomainCoreModelsTourStep>))
        {
            PageName = pageName;
            IsVisited = isVisited;
            TourSteps = tourSteps;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PageName")]
        public string PageName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsVisited")]
        public bool? IsVisited { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TourSteps")]
        public IList<LMSDomainCoreModelsTourStep> TourSteps { get; set; }

    }
}
