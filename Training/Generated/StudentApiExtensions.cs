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
    /// Extension methods for StudentApi.
    /// </summary>
    public static partial class StudentApiExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='code'>
            /// </param>
            /// <param name='language'>
            /// </param>
            public static LMSApplicationCoreViewModelStudentsStudentViewModel GetStudentByParentAccessCode(this IStudentApi operations, string code, string language)
            {
                return operations.GetStudentByParentAccessCodeAsync(code, language).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='code'>
            /// </param>
            /// <param name='language'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LMSApplicationCoreViewModelStudentsStudentViewModel> GetStudentByParentAccessCodeAsync(this IStudentApi operations, string code, string language, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStudentByParentAccessCodeWithHttpMessagesAsync(code, language, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='code'>
            /// </param>
            public static LMSApplicationCoreViewModelStudentsStudentViewModel RemoveStudentByParentAccessCode(this IStudentApi operations, string code)
            {
                return operations.RemoveStudentByParentAccessCodeAsync(code).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='code'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LMSApplicationCoreViewModelStudentsStudentViewModel> RemoveStudentByParentAccessCodeAsync(this IStudentApi operations, string code, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RemoveStudentByParentAccessCodeWithHttpMessagesAsync(code, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='studentId'>
            /// </param>
            /// <param name='courseId'>
            /// </param>
            public static object GetStudentCourseAttendanceSummary(this IStudentApi operations, int studentId, int courseId)
            {
                return operations.GetStudentCourseAttendanceSummaryAsync(studentId, courseId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='studentId'>
            /// </param>
            /// <param name='courseId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetStudentCourseAttendanceSummaryAsync(this IStudentApi operations, int studentId, int courseId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStudentCourseAttendanceSummaryWithHttpMessagesAsync(studentId, courseId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='includeBehavior'>
            /// </param>
            /// <param name='includeAttendance'>
            /// </param>
            public static object GetStudents(this IStudentApi operations, bool? includeBehavior = default(bool?), bool? includeAttendance = default(bool?))
            {
                return operations.GetStudentsAsync(includeBehavior, includeAttendance).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='includeBehavior'>
            /// </param>
            /// <param name='includeAttendance'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetStudentsAsync(this IStudentApi operations, bool? includeBehavior = default(bool?), bool? includeAttendance = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStudentsWithHttpMessagesAsync(includeBehavior, includeAttendance, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static object GetParentDetails(this IStudentApi operations)
            {
                return operations.GetParentDetailsAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetParentDetailsAsync(this IStudentApi operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetParentDetailsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='studentCode'>
            /// </param>
            public static object GetStudentCourses(this IStudentApi operations, string studentCode)
            {
                return operations.GetStudentCoursesAsync(studentCode).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='studentCode'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetStudentCoursesAsync(this IStudentApi operations, string studentCode, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStudentCoursesWithHttpMessagesAsync(studentCode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='studentCode'>
            /// </param>
            public static object GetStudentActiveCourses(this IStudentApi operations, string studentCode)
            {
                return operations.GetStudentActiveCoursesAsync(studentCode).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='studentCode'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetStudentActiveCoursesAsync(this IStudentApi operations, string studentCode, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStudentActiveCoursesWithHttpMessagesAsync(studentCode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='courseId'>
            /// </param>
            public static LMSApplicationCoreViewModelStudentsStudentCourseViewModel GetStudentCoursesByCourseId(this IStudentApi operations, string courseId)
            {
                return operations.GetStudentCoursesByCourseIdAsync(courseId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='courseId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LMSApplicationCoreViewModelStudentsStudentCourseViewModel> GetStudentCoursesByCourseIdAsync(this IStudentApi operations, string courseId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStudentCoursesByCourseIdWithHttpMessagesAsync(courseId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='studentCode'>
            /// </param>
            /// <param name='courseId'>
            /// </param>
            public static LMSApplicationCoreViewModelStudentsStudentCourseViewModel GetStudentCoursesByCourseId1(this IStudentApi operations, string studentCode, string courseId)
            {
                return operations.GetStudentCoursesByCourseId1Async(studentCode, courseId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='studentCode'>
            /// </param>
            /// <param name='courseId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LMSApplicationCoreViewModelStudentsStudentCourseViewModel> GetStudentCoursesByCourseId1Async(this IStudentApi operations, string studentCode, string courseId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStudentCoursesByCourseId1WithHttpMessagesAsync(studentCode, courseId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='courseId'>
            /// </param>
            public static LMSApplicationCoreViewModelStudentsStudentCourseDetailsViewModel GetStudentCourseBlocksByCourseId(this IStudentApi operations, string courseId)
            {
                return operations.GetStudentCourseBlocksByCourseIdAsync(courseId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='courseId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LMSApplicationCoreViewModelStudentsStudentCourseDetailsViewModel> GetStudentCourseBlocksByCourseIdAsync(this IStudentApi operations, string courseId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStudentCourseBlocksByCourseIdWithHttpMessagesAsync(courseId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='studentCode'>
            /// </param>
            /// <param name='courseId'>
            /// </param>
            public static LMSApplicationCoreViewModelStudentsStudentCourseDetailsViewModel GetStudentCourseBlocksByCourseId1(this IStudentApi operations, string studentCode, string courseId)
            {
                return operations.GetStudentCourseBlocksByCourseId1Async(studentCode, courseId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='studentCode'>
            /// </param>
            /// <param name='courseId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LMSApplicationCoreViewModelStudentsStudentCourseDetailsViewModel> GetStudentCourseBlocksByCourseId1Async(this IStudentApi operations, string studentCode, string courseId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStudentCourseBlocksByCourseId1WithHttpMessagesAsync(studentCode, courseId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='addUpdateSeatingChartCommand'>
            /// </param>
            public static object UpdateStudentsSeatingChart(this IStudentApi operations, LMSApplicationCoreCommandsSeatingChartSeatingChartAddUpdateCommand addUpdateSeatingChartCommand)
            {
                return operations.UpdateStudentsSeatingChartAsync(addUpdateSeatingChartCommand).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='addUpdateSeatingChartCommand'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> UpdateStudentsSeatingChartAsync(this IStudentApi operations, LMSApplicationCoreCommandsSeatingChartSeatingChartAddUpdateCommand addUpdateSeatingChartCommand, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateStudentsSeatingChartWithHttpMessagesAsync(addUpdateSeatingChartCommand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
