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
    /// Extension methods for TagsApi.
    /// </summary>
    public static partial class TagsApiExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tagsCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static LMSApplicationCoreViewModelContextTagsViewModel AddTags(this ITagsApi operations, LMSApplicationCoreCommandsTagsCommand tagsCommand, string lang)
            {
                return operations.AddTagsAsync(tagsCommand, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tagsCommand'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LMSApplicationCoreViewModelContextTagsViewModel> AddTagsAsync(this ITagsApi operations, LMSApplicationCoreCommandsTagsCommand tagsCommand, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddTagsWithHttpMessagesAsync(tagsCommand, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='contextId'>
            /// </param>
            /// <param name='contextTypeId'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static IList<LMSApplicationCoreViewModelContextTagsViewModel> GetContextTags(this ITagsApi operations, int contextId, int contextTypeId, string lang)
            {
                return operations.GetContextTagsAsync(contextId, contextTypeId, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='contextId'>
            /// </param>
            /// <param name='contextTypeId'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LMSApplicationCoreViewModelContextTagsViewModel>> GetContextTagsAsync(this ITagsApi operations, int contextId, int contextTypeId, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetContextTagsWithHttpMessagesAsync(contextId, contextTypeId, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            public static IList<string> GetAllTags(this ITagsApi operations, string input, string lang)
            {
                return operations.GetAllTagsAsync(input, lang).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// </param>
            /// <param name='lang'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> GetAllTagsAsync(this ITagsApi operations, string input, string lang, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAllTagsWithHttpMessagesAsync(input, lang, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}