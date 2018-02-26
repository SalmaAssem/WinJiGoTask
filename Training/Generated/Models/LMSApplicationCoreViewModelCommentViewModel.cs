// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelCommentViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelCommentViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelCommentViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelCommentViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelCommentViewModel(string userFullName = default(string), string userProfilePictureUrl = default(string), string userProfilePictureUrlSmall = default(string), string body = default(string), bool? isOwner = default(bool?), string commentId = default(string), bool? isEdited = default(bool?), System.DateTime? commentDate = default(System.DateTime?), int? userId = default(int?), bool? isUserCanViewUserProfile = default(bool?))
        {
            UserFullName = userFullName;
            UserProfilePictureUrl = userProfilePictureUrl;
            UserProfilePictureUrlSmall = userProfilePictureUrlSmall;
            Body = body;
            IsOwner = isOwner;
            CommentId = commentId;
            IsEdited = isEdited;
            CommentDate = commentDate;
            UserId = userId;
            IsUserCanViewUserProfile = isUserCanViewUserProfile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserFullName")]
        public string UserFullName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserProfilePictureUrl")]
        public string UserProfilePictureUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserProfilePictureUrlSmall")]
        public string UserProfilePictureUrlSmall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Body")]
        public string Body { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsOwner")]
        public bool? IsOwner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CommentId")]
        public string CommentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEdited")]
        public bool? IsEdited { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CommentDate")]
        public System.DateTime? CommentDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public int? UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsUserCanViewUserProfile")]
        public bool? IsUserCanViewUserProfile { get; set; }

    }
}