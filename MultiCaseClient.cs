using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Text;
using Qwips.Core.ClientSdk.Multicase.Accounting;
using Qwips.Core.ClientSdk.Multicase.Auth;
using Qwips.Core.ClientSdk.Multicase.B24;
using Qwips.Core.ClientSdk.Multicase.Contacts;
using Qwips.Core.ClientSdk.Multicase.Customer;
using Qwips.Core.ClientSdk.Multicase.Customers;
using Qwips.Core.ClientSdk.Multicase.Discount;
using Qwips.Core.ClientSdk.Multicase.EHF;
using Qwips.Core.ClientSdk.Multicase.Giftcard;
using Qwips.Core.ClientSdk.Multicase.Images;
using Qwips.Core.ClientSdk.Multicase.Languages;
using Qwips.Core.ClientSdk.Multicase.Orders;
using Qwips.Core.ClientSdk.Multicase.Product;
using Qwips.Core.ClientSdk.Multicase.Products;
using Qwips.Core.ClientSdk.Multicase.Purchaseorders;
using Qwips.Core.ClientSdk.Multicase.Report;
using Qwips.Core.ClientSdk.Multicase.Request;
using Qwips.Core.ClientSdk.Multicase.Senders;
using Qwips.Core.ClientSdk.Multicase.MSystem;
using Qwips.Core.ClientSdk.Multicase.Users;
using Qwips.Core.ClientSdk.Multicase.Valutatabell;
using Qwips.Core.ClientSdk.Multicase.Warehouses;
using System.Collections.Generic;
using Rijndael256;
using SmartService.Core.Utility;
using Microsoft.Extensions.Configuration;

namespace Qwips.Core.ClientSdk.Multicase
{
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    public class MultiCaseClient : BaseRequestBuilder, IMultiCaseClient
    {
        private MultiCaseConfiguration _options;
        private new IRequestAdapter RequestAdapter { get; set; }

        /// <summary>The accounting property</summary>
        public AccountingRequestBuilder Accounting
        {
            get =>
            new AccountingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The auth property</summary>
        public AuthRequestBuilder Auth
        {
            get =>
            new AuthRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The B24 property</summary>
        public B24RequestBuilder B24
        {
            get =>
            new B24RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The contacts property</summary>
        public ContactsRequestBuilder Contacts
        {
            get =>
            new ContactsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The customer property</summary>
        public CustomerRequestBuilder Customer
        {
            get =>
            new CustomerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The customers property</summary>
        public CustomersRequestBuilder Customers
        {
            get =>
            new CustomersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The discount property</summary>
        public DiscountRequestBuilder Discount
        {
            get =>
            new DiscountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The EHF property</summary>
        public EHFRequestBuilder EHF
        {
            get =>
            new EHFRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Giftcard property</summary>
        public GiftcardRequestBuilder Giftcard
        {
            get =>
            new GiftcardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The images property</summary>
        public ImagesRequestBuilder Images
        {
            get =>
            new ImagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The languages property</summary>
        public LanguagesRequestBuilder Languages
        {
            get =>
            new LanguagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The orders property</summary>
        public OrdersRequestBuilder Orders
        {
            get =>
            new OrdersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The product property</summary>
        public ProductRequestBuilder Product
        {
            get =>
            new ProductRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The products property</summary>
        public ProductsRequestBuilder Products
        {
            get =>
            new ProductsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The purchaseorders property</summary>
        public PurchaseordersRequestBuilder Purchaseorders
        {
            get =>
            new PurchaseordersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The report property</summary>
        public ReportRequestBuilder Report
        {
            get =>
            new ReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request property</summary>
        public RequestRequestBuilder Request
        {
            get =>
            new RequestRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The senders property</summary>
        public SendersRequestBuilder Senders
        {
            get =>
            new SendersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The system property</summary>
        public SystemRequestBuilder System
        {
            get =>
            new SystemRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The users property</summary>
        public UsersRequestBuilder Users
        {
            get =>
            new UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The valutatabell property</summary>
        public ValutatabellRequestBuilder Valutatabell
        {
            get =>
            new ValutatabellRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The warehouses property</summary>
        public WarehousesRequestBuilder Warehouses
        {
            get =>
            new WarehousesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new MultiCaseClient and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MultiCaseClient(IRequestAdapter requestAdapter, IConfiguration settings) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>())
        {
            var section = settings.GetSection("AppSettings").GetSection("MultiCase");
            var options = section.Get<MultiCaseConfiguration>();
            this._options = options;
            this.RequestAdapter = requestAdapter;
            ApiClientBuilder.RegisterDefaultSerializer<CustomJsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl))
            {
                RequestAdapter.BaseUrl = options.Server;
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
        }
    }
}


