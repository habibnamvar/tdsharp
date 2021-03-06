using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class EditMessageMedia : Function<Message>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "editMessageMedia";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("reply_markup")]
            public ReplyMarkup ReplyMarkup { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("input_message_content")]
            public InputMessageContent InputMessageContent { get; set; }
        }
    }
}