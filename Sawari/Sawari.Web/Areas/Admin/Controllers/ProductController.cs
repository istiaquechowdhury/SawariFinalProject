using Sawari.Web.Areas.Admin.Models;
using Sawari.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

using Sawari.Application.Services;

namespace DevSkill.Inventory.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductManagementServices _productManagementServices;

        public ProductController(IProductManagementServices productManagementServices)
        {
            _productManagementServices = productManagementServices; 
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(ProductModel productModel)
        {
            if (ModelState.IsValid)
            {
                var product = new Product
                {
                    Id = Guid.NewGuid(),
                    Title = productModel.Title
                };

                _productManagementServices.CreateProduct(product);
                return RedirectToAction("Index");
            }
            return View(productModel);

        }

    }
}
