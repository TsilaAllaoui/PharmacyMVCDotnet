using System.Text.Json.Serialization;

namespace PharmacyMVC.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MedicineType
    {
        Liquid,
        Tablet,
        Capsule,
        Suppositorie,
        Drop,
        Inhaler,
        Injection
    }
}
