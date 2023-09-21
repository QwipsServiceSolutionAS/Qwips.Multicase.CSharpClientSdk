using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.Report.Multicasereport;
using Qwips.Core.ClientSdk.Multicase.Report.Pdf;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Report {
    /// <summary>
    /// Builds and executes requests for operations under \report
    /// </summary>
    public class ReportRequestBuilder : BaseRequestBuilder {
        /// <summary>The multicasereport property</summary>
        public MulticasereportRequestBuilder Multicasereport { get =>
            new MulticasereportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pdf property</summary>
        public PdfRequestBuilder Pdf { get =>
            new PdfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ReportRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/report", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ReportRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/report", rawUrl) {
        }
    }
}
