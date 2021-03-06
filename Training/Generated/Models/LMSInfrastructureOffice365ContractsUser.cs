// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace XWinji.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class LMSInfrastructureOffice365ContractsUser
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSInfrastructureOffice365ContractsUser class.
        /// </summary>
        public LMSInfrastructureOffice365ContractsUser() { }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSInfrastructureOffice365ContractsUser class.
        /// </summary>
        public LMSInfrastructureOffice365ContractsUser(string id = default(string), string objectId = default(string), string displayName = default(string), string mail = default(string), string userPrincipalName = default(string))
        {
            Id = id;
            ObjectId = objectId;
            DisplayName = displayName;
            Mail = mail;
            UserPrincipalName = userPrincipalName;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ObjectId")]
        public string ObjectId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Mail")]
        public string Mail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserPrincipalName")]
        public string UserPrincipalName { get; set; }

    }
}
