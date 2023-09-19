using System.Runtime.Serialization;
using System;
namespace Qwips.Core.MultiCase.Models {
    public enum Imageflagsenum {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "ImageSizeBelowRecomendation")]
        ImageSizeBelowRecomendation,
        [EnumMember(Value = "ImageResolutionBelowRecomendation")]
        ImageResolutionBelowRecomendation,
    }
}
