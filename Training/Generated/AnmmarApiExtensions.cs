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
    /// Extension methods for AnmmarApi.
    /// </summary>
    public static partial class AnmmarApiExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='anmarFeedbackCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static string CreateNewTicket(this IAnmmarApi operations, LMSApplicationCoreCommandsAnmarFeedbackCommand anmarFeedbackCommand, string lang)
            {
                return operations.CreateNewTicketAsync(anmarFeedbackCommand, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='anmarFeedbackCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> CreateNewTicketAsync(this IAnmmarApi operations, LMSApplicationCoreCommandsAnmarFeedbackCommand anmarFeedbackCommand, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateNewTicketWithHttpMessagesAsync(anmarFeedbackCommand, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static LMSWebCoreAPICurrentUserInfo GetUserInfo(this IAnmmarApi operations, string lang)
            {
                return operations.GetUserInfoAsync(lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LMSWebCoreAPICurrentUserInfo> GetUserInfoAsync(this IAnmmarApi operations, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetUserInfoWithHttpMessagesAsync(lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static IList<LMSApplicationCoreViewModelAnmarTicket> GetAnmarTickets(this IAnmmarApi operations, string lang)
            {
                return operations.GetAnmarTicketsAsync(lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LMSApplicationCoreViewModelAnmarTicket>> GetAnmarTicketsAsync(this IAnmmarApi operations, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAnmarTicketsWithHttpMessagesAsync(lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}