using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class Destroy : Function<Ok>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "destroy";

            [JsonProperty("@extra")] public override string Extra { get; set; }
        }
    }
}