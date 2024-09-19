using System.Text.Json.Serialization;

namespace BussinessObject.Models;

public enum Role
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    ADMIN, CUSTOMER
}