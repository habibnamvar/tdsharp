using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class AccountTtl : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "accountTtl";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("days")]
            public int Days { get; set; }
        }
    }
}