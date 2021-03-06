// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for OrganizationUserAPI.
    /// </summary>
    public static partial class OrganizationUserAPIExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='memberId'>
            /// </param>
            /// <param name='organizationId'>
            /// </param>
            /// <param name='roleId'>
            /// </param>
            /// <param name='schoolId'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static object RemoveUserFromOrganization(this IOrganizationUserAPI operations, int memberId, string organizationId, int roleId, string schoolId, string lang)
            {
                return operations.RemoveUserFromOrganizationAsync(memberId, organizationId, roleId, schoolId, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='memberId'>
            /// </param>
            /// <param name='organizationId'>
            /// </param>
            /// <param name='roleId'>
            /// </param>
            /// <param name='schoolId'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> RemoveUserFromOrganizationAsync(this IOrganizationUserAPI operations, int memberId, string organizationId, int roleId, string schoolId, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RemoveUserFromOrganizationWithHttpMessagesAsync(memberId, organizationId, roleId, schoolId, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
