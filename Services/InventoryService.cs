using Less17_View.Models;
using Less17_View.Models.Domain;

namespace Less17_View.Services
{
    public class InventoryService : IInventoryService
    {
        Inventory inventory;
        public InventoryService(Inventory inventory)
        {
            this.inventory = inventory;
        }
        public List<Product> GetAllProduct()
        {
            return inventory.prods;
        }

        public void AddProduct(Product prod)
        {
            inventory.prods.Add(prod);
        }

        public void DeleteProduct(string name)
        {
            var prodIndex = inventory.prods.FindIndex(x => x.Name == name);
            inventory.prods.RemoveAt(prodIndex);
        }

        public Product GetProduct(string name)
        {
            return inventory.prods.Single(x => x.Name == name);
        }
        public void ReplaceProduct(Product product)
        {
            var prodId = inventory.prods.FindIndex(x => x.Name == product.Name);
            inventory.prods[prodId] = product;
        }

        public decimal AllProductCost()
        {
            decimal result = 0;
            foreach (Product prod in inventory.prods)
            {
                result += prod.Price;
            }
            return result;
        }
    }
}
