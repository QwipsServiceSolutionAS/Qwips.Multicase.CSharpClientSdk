using Qwips.Core.MultiCase.Accounting;
using Qwips.Core.MultiCase.Auth;
using Qwips.Core.MultiCase.B24;
using Qwips.Core.MultiCase.Contacts;
using Qwips.Core.MultiCase.Customer;
using Qwips.Core.MultiCase.Customers;
using Qwips.Core.MultiCase.Discount;
using Qwips.Core.MultiCase.EHF;
using Qwips.Core.MultiCase.Giftcard;
using Qwips.Core.MultiCase.Images;
using Qwips.Core.MultiCase.Languages;
using Qwips.Core.MultiCase.Orders;
using Qwips.Core.MultiCase.Product;
using Qwips.Core.MultiCase.Products;
using Qwips.Core.MultiCase.Purchaseorders;
using Qwips.Core.MultiCase.Report;
using Qwips.Core.MultiCase.Request;
using Qwips.Core.MultiCase.Senders;
using Qwips.Core.MultiCase.MSystem;
using Qwips.Core.MultiCase.Users;
using Qwips.Core.MultiCase.Valutatabell;
using Qwips.Core.MultiCase.Warehouses;

namespace Qwips.Core.MultiCase
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