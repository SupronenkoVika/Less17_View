using Less17_View.Models.Domain;

namespace Less17_View.Services
{
    public interface IInventoryService
    {
        public List<Product> GetAllProduct();
        public void AddProduct(Product prod);
        public void DeleteProduct(string name);
        public Product GetProduct(string name);
        public void ReplaceProduct(Product product);
        public decimal AllProductCost();


    }
}
