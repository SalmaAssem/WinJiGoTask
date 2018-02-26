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

    public partial class LMSApplicationCoreCommandsGetMembersCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsGetMembersCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsGetMembersCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsGetMembersCommand class.
        /// </summary>
        public LMSApplicationCoreCommandsGetMembersCommand(IList<string> selectedSchoolIds = default(IList<string>), int? roleId = default(int?), int? skip = default(int?), int? take = default(int?), string keyword = default(string), bool? searchMyMenteesOnly = default(bool?), bool? onlyTeachingCategory = default(bool?), bool? includeParents = default(bool?))
        {
            SelectedSchoolIds = selectedSchoolIds;
            RoleId = roleId;
            Skip = skip;
            Take = take;
            Keyword = keyword;
            SearchMyMenteesOnly = searchMyMenteesOnly;
            OnlyTeachingCategory = onlyTeachingCategory;
            IncludeParents = includeParents;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SelectedSchoolIds")]
        public IList<string> SelectedSchoolIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RoleId")]
        public int? RoleId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Skip")]
        public int? Skip { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Take")]
        public int? Take { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SearchMyMenteesOnly")]
        public bool? SearchMyMenteesOnly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OnlyTeachingCategory")]
        public bool? OnlyTeachingCategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IncludeParents")]
        public bool? IncludeParents { get; set; }

    }
}
