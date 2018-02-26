// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SchoolTypeApi.
    /// </summary>
    public static partial class SchoolTypeApiExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='orgId'>
            /// </param>
            public static IList<LMSDomainCoreModelsOffice365OrganizationSchoolType> GetSchoolTypes(this ISchoolTypeApi operations, string lang, string orgId = default(string))
            {
                return operations.GetSchoolTypesAsync(lang, orgId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='orgId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LMSDomainCoreModelsOffice365OrganizationSchoolType>> GetSchoolTypesAsync(this ISchoolTypeApi operations, string lang, string orgId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSchoolTypesWithHttpMessagesAsync(lang, orgId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
