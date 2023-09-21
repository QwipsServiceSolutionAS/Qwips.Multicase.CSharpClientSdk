using Microsoft.Kiota.Abstractions.Serialization;
using Qwips.Core.ClientSdk.Multicase.Models;
using System;
using System.Collections.Generic;
namespace Qwips.Core.ClientSdk.Multicase
{
    public class Multicase4XXJsonErrorResponse : Exception, IParsable
    {
        public string Content { get; set; }
        public override string Message => responseStatus?.Message ?? "No error message available";
        public MulticaseResponseStatus responseStatus { get; set; }

        public static Multicase4XXJsonErrorResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Multicase4XXJsonErrorResponse();
        }
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>> {
                {"ResponseStatus", n => { responseStatus = n.GetObjectValue<MulticaseResponseStatus>(MulticaseResponseStatus.CreateFromDiscriminatorValue); } },
            };
        }

        public void Serialize(ISerializationWriter writer)
        {
            throw new NotImplementedException();
        }


    }
}
