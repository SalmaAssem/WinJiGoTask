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

    public partial class LMSApplicationCoreViewModelTourPagesListViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelTourPagesListViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelTourPagesListViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelTourPagesListViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelTourPagesListViewModel(string fullName = default(string), string roleName = default(string), bool? isShowWelcome = default(bool?), IList<LMSApplicationCoreViewModelTourPageViewModel> tourPagesViewModel = default(IList<LMSApplicationCoreViewModelTourPageViewModel>))
        {
            FullName = fullName;
            RoleName = roleName;
            IsShowWelcome = isShowWelcome;
            TourPagesViewModel = tourPagesViewModel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FullName")]
        public string FullName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RoleName")]
        public string RoleName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsShowWelcome")]
        public bool? IsShowWelcome { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TourPagesViewModel")]
        public IList<LMSApplicationCoreViewModelTourPageViewModel> TourPagesViewModel { get; set; }

    }
}
