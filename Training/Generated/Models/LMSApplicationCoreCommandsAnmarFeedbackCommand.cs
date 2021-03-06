// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreCommandsAnmarFeedbackCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsAnmarFeedbackCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsAnmarFeedbackCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsAnmarFeedbackCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsAnmarFeedbackCommand(string title = default(string), string issueDescription = default(string), int? categoryId = default(int?), int? subCategoryId = default(int?), int? managmentId = default(int?), string categoryName = default(string), string subcategoryName = default(string), string managmentString = default(string), string mobile = default(string), string body = default(string), string email = default(string), byte[] attachment = default(byte[]), bool? hasAttachment = default(bool?))
        {
            Title = title;
            IssueDescription = issueDescription;
            CategoryId = categoryId;
            SubCategoryId = subCategoryId;
            ManagmentId = managmentId;
            CategoryName = categoryName;
            SubcategoryName = subcategoryName;
            ManagmentString = managmentString;
            Mobile = mobile;
            Body = body;
            Email = email;
            Attachment = attachment;
            HasAttachment = hasAttachment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IssueDescription")]
        public string IssueDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CategoryId")]
        public int? CategoryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubCategoryId")]
        public int? SubCategoryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ManagmentId")]
        public int? ManagmentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CategoryName")]
        public string CategoryName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubcategoryName")]
        public string SubcategoryName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ManagmentString")]
        public string ManagmentString { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Body")]
        public string Body { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Attachment")]
        public byte[] Attachment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HasAttachment")]
        public bool? HasAttachment { get; set; }

    }
}
