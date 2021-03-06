using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class SendBotStartMessage : Function<Message>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "sendBotStartMessage";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("bot_user_id")]
            public int BotUserId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("parameter")]
            public string Parameter { get; set; }
        }
    }
}