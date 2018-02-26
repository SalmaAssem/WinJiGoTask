// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelPhotoAlbumPhotoViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelPhotoAlbumPhotoViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelPhotoAlbumPhotoViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelPhotoAlbumPhotoViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelPhotoAlbumPhotoViewModel(string id = default(string), string path = default(string), string name = default(string), string size = default(string), string createdBy = default(string), System.DateTime? creationDate = default(System.DateTime?), string photoContextId = default(string), int? photoContextTypeId = default(int?), bool? isOwner = default(bool?), System.DateTime? albumLastModificationDate = default(System.DateTime?), string fileId = default(string))
        {
            Id = id;
            Path = path;
            Name = name;
            Size = size;
            CreatedBy = createdBy;
            CreationDate = creationDate;
            PhotoContextId = photoContextId;
            PhotoContextTypeId = photoContextTypeId;
            IsOwner = isOwner;
            AlbumLastModificationDate = albumLastModificationDate;
            FileId = fileId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Path")]
        public string Path { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Size")]
        public string Size { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatedBy")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreationDate")]
        public System.DateTime? CreationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PhotoContextId")]
        public string PhotoContextId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PhotoContextTypeId")]
        public int? PhotoContextTypeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsOwner")]
        public bool? IsOwner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AlbumLastModificationDate")]
        public System.DateTime? AlbumLastModificationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FileId")]
        public string FileId { get; set; }

    }
}
