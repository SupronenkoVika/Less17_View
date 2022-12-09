using Less17_View.Models.Domain;
using Less17_View.Services;
using Microsoft.AspNetCore.Mvc;

namespace Less17_View.Controllers
{
    [Controller]
    //[Route("[controller]/[action]")]
    public class ProductController : Controller
    {
        InventoryService Service;
        public ProductController(InventoryService service)
        {
            Service = service;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            List<Product> list = Service.GetAllProduct();
            return View(list);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            Service.AddProduct(product);
            return View();
        }

        [HttpPut]
        public IActionResult UpdateProduct(int prodId, Product product)
        {
            Service.UpdateProduct(prodId, product);
            return Created($"Replase {product.Name}", product);
        }
    }
}
