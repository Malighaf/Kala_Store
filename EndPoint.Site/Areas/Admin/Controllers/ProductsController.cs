using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bugeto_Store.Application.Interfaces.FacadPatterns;
using Bugeto_Store.Application.Services.Products.Commands.AddNewProduct;
using Bugeto_Store.Application.Services.Products.Commands.EditProduct;
using Bugeto_Store.Application.Services.Users.Commands.EditUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {

        private readonly IProductFacad _productFacad;

        public ProductsController(IProductFacad productFacad)
        {
            _productFacad = productFacad;
        }
        public IActionResult Index(string serchkey,int Page = 1, int PageSize = 20)
        {
            return View(_productFacad.GetProductForAdminService.Execute(serchkey ,Page, PageSize).Data);
        }

        public IActionResult Detail(long Id)
        {
            return View(_productFacad.GetProductDetailForAdminService.Execute(Id).Data);
        }

        [HttpGet]
        public IActionResult AddNewProduct()
        {
            ViewBag.Categories = new SelectList(_productFacad.GetAllCategoriesService.Execute().Data, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult AddNewProduct(RequestAddNewProductDto request, List<AddNewProduct_Features> Features)
        {
            List<IFormFile> images = new List<IFormFile>();
            for (int i = 0; i < Request.Form.Files.Count; i++)
            {
                var file = Request.Form.Files[i];
                images.Add(file);
            }
            request.Images = images;
            request.Features = Features;
            return Json(_productFacad.AddNewProductService.Execute(request));
        }

        [HttpPost]
        public IActionResult Delete(long Id)
        {
            return Json(_productFacad.RemoveProductService.Execute(Id));
        }

        [HttpPost]
        public IActionResult Edit(long UserId, string name, string brand)
        {
            return Json(_productFacad.EditProductService.Execute(new RequestProductDto
            {
                name = name,
                brand = brand,
                UserId = UserId,
            }));
        }

    }
}
