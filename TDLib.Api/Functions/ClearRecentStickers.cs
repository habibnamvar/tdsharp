using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class ClearRecentStickers : Function<Ok>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "clearRecentStickers";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_attached")]
            public bool IsAttached { get; set; }
        }
    }
}