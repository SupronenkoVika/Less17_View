using Less17_View.Services;
using Microsoft.AspNetCore.Mvc;

namespace Less17_View.Controllers
{
    public class ProductsCostController : Controller
    {
        InventoryService Service;
        public ProductsCostController(InventoryService service)
        {
            Service = service;
        }
        [HttpGet]
        public IActionResult AllProductsCost()
        {
            return Ok(Service.AllProductCost());
        }
    }
}
