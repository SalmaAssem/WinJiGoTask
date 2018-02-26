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

    public partial class LMSApplicationCoreViewModelOffice365ManageGradeViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelOffice365ManageGradeViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelOffice365ManageGradeViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelOffice365ManageGradeViewModel class.
        /// </summary>
        public LMSApplicationCoreViewModelOffice365ManageGradeViewModel(int? id = default(int?), string name = default(string), string contextId = default(string), int? contextTypeId = default(int?), int? instituteTypeId = default(int?), string translationKey = default(string), IList<LMSApplicationCoreViewModelTranslationViewModel> nameTranslations = default(IList<LMSApplicationCoreViewModelTranslationViewModel>), string uniqueIdentifier = default(string))
        {
            Id = id;
            Name = name;
            ContextId = contextId;
            ContextTypeId = contextTypeId;
            InstituteTypeId = instituteTypeId;
            TranslationKey = translationKey;
            NameTranslations = nameTranslations;
            UniqueIdentifier = uniqueIdentifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContextId")]
        public string ContextId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContextTypeId")]
        public int? ContextTypeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InstituteTypeId")]
        public int? InstituteTypeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TranslationKey")]
        public string TranslationKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NameTranslations")]
        public IList<LMSApplicationCoreViewModelTranslationViewModel> NameTranslations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UniqueIdentifier")]
        public string UniqueIdentifier { get; set; }

    }
}
