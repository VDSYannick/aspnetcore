using System.Collections.Generic;

namespace Microsoft.AspNetCore.Components.Routing
{
    /// <summary>
    /// Describes information determined during routing that specifies
    /// the query string parameters.
    /// </summary>
    public sealed class QueryParamData
    {
        /// <summary>
        /// Constructs an instance of <see cref="QueryParamData"/>.
        /// </summary>
        /// <param name="queryParameters">The collection of query string parameters.</param>
        public QueryParamData(Dictionary<string, string> queryParameters)
        {
            QueryParameters = queryParameters;
        }

        /// <summary>
        /// Gets all query parameters from the matched route
        /// </summary>
        public Dictionary<string, string> QueryParameters { get; }
    }
}
