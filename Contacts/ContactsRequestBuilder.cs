using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.Contacts.Item;
using Qwips.Core.ClientSdk.Multicase.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Contacts {
    /// <summary>
    /// Builds and executes requests for operations under \contacts
    /// </summary>
    public class ContactsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Qwips.Core.ClientSdk.Multicase.contacts.item collection</summary>
        public ContactsItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("Id", position);
            return new ContactsItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ContactsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContactsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/contacts{?Id*,ChangedSince*,CustomerId*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ContactsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContactsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/contacts{?Id*,ChangedSince*,CustomerId*}", rawUrl) {
        }
        /// <summary>
        /// Retrieve list of contacts, all or changed
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Contactresponse?> GetAsync(Action<ContactsRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Contactresponse> GetAsync(Action<ContactsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<Contactresponse>(requestInfo, Contactresponse.CreateFromDiscriminatorValue, MulticaseErrorHandler.GenericErrorResponse, cancellationToken);
        }
        /// <summary>
        /// Retrieve list of contacts, all or changed
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ContactsRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ContactsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ContactsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Retrieve list of contacts, all or changed
        /// </summary>
        public class ContactsRequestBuilderGetQueryParameters {
            /// <summary>Last retrieval timestamp, converted to long</summary>
            [QueryParameter("ChangedSince")]
			public long? ChangedSince { get; set; }
            /// <summary>Customer Id to get its contacts</summary>
            [QueryParameter("CustomerId")]
			public int? CustomerId { get; set; }
            /// <summary>Contact Id to get one contact</summary>
            [QueryParameter("Id")]
			public int? Id { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ContactsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ContactsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ContactsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new contactsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ContactsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
