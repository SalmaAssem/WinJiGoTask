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
    /// Extension methods for EduShareApi.
    /// </summary>
    public static partial class EduShareApiExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='url'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static bool? ValidateUrl(this IEduShareApi operations, string url, string lang)
            {
                return operations.ValidateUrlAsync(url, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='url'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<bool?> ValidateUrlAsync(this IEduShareApi operations, string url, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ValidateUrlWithHttpMessagesAsync(url, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static object UserToken(this IEduShareApi operations, string lang)
            {
                return operations.UserTokenAsync(lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> UserTokenAsync(this IEduShareApi operations, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UserTokenWithHttpMessagesAsync(lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}