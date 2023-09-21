using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;

namespace Qwips.Core.ClientSdk.Multicase
{
    public static class MulticaseErrorHandler
    {
        public static Dictionary<string, ParsableFactory<IParsable>> GenericErrorResponse = new Dictionary<string, ParsableFactory<IParsable>> {
                { "4XX", Multicase4XXJsonErrorResponse.CreateFromDiscriminatorValue }
            };
    }
}
