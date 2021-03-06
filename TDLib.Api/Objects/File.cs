using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class File : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "file";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("size")]
            public int Size { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("expected_size")]
            public int ExpectedSize { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("local")]
            public LocalFile Local { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("remote")]
            public RemoteFile Remote { get; set; }
        }
    }
}