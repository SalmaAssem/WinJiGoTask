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
    /// Extension methods for GradeApi.
    /// </summary>
    public static partial class GradeApiExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static IList<LMSDomainCoreModelsGrade> GetGrades(this IGradeApi operations, string lang)
            {
                return operations.GetGradesAsync(lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LMSDomainCoreModelsGrade>> GetGradesAsync(this IGradeApi operations, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGradesWithHttpMessagesAsync(lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static LMSWebCoreViewModelsGradeDetailsViewModel GetGradesDetails(this IGradeApi operations, string lang)
            {
                return operations.GetGradesDetailsAsync(lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LMSWebCoreViewModelsGradeDetailsViewModel> GetGradesDetailsAsync(this IGradeApi operations, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGradesDetailsWithHttpMessagesAsync(lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}