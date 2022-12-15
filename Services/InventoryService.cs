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

        public void AddProduct(Product product)
        {
            product.Id = Guid.NewGuid();
            inventory.prods.Add(product);
        }

        public void DeleteProduct(string name)
        {
            var prodIndex = inventory.prods.FindIndex(x => x.Name == name);
            inventory.prods.RemoveAt(prodIndex);
        }

        public Product GetProduct(Guid id)
        {
            return inventory.prods.Single(x => x.Id == id);
        }
        public void ReplaceProduct(Product product)
        {
            var prodId = inventory.prods.FindIndex(x => x.Id == product.Id);
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
