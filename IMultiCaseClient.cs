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

namespace Qwips.Core.ClientSdk.Multicase
{
    public interface IMultiCaseClient
    {
        AccountingRequestBuilder Accounting { get; }
        AuthRequestBuilder Auth { get; }
        B24RequestBuilder B24 { get; }
        ContactsRequestBuilder Contacts { get; }
        CustomerRequestBuilder Customer { get; }
        CustomersRequestBuilder Customers { get; }
        DiscountRequestBuilder Discount { get; }
        EHFRequestBuilder EHF { get; }
        GiftcardRequestBuilder Giftcard { get; }
        ImagesRequestBuilder Images { get; }
        LanguagesRequestBuilder Languages { get; }
        OrdersRequestBuilder Orders { get; }
        ProductRequestBuilder Product { get; }
        ProductsRequestBuilder Products { get; }
        PurchaseordersRequestBuilder Purchaseorders { get; }
        ReportRequestBuilder Report { get; }
        RequestRequestBuilder Request { get; }
        SendersRequestBuilder Senders { get; }
        SystemRequestBuilder System { get; }
        UsersRequestBuilder Users { get; }
        ValutatabellRequestBuilder Valutatabell { get; }
        WarehousesRequestBuilder Warehouses { get; }
    }
}