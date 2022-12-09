using Less17_View.Models;
using Less17_View.Models.Domain;

namespace Less17_View.Services
{
    public class InventoryService
    {
        Inventory inventory;
        public InventoryService(Inventory inventory)
        {
            this.inventory = inventory;
        }

        public void AddProduct(Product prod)
        {
            inventory.prods.Add(prod);
        }


        public List<Product> GetAllProduct()
        {
            return inventory.prods;
        }

        public void UpdateProduct(int prodID, Product prod)
        {
            inventory.prods[prodID] = prod;
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
