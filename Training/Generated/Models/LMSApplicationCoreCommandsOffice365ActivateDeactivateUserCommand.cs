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

    public partial class LMSApplicationCoreCommandsOffice365ActivateDeactivateUserCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsOffice365ActivateDeactivateUserCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsOffice365ActivateDeactivateUserCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreCommandsOffice365ActivateDeactivateUserCommand
        /// class.
        /// </summary>
        public LMSApplicationCoreCommandsOffice365ActivateDeactivateUserCommand(IList<int?> usersIds = default(IList<int?>), bool? isActive = default(bool?))
        {
            UsersIds = usersIds;
            IsActive = isActive;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UsersIds")]
        public IList<int?> UsersIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

    }
}