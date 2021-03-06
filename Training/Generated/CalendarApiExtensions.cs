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
    /// Extension methods for CalendarApi.
    /// </summary>
    public static partial class CalendarApiExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='calendarGetEventsCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static IList<LMSApplicationCoreViewModelCalendarEventViewModel> GetCalendarEvents(this ICalendarApi operations, LMSApplicationCoreCommandsCalendarGetEventsCommand calendarGetEventsCommand, string lang)
            {
                return operations.GetCalendarEventsAsync(calendarGetEventsCommand, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='calendarGetEventsCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LMSApplicationCoreViewModelCalendarEventViewModel>> GetCalendarEventsAsync(this ICalendarApi operations, LMSApplicationCoreCommandsCalendarGetEventsCommand calendarGetEventsCommand, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCalendarEventsWithHttpMessagesAsync(calendarGetEventsCommand, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static IList<LMSApplicationCoreViewModelContextViewModel> GetCalendarContexts(this ICalendarApi operations, string lang)
            {
                return operations.GetCalendarContextsAsync(lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LMSApplicationCoreViewModelContextViewModel>> GetCalendarContextsAsync(this ICalendarApi operations, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCalendarContextsWithHttpMessagesAsync(lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
