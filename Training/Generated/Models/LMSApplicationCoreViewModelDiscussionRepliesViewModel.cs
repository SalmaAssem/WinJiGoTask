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

    public partial class LMSApplicationCoreViewModelDiscussionRepliesViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelDiscussionRepliesViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelDiscussionRepliesViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelDiscussionRepliesViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelDiscussionRepliesViewModel(IList<LMSApplicationCoreViewModelDiscussionReplyViewModel> discussionReplies = default(IList<LMSApplicationCoreViewModelDiscussionReplyViewModel>), bool? isActive = default(bool?), int? totalCount = default(int?))
        {
            DiscussionReplies = discussionReplies;
            IsActive = isActive;
            TotalCount = totalCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DiscussionReplies")]
        public IList<LMSApplicationCoreViewModelDiscussionReplyViewModel> DiscussionReplies { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TotalCount")]
        public int? TotalCount { get; private set; }

    }
}
