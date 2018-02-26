// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelPostViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelPostViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelPostViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelPostViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelPostViewModel(string id = default(string), string userFullName = default(string), string userProfilePictureUrl = default(string), string userProfilePictureUrlSmall = default(string), string body = default(string), bool? isEdited = default(bool?), bool? isOwner = default(bool?), int? numberOfComments = default(int?), System.DateTime? postDate = default(System.DateTime?), int? userId = default(int?), string postFileId = default(string), LMSDomainCoreModelsFileData postFileData = default(LMSDomainCoreModelsFileData), string playURL = default(string), bool? unableToPlayOfficeDocument = default(bool?), bool? isPostContainsImage = default(bool?), bool? isActive = default(bool?), string postFileUri = default(string), string postFileMinifiedUri = default(string), bool? isUserCanViewUserProfile = default(bool?), bool? isFileAdded = default(bool?), LMSApplicationCoreViewModelReflectionReflectionViewModel reflection = default(LMSApplicationCoreViewModelReflectionReflectionViewModel))
        {
            Id = id;
            UserFullName = userFullName;
            UserProfilePictureUrl = userProfilePictureUrl;
            UserProfilePictureUrlSmall = userProfilePictureUrlSmall;
            Body = body;
            IsEdited = isEdited;
            IsOwner = isOwner;
            NumberOfComments = numberOfComments;
            PostDate = postDate;
            UserId = userId;
            PostFileId = postFileId;
            PostFileData = postFileData;
            PlayURL = playURL;
            UnableToPlayOfficeDocument = unableToPlayOfficeDocument;
            IsPostContainsImage = isPostContainsImage;
            IsActive = isActive;
            PostFileUri = postFileUri;
            PostFileMinifiedUri = postFileMinifiedUri;
            IsUserCanViewUserProfile = isUserCanViewUserProfile;
            IsFileAdded = isFileAdded;
            Reflection = reflection;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserFullName")]
        public string UserFullName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserProfilePictureUrl")]
        public string UserProfilePictureUrl { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserProfilePictureUrlSmall")]
        public string UserProfilePictureUrlSmall { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Body")]
        public string Body { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEdited")]
        public bool? IsEdited { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsOwner")]
        public bool? IsOwner { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfComments")]
        public int? NumberOfComments { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PostDate")]
        public System.DateTime? PostDate { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public int? UserId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PostFileId")]
        public string PostFileId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PostFileData")]
        public LMSDomainCoreModelsFileData PostFileData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PlayURL")]
        public string PlayURL { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UnableToPlayOfficeDocument")]
        public bool? UnableToPlayOfficeDocument { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsPostContainsImage")]
        public bool? IsPostContainsImage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PostFileUri")]
        public string PostFileUri { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PostFileMinifiedUri")]
        public string PostFileMinifiedUri { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsUserCanViewUserProfile")]
        public bool? IsUserCanViewUserProfile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsFileAdded")]
        public bool? IsFileAdded { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Reflection")]
        public LMSApplicationCoreViewModelReflectionReflectionViewModel Reflection { get; set; }

    }
}
