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
    /// Extension methods for EventApi.
    /// </summary>
    public static partial class EventApiExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='addEventCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static LMSApplicationCoreViewModelEventEventViewModel AddEvent(this IEventApi operations, LMSApplicationCoreCommandsEventAddEditCommand addEventCommand, string lang)
            {
                return operations.AddEventAsync(addEventCommand, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='addEventCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LMSApplicationCoreViewModelEventEventViewModel> AddEventAsync(this IEventApi operations, LMSApplicationCoreCommandsEventAddEditCommand addEventCommand, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddEventWithHttpMessagesAsync(addEventCommand, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='updateEventCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static LMSApplicationCoreViewModelEventEventViewModel UpdateEvent(this IEventApi operations, LMSApplicationCoreCommandsEventAddEditCommand updateEventCommand, string lang)
            {
                return operations.UpdateEventAsync(updateEventCommand, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='updateEventCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LMSApplicationCoreViewModelEventEventViewModel> UpdateEventAsync(this IEventApi operations, LMSApplicationCoreCommandsEventAddEditCommand updateEventCommand, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateEventWithHttpMessagesAsync(updateEventCommand, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='eventListCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static LMSApplicationCoreViewModelEventEventsListViewModel GetEvents(this IEventApi operations, LMSApplicationCoreCommandsEventsListCommand eventListCommand, string lang)
            {
                return operations.GetEventsAsync(eventListCommand, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='eventListCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LMSApplicationCoreViewModelEventEventsListViewModel> GetEventsAsync(this IEventApi operations, LMSApplicationCoreCommandsEventsListCommand eventListCommand, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEventsWithHttpMessagesAsync(eventListCommand, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='eventDeleteCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static bool? DeleteEvent(this IEventApi operations, LMSApplicationCoreCommandsEventDeleteCommand eventDeleteCommand, string lang)
            {
                return operations.DeleteEventAsync(eventDeleteCommand, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='eventDeleteCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<bool?> DeleteEventAsync(this IEventApi operations, LMSApplicationCoreCommandsEventDeleteCommand eventDeleteCommand, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteEventWithHttpMessagesAsync(eventDeleteCommand, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='eventId'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static LMSApplicationCoreViewModelEventEventViewModel GetEventDetails(this IEventApi operations, string eventId, string lang)
            {
                return operations.GetEventDetailsAsync(eventId, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='eventId'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LMSApplicationCoreViewModelEventEventViewModel> GetEventDetailsAsync(this IEventApi operations, string eventId, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEventDetailsWithHttpMessagesAsync(eventId, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}