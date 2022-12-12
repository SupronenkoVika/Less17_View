using Less17_View.Models.Domain;
using Less17_View.Services;
using Microsoft.AspNetCore.Mvc;

namespace Less17_View.Controllers
{
    [Controller]
    [Route("[controller]/[action]")]
    public class ProductController : Controller
    {
        IInventoryService Service;
        public ProductController(IInventoryService service)
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

        public IActionResult Delete(string id)
        {
            Service.DeleteProduct(id);
            return RedirectToAction("GetProducts");
        }

        public IActionResult Edit(string id)
        {
            var product = Service.GetProduct(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product prod)
        {
            Service.ReplaceProduct(prod);
            return RedirectToAction("GetProducts");
        }

        [HttpGet]
        public IActionResult ProductsCost()
        {
            var price = Service.AllProductCost();
            return View(price);
        }
    }
}
