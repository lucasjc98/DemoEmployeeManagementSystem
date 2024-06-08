using System.Text.Json.Serialization;

namespace DEMS.BaseLibrary.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        // Relationship : One to Many (1-N)
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }
    }
}
