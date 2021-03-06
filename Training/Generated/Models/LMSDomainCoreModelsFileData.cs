// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSDomainCoreModelsFileData
    {
        /// <summary>
        /// Initializes a new instance of the LMSDomainCoreModelsFileData
        /// class.
        /// </summary>
        public LMSDomainCoreModelsFileData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LMSDomainCoreModelsFileData
        /// class.
        /// </summary>
        public LMSDomainCoreModelsFileData(string id = default(string), string fileName = default(string), string blobName = default(string), int? contextTypeId = default(int?), string contextId = default(string), string fileContentType = default(string), long? size = default(long?), System.DateTime? creationDate = default(System.DateTime?), int? createdBy = default(int?), System.DateTime? lastModificationDate = default(System.DateTime?), int? modifiedBy = default(int?))
        {
            Id = id;
            FileName = fileName;
            BlobName = blobName;
            ContextTypeId = contextTypeId;
            ContextId = contextId;
            FileContentType = fileContentType;
            Size = size;
            CreationDate = creationDate;
            CreatedBy = createdBy;
            LastModificationDate = lastModificationDate;
            ModifiedBy = modifiedBy;
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
        [JsonProperty(PropertyName = "FileName")]
        public string FileName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BlobName")]
        public string BlobName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContextTypeId")]
        public int? ContextTypeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContextId")]
        public string ContextId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FileContentType")]
        public string FileContentType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Size")]
        public long? Size { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreationDate")]
        public System.DateTime? CreationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatedBy")]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastModificationDate")]
        public System.DateTime? LastModificationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ModifiedBy")]
        public int? ModifiedBy { get; set; }

    }
}
