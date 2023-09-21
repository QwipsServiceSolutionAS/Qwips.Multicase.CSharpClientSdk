using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.Accounting.Creditnote.Item;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Accounting.Creditnote {
    /// <summary>
    /// Builds and executes requests for operations under \accounting\creditnote
    /// </summary>
    public class CreditnoteRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Qwips.Core.ClientSdk.Multicase.accounting.creditnote.item collection</summary>
        public WithCreditNoteNumberItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("CreditNoteNumber", position);
            return new WithCreditNoteNumberItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new CreditnoteRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CreditnoteRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounting/creditnote", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CreditnoteRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CreditnoteRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounting/creditnote", rawUrl) {
        }
    }
}
