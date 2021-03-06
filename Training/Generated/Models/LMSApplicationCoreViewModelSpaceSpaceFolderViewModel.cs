// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelSpaceSpaceFolderViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSpaceSpaceFolderViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelSpaceSpaceFolderViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelSpaceSpaceFolderViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelSpaceSpaceFolderViewModel(string folderId = default(string), string folderName = default(string), string spaceId = default(string), int? resourcesCount = default(int?), string lastModifiedBy = default(string), System.DateTime? lastModifiedDate = default(System.DateTime?), bool? isOwner = default(bool?))
        {
            FolderId = folderId;
            FolderName = folderName;
            SpaceId = spaceId;
            ResourcesCount = resourcesCount;
            LastModifiedBy = lastModifiedBy;
            LastModifiedDate = lastModifiedDate;
            IsOwner = isOwner;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FolderId")]
        public string FolderId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FolderName")]
        public string FolderName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SpaceId")]
        public string SpaceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResourcesCount")]
        public int? ResourcesCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastModifiedBy")]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastModifiedDate")]
        public System.DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsOwner")]
        public bool? IsOwner { get; set; }

    }
}
