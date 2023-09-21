using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;

namespace Qwips.Core.ClientSdk.Multicase
{
    public class MulticaseResponseStatus : IParsable
    {
        public string Message { get; set; }
        public string ErrorCode { get; set; }
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>> {
                {"Message", n => { Message = n.GetStringValue(); } },
                {"ErrorCode", n => { ErrorCode = n.GetStringValue(); } },
            };
        }

        public static MulticaseResponseStatus CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MulticaseResponseStatus();
        }
        public void Serialize(ISerializationWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
