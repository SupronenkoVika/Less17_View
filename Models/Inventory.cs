using Less17_View.Models.Domain;
using System.Text.Json;

namespace Less17_View.Models
{
    public class Inventory
    {
        public List<Product> prods { get; set; } = new List<Product>();
        public Inventory(string json)
        {
            string jsonString = File.ReadAllText(json);
            prods = JsonSerializer.Deserialize<List<Product>>(jsonString);
        }
    }
}
