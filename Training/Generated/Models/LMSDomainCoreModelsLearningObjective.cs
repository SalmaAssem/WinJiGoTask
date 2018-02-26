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

    public partial class LMSDomainCoreModelsLearningObjective
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSDomainCoreModelsLearningObjective class.
        /// </summary>
        public LMSDomainCoreModelsLearningObjective()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSDomainCoreModelsLearningObjective class.
        /// </summary>
        public LMSDomainCoreModelsLearningObjective(string code = default(string), string description = default(string), int? parentId = default(int?), LMSDomainCoreModelsLearningObjective parent = default(LMSDomainCoreModelsLearningObjective), IList<LMSDomainCoreModelsLearningObjective> child = default(IList<LMSDomainCoreModelsLearningObjective>), string contextId = default(string), string externalId = default(string), int? id = default(int?))
        {
            Code = code;
            Description = description;
            ParentId = parentId;
            Parent = parent;
            Child = child;
            ContextId = contextId;
            ExternalId = externalId;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Code")]
        public string Code { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ParentId")]
        public int? ParentId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Parent")]
        public LMSDomainCoreModelsLearningObjective Parent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Child")]
        public IList<LMSDomainCoreModelsLearningObjective> Child { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContextId")]
        public string ContextId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExternalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; private set; }

    }
}