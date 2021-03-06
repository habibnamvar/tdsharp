using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class InputMessageContent : Object
        {
            public class InputMessageForwarded : InputMessageContent
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "inputMessageForwarded";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("from_chat_id")]
                public long FromChatId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_id")]
                public long MessageId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("in_game_share")]
                public bool InGameShare { get; set; }
            }
        }
    }
}