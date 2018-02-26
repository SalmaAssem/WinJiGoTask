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
    /// Extension methods for CourseCatalogueApi.
    /// </summary>
    public static partial class CourseCatalogueApiExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='keyword'>
            /// </param>
            /// <param name='subjectId'>
            /// </param>
            /// <param name='gradeId'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='instructor'>
            /// </param>
            /// <param name='organizationId'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static object GetCourseCatalogues(this ICourseCatalogueApi operations, string keyword, int subjectId, int gradeId, int count, string instructor, string organizationId, string lang)
            {
                return operations.GetCourseCataloguesAsync(keyword, subjectId, gradeId, count, instructor, organizationId, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='keyword'>
            /// </param>
            /// <param name='subjectId'>
            /// </param>
            /// <param name='gradeId'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='instructor'>
            /// </param>
            /// <param name='organizationId'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetCourseCataloguesAsync(this ICourseCatalogueApi operations, string keyword, int subjectId, int gradeId, int count, string instructor, string organizationId, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCourseCataloguesWithHttpMessagesAsync(keyword, subjectId, gradeId, count, instructor, organizationId, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}