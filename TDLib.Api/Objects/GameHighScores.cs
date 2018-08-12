using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class GameHighScores : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "gameHighScores";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("scores")]
            public GameHighScore[] Scores { get; set; }
        }
    }
}