using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class InputPassportElement : Object
        {
            public class InputPassportElementInternalPassport : InputPassportElement
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputPassportElementInternalPassport";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("internal_passport")]
                public InputIdentityDocument InternalPassport { get; set; }
            }
        }
    }
}