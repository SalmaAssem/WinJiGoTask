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
    /// Extension methods for IenApi.
    /// </summary>
    public static partial class IenApiExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static object GetSubjects(this IIenApi operations, string lang)
            {
                return operations.GetSubjectsAsync(lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetSubjectsAsync(this IIenApi operations, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSubjectsWithHttpMessagesAsync(lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static object Search(this IIenApi operations, LMSApplicationCoreViewModelIenIenSearchRequestCommand searchCommand, string lang)
            {
                return operations.SearchAsync(searchCommand, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> SearchAsync(this IIenApi operations, LMSApplicationCoreViewModelIenIenSearchRequestCommand searchCommand, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SearchWithHttpMessagesAsync(searchCommand, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static object SearchQuestions(this IIenApi operations, LMSApplicationCoreCommandsIenSearchQuestionsCommand searchCommand, string lang)
            {
                return operations.SearchQuestionsAsync(searchCommand, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> SearchQuestionsAsync(this IIenApi operations, LMSApplicationCoreCommandsIenSearchQuestionsCommand searchCommand, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SearchQuestionsWithHttpMessagesAsync(searchCommand, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='questionsIDs'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static object ImportQuestions(this IIenApi operations, IList<string> questionsIDs, string lang)
            {
                return operations.ImportQuestionsAsync(questionsIDs, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='questionsIDs'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ImportQuestionsAsync(this IIenApi operations, IList<string> questionsIDs, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ImportQuestionsWithHttpMessagesAsync(questionsIDs, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subjectId'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static object GetSubjectLessons(this IIenApi operations, long subjectId, string lang)
            {
                return operations.GetSubjectLessonsAsync(subjectId, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subjectId'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetSubjectLessonsAsync(this IIenApi operations, long subjectId, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSubjectLessonsWithHttpMessagesAsync(subjectId, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}