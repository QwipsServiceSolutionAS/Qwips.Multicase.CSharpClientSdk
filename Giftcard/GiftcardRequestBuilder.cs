using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.Giftcard.ActivateGiftcard;
using Qwips.Core.ClientSdk.Multicase.Giftcard.CancelGiftcard;
using Qwips.Core.ClientSdk.Multicase.Giftcard.CancelGiftcardTransaction;
using Qwips.Core.ClientSdk.Multicase.Giftcard.ChangeGiftcardBalance;
using Qwips.Core.ClientSdk.Multicase.Giftcard.Create;
using Qwips.Core.ClientSdk.Multicase.Giftcard.CreateTransaction;
using Qwips.Core.ClientSdk.Multicase.Giftcard.CreateTransactionDetail;
using Qwips.Core.ClientSdk.Multicase.Giftcard.GetBarcode;
using Qwips.Core.ClientSdk.Multicase.Giftcard.GetGiftcard;
using Qwips.Core.ClientSdk.Multicase.Giftcard.GetGiftcardTransaction;
using Qwips.Core.ClientSdk.Multicase.Giftcard.GetGiftcardTransactionDetail;
using Qwips.Core.ClientSdk.Multicase.Giftcard.GetGiftcardTransactionList;
using Qwips.Core.ClientSdk.Multicase.Giftcard.GetGiftcardTransactionListByCartID;
using Qwips.Core.ClientSdk.Multicase.Giftcard.GetGiftcardTransactionListByOrderID;
using Qwips.Core.ClientSdk.Multicase.Giftcard.GetSender;
using Qwips.Core.ClientSdk.Multicase.Giftcard.IsGiftcardValidForSender;
using Qwips.Core.ClientSdk.Multicase.Giftcard.IsSmsEnabled;
using Qwips.Core.ClientSdk.Multicase.Giftcard.SendGiftcardEmail;
using Qwips.Core.ClientSdk.Multicase.Giftcard.SendGiftcardReceiptEmail;
using Qwips.Core.ClientSdk.Multicase.Giftcard.SendGiftcardReceiptSMS;
using Qwips.Core.ClientSdk.Multicase.Giftcard.SendGiftcardSMS;
using Qwips.Core.ClientSdk.Multicase.Giftcard.SetGiftcardBackgroundImageID;
using Qwips.Core.ClientSdk.Multicase.Giftcard.SetGiftcardTransactionBelop;
using Qwips.Core.ClientSdk.Multicase.Giftcard.SetGiftcardTransactionOrdreHodeID;
using Qwips.Core.ClientSdk.Multicase.Giftcard.SetGiftcardTransactionStatus;
using Qwips.Core.ClientSdk.Multicase.Giftcard.SetGiftcardTransactionWeb30BBSTransID;
using Qwips.Core.ClientSdk.Multicase.Giftcard.UpdateGiftcard;
using Qwips.Core.ClientSdk.Multicase.Giftcard.UpdateGiftcardCustInfo;
using Qwips.Core.ClientSdk.Multicase.Giftcard.UpdateTransaction;
using Qwips.Core.ClientSdk.Multicase.Giftcard.UpdateTransactionDetail;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Giftcard {
    /// <summary>
    /// Builds and executes requests for operations under \Giftcard
    /// </summary>
    public class GiftcardRequestBuilder : BaseRequestBuilder {
        /// <summary>The ActivateGiftcard property</summary>
        public ActivateGiftcardRequestBuilder ActivateGiftcard { get =>
            new ActivateGiftcardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CancelGiftcard property</summary>
        public CancelGiftcardRequestBuilder CancelGiftcard { get =>
            new CancelGiftcardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CancelGiftcardTransaction property</summary>
        public CancelGiftcardTransactionRequestBuilder CancelGiftcardTransaction { get =>
            new CancelGiftcardTransactionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ChangeGiftcardBalance property</summary>
        public ChangeGiftcardBalanceRequestBuilder ChangeGiftcardBalance { get =>
            new ChangeGiftcardBalanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Create property</summary>
        public CreateRequestBuilder Create { get =>
            new CreateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CreateTransaction property</summary>
        public CreateTransactionRequestBuilder CreateTransaction { get =>
            new CreateTransactionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CreateTransactionDetail property</summary>
        public CreateTransactionDetailRequestBuilder CreateTransactionDetail { get =>
            new CreateTransactionDetailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The GetBarcode property</summary>
        public GetBarcodeRequestBuilder GetBarcode { get =>
            new GetBarcodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The GetGiftcard property</summary>
        public GetGiftcardRequestBuilder GetGiftcard { get =>
            new GetGiftcardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The GetGiftcardTransaction property</summary>
        public GetGiftcardTransactionRequestBuilder GetGiftcardTransaction { get =>
            new GetGiftcardTransactionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The GetGiftcardTransactionDetail property</summary>
        public GetGiftcardTransactionDetailRequestBuilder GetGiftcardTransactionDetail { get =>
            new GetGiftcardTransactionDetailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The GetGiftcardTransactionList property</summary>
        public GetGiftcardTransactionListRequestBuilder GetGiftcardTransactionList { get =>
            new GetGiftcardTransactionListRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The GetGiftcardTransactionListByCartID property</summary>
        public GetGiftcardTransactionListByCartIDRequestBuilder GetGiftcardTransactionListByCartID { get =>
            new GetGiftcardTransactionListByCartIDRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The GetGiftcardTransactionListByOrderID property</summary>
        public GetGiftcardTransactionListByOrderIDRequestBuilder GetGiftcardTransactionListByOrderID { get =>
            new GetGiftcardTransactionListByOrderIDRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The GetSender property</summary>
        public GetSenderRequestBuilder GetSender { get =>
            new GetSenderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The IsGiftcardValidForSender property</summary>
        public IsGiftcardValidForSenderRequestBuilder IsGiftcardValidForSender { get =>
            new IsGiftcardValidForSenderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The IsSmsEnabled property</summary>
        public IsSmsEnabledRequestBuilder IsSmsEnabled { get =>
            new IsSmsEnabledRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SendGiftcardEmail property</summary>
        public SendGiftcardEmailRequestBuilder SendGiftcardEmail { get =>
            new SendGiftcardEmailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SendGiftcardReceiptEmail property</summary>
        public SendGiftcardReceiptEmailRequestBuilder SendGiftcardReceiptEmail { get =>
            new SendGiftcardReceiptEmailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SendGiftcardReceiptSMS property</summary>
        public SendGiftcardReceiptSMSRequestBuilder SendGiftcardReceiptSMS { get =>
            new SendGiftcardReceiptSMSRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SendGiftcardSMS property</summary>
        public SendGiftcardSMSRequestBuilder SendGiftcardSMS { get =>
            new SendGiftcardSMSRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SetGiftcardBackgroundImageID property</summary>
        public SetGiftcardBackgroundImageIDRequestBuilder SetGiftcardBackgroundImageID { get =>
            new SetGiftcardBackgroundImageIDRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SetGiftcardTransactionBelop property</summary>
        public SetGiftcardTransactionBelopRequestBuilder SetGiftcardTransactionBelop { get =>
            new SetGiftcardTransactionBelopRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SetGiftcardTransactionOrdreHodeID property</summary>
        public SetGiftcardTransactionOrdreHodeIDRequestBuilder SetGiftcardTransactionOrdreHodeID { get =>
            new SetGiftcardTransactionOrdreHodeIDRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SetGiftcardTransactionStatus property</summary>
        public SetGiftcardTransactionStatusRequestBuilder SetGiftcardTransactionStatus { get =>
            new SetGiftcardTransactionStatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SetGiftcardTransactionWeb30BBSTransID property</summary>
        public SetGiftcardTransactionWeb30BBSTransIDRequestBuilder SetGiftcardTransactionWeb30BBSTransID { get =>
            new SetGiftcardTransactionWeb30BBSTransIDRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The UpdateGiftcard property</summary>
        public UpdateGiftcardRequestBuilder UpdateGiftcard { get =>
            new UpdateGiftcardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The UpdateGiftcardCustInfo property</summary>
        public UpdateGiftcardCustInfoRequestBuilder UpdateGiftcardCustInfo { get =>
            new UpdateGiftcardCustInfoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The UpdateTransaction property</summary>
        public UpdateTransactionRequestBuilder UpdateTransaction { get =>
            new UpdateTransactionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The UpdateTransactionDetail property</summary>
        public UpdateTransactionDetailRequestBuilder UpdateTransactionDetail { get =>
            new UpdateTransactionDetailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new GiftcardRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GiftcardRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Giftcard", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new GiftcardRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GiftcardRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Giftcard", rawUrl) {
        }
    }
}
