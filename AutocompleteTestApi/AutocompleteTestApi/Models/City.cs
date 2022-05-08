using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AutocompleteTestApi.Models
{
    public class City
    {
        [Key]
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [StringLength(50)]
        [JsonPropertyName("Country")]
        public string Country { get; set; }
        [StringLength(50)]
        [JsonPropertyName("SubCountry")]
        public string SubCountry { get; set; }
        [JsonPropertyName("GeonameId")]
        public int GeonameId { get; set; }

    }
}
