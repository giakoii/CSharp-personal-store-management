using System.Text.Json.Serialization;

namespace BussinessObject.Models;

public enum Status
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    ENABLED, DISABLED
}