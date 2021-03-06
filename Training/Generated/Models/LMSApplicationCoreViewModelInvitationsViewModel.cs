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

    public partial class LMSApplicationCoreViewModelInvitationsViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelInvitationsViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelInvitationsViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelInvitationsViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelInvitationsViewModel(IList<LMSApplicationCoreViewModelCourseInvitationViewModel> courseInvitationsViewModel = default(IList<LMSApplicationCoreViewModelCourseInvitationViewModel>), IList<LMSApplicationCoreViewModelInvitationsTrackInvitationViewModel> trackInvitationsViewModel = default(IList<LMSApplicationCoreViewModelInvitationsTrackInvitationViewModel>))
        {
            CourseInvitationsViewModel = courseInvitationsViewModel;
            TrackInvitationsViewModel = trackInvitationsViewModel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseInvitationsViewModel")]
        public IList<LMSApplicationCoreViewModelCourseInvitationViewModel> CourseInvitationsViewModel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TrackInvitationsViewModel")]
        public IList<LMSApplicationCoreViewModelInvitationsTrackInvitationViewModel> TrackInvitationsViewModel { get; set; }

    }
}
