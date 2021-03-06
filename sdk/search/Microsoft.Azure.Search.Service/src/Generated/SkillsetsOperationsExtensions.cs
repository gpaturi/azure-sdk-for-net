// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SkillsetsOperations.
    /// </summary>
    public static partial class SkillsetsOperationsExtensions
    {
            /// <summary>
            /// Creates a new skillset in a search service or updates the skillset if it
            /// already exists.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/update-skillset" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skillsetName'>
            /// The name of the skillset to create or update.
            /// </param>
            /// <param name='skillset'>
            /// The skillset containing one or more skills to create or update in a search
            /// service.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Skillset CreateOrUpdate(this ISkillsetsOperations operations, string skillsetName, Skillset skillset, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return operations.CreateOrUpdateAsync(skillsetName, skillset, searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new skillset in a search service or updates the skillset if it
            /// already exists.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/update-skillset" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skillsetName'>
            /// The name of the skillset to create or update.
            /// </param>
            /// <param name='skillset'>
            /// The skillset containing one or more skills to create or update in a search
            /// service.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Skillset> CreateOrUpdateAsync(this ISkillsetsOperations operations, string skillsetName, Skillset skillset, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(skillsetName, skillset, searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a skillset in a search service.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/delete-skillset" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skillsetName'>
            /// The name of the skillset to delete.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static void Delete(this ISkillsetsOperations operations, string skillsetName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                operations.DeleteAsync(skillsetName, searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a skillset in a search service.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/delete-skillset" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skillsetName'>
            /// The name of the skillset to delete.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISkillsetsOperations operations, string skillsetName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(skillsetName, searchRequestOptions, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves a skillset in a search service.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/get-skillset" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skillsetName'>
            /// The name of the skillset to retrieve.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Skillset Get(this ISkillsetsOperations operations, string skillsetName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return operations.GetAsync(skillsetName, searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a skillset in a search service.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/get-skillset" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skillsetName'>
            /// The name of the skillset to retrieve.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Skillset> GetAsync(this ISkillsetsOperations operations, string skillsetName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(skillsetName, searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all skillsets in a search service.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/list-skillset" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static SkillsetListResult List(this ISkillsetsOperations operations, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return operations.ListAsync(searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all skillsets in a search service.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/list-skillset" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SkillsetListResult> ListAsync(this ISkillsetsOperations operations, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new skillset in a search service.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/create-skillset" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skillset'>
            /// The skillset containing one or more skills to create in a search service.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Skillset Create(this ISkillsetsOperations operations, Skillset skillset, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return operations.CreateAsync(skillset, searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new skillset in a search service.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/create-skillset" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skillset'>
            /// The skillset containing one or more skills to create in a search service.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Skillset> CreateAsync(this ISkillsetsOperations operations, Skillset skillset, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(skillset, searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
