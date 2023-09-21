using System.Runtime.Serialization;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public enum Imageflagsenum {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "ImageSizeBelowRecomendation")]
        ImageSizeBelowRecomendation,
        [EnumMember(Value = "ImageResolutionBelowRecomendation")]
        ImageResolutionBelowRecomendation,
    }
}
