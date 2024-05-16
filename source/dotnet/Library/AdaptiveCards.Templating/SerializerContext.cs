using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace AdaptiveCards.Templating
{
    [JsonSerializable(typeof(JsonNode))]
    [JsonSerializable(typeof(JsonObject))]
    [JsonSerializable(typeof(string))]
    [JsonSerializable(typeof(bool))]
    [JsonSerializable(typeof(int))]
    [JsonSerializable(typeof(long))]
    [JsonSerializable(typeof(decimal))]
    [JsonSerializable(typeof(float))]
    [JsonSerializable(typeof(double))]
    [JsonSerializable(typeof(List<object>))]
    [JsonSerializable(typeof(List<JsonNode>))]
    [JsonSerializable(typeof(Dictionary<string, object>))]
    [JsonSerializable(typeof(Dictionary<string, JsonNode>))]
    [JsonSerializable(typeof(KeyValuePair<string, JsonNode>))]
    internal partial class SerializerContext : JsonSerializerContext
    {
    }
}
