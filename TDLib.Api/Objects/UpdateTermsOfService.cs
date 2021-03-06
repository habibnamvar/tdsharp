using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class Update : Object
        {
            public class UpdateTermsOfService : Update
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "updateTermsOfService";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("terms_of_service_id")]
                public string TermsOfServiceId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("terms_of_service")]
                public TermsOfService TermsOfService { get; set; }
            }
        }
    }
}