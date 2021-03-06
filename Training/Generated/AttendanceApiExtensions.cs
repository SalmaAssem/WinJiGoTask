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
    /// Extension methods for AttendanceApi.
    /// </summary>
    public static partial class AttendanceApiExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='saveUerAttendanceCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static object SaveSessionAttendance(this IAttendanceApi operations, LMSApplicationCoreCommandsAttendancesSaveSessionAttendanceCommand saveUerAttendanceCommand, string lang)
            {
                return operations.SaveSessionAttendanceAsync(saveUerAttendanceCommand, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='saveUerAttendanceCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> SaveSessionAttendanceAsync(this IAttendanceApi operations, LMSApplicationCoreCommandsAttendancesSaveSessionAttendanceCommand saveUerAttendanceCommand, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SaveSessionAttendanceWithHttpMessagesAsync(saveUerAttendanceCommand, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='saveUerAttendanceCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static object SaveStudentSessionAttendance(this IAttendanceApi operations, LMSApplicationCoreCommandsAttendancesSaveStudentSessionAttendanceCommand saveUerAttendanceCommand, string lang)
            {
                return operations.SaveStudentSessionAttendanceAsync(saveUerAttendanceCommand, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='saveUerAttendanceCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> SaveStudentSessionAttendanceAsync(this IAttendanceApi operations, LMSApplicationCoreCommandsAttendancesSaveStudentSessionAttendanceCommand saveUerAttendanceCommand, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SaveStudentSessionAttendanceWithHttpMessagesAsync(saveUerAttendanceCommand, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static IList<LMSApplicationCoreViewModelAttendanceCourseViewModel> GetCourseGroupsWithPastActiveSessions(this IAttendanceApi operations, string lang)
            {
                return operations.GetCourseGroupsWithPastActiveSessionsAsync(lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LMSApplicationCoreViewModelAttendanceCourseViewModel>> GetCourseGroupsWithPastActiveSessionsAsync(this IAttendanceApi operations, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCourseGroupsWithPastActiveSessionsWithHttpMessagesAsync(lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static IList<LMSApplicationCoreViewModelClassViewModel> GetClasses(this IAttendanceApi operations, string lang)
            {
                return operations.GetClassesAsync(lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LMSApplicationCoreViewModelClassViewModel>> GetClassesAsync(this IAttendanceApi operations, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetClassesWithHttpMessagesAsync(lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='classId'>
            /// </param>
            /// <param name='date'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='pageNumber'>
            /// </param>
            public static IList<LMSApplicationCoreViewModelAttendancePerDayViewModel> GetClasseUsers(this IAttendanceApi operations, int classId, System.DateTime date, string lang, int? pageNumber = default(int?))
            {
                return operations.GetClasseUsersAsync(classId, date, lang, pageNumber).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='classId'>
            /// </param>
            /// <param name='date'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='pageNumber'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LMSApplicationCoreViewModelAttendancePerDayViewModel>> GetClasseUsersAsync(this IAttendanceApi operations, int classId, System.DateTime date, string lang, int? pageNumber = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetClasseUsersWithHttpMessagesAsync(classId, date, lang, pageNumber, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static IList<LMSApplicationCoreViewModelAttendanceStatusBasicInfo> GetAllAttendanceStatus(this IAttendanceApi operations, string lang)
            {
                return operations.GetAllAttendanceStatusAsync(lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LMSApplicationCoreViewModelAttendanceStatusBasicInfo>> GetAllAttendanceStatusAsync(this IAttendanceApi operations, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAllAttendanceStatusWithHttpMessagesAsync(lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='saveDayAttendanceCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static object SaveDayAttendance(this IAttendanceApi operations, LMSApplicationCoreViewModelSaveDayAttendanceCommand saveDayAttendanceCommand, string lang)
            {
                return operations.SaveDayAttendanceAsync(saveDayAttendanceCommand, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='saveDayAttendanceCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> SaveDayAttendanceAsync(this IAttendanceApi operations, LMSApplicationCoreViewModelSaveDayAttendanceCommand saveDayAttendanceCommand, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SaveDayAttendanceWithHttpMessagesAsync(saveDayAttendanceCommand, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
