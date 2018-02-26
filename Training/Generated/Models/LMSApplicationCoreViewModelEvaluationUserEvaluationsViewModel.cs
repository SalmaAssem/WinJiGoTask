// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelEvaluationUserEvaluationsViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelEvaluationUserEvaluationsViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelEvaluationUserEvaluationsViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelEvaluationUserEvaluationsViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelEvaluationUserEvaluationsViewModel(int? userId = default(int?), string userName = default(string), int? evaluatorId = default(int?), string evaluatorName = default(string), string evaluatorImage = default(string), System.DateTime? creationDate = default(System.DateTime?), int? lastModifiedByUserId = default(int?), string lastModifiedByUserName = default(string), System.DateTime? lastModifiedDate = default(System.DateTime?), string evaluationFileId = default(string), string evaluationFileName = default(string), bool? isEvaluationContainsImage = default(bool?), string evaluationFileContentType = default(string), string evaluationFilePlayURL = default(string), long? evaluationFileSize = default(long?), string evaluationFilePath = default(string), bool? evaluationFileUnableToPlayOfficeDocument = default(bool?), int? userEvaluationType = default(int?), string formTemplateId = default(string), string submittedFormBody = default(string), LMSDomainCoreViewModelsFormTemplateViewModel formTemplate = default(LMSDomainCoreViewModelsFormTemplateViewModel), int? id = default(int?))
        {
            UserId = userId;
            UserName = userName;
            EvaluatorId = evaluatorId;
            EvaluatorName = evaluatorName;
            EvaluatorImage = evaluatorImage;
            CreationDate = creationDate;
            LastModifiedByUserId = lastModifiedByUserId;
            LastModifiedByUserName = lastModifiedByUserName;
            LastModifiedDate = lastModifiedDate;
            EvaluationFileId = evaluationFileId;
            EvaluationFileName = evaluationFileName;
            IsEvaluationContainsImage = isEvaluationContainsImage;
            EvaluationFileContentType = evaluationFileContentType;
            EvaluationFilePlayURL = evaluationFilePlayURL;
            EvaluationFileSize = evaluationFileSize;
            EvaluationFilePath = evaluationFilePath;
            EvaluationFileUnableToPlayOfficeDocument = evaluationFileUnableToPlayOfficeDocument;
            UserEvaluationType = userEvaluationType;
            FormTemplateId = formTemplateId;
            SubmittedFormBody = submittedFormBody;
            FormTemplate = formTemplate;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public int? UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserName")]
        public string UserName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EvaluatorId")]
        public int? EvaluatorId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EvaluatorName")]
        public string EvaluatorName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EvaluatorImage")]
        public string EvaluatorImage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreationDate")]
        public System.DateTime? CreationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastModifiedByUserId")]
        public int? LastModifiedByUserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastModifiedByUserName")]
        public string LastModifiedByUserName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastModifiedDate")]
        public System.DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EvaluationFileId")]
        public string EvaluationFileId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EvaluationFileName")]
        public string EvaluationFileName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEvaluationContainsImage")]
        public bool? IsEvaluationContainsImage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EvaluationFileContentType")]
        public string EvaluationFileContentType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EvaluationFilePlayURL")]
        public string EvaluationFilePlayURL { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EvaluationFileSize")]
        public long? EvaluationFileSize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EvaluationFilePath")]
        public string EvaluationFilePath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EvaluationFileUnableToPlayOfficeDocument")]
        public bool? EvaluationFileUnableToPlayOfficeDocument { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserEvaluationType")]
        public int? UserEvaluationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FormTemplateId")]
        public string FormTemplateId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubmittedFormBody")]
        public string SubmittedFormBody { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FormTemplate")]
        public LMSDomainCoreViewModelsFormTemplateViewModel FormTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

    }
}