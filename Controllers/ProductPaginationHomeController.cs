using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductManagementWebApi.Models;
using System.Linq;

namespace ProductManagementWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductPaginationHomeController : ControllerBase
    {
        [HttpGet("page/{page}")]
        public ProductPaginationModel Get(int page = 1)
        {
            var model = new ProductPaginationModel();

            var productCount = 7;
            var productSkıp = (page - 1) * productCount;

            model.CurrentPage = page;
            model.PageCount = (int)Math.Ceiling(ProductController._products.Count / 7.0);
            model.TotalProductCount = ProductController._products.Count;
            model.Products = ProductController._products.Skip(productSkıp).Take(productCount).ToList();
            return model;
        }

        [HttpGet("search/{search}/{page}")]
        public ProductPaginationModel Get(string search, int page)
        {
            var products = ProductController._products.Where(x => x.Name.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();

            var model = new ProductPaginationModel();

            var productCount = 7;
            var productSkıp = (page - 1) * productCount;

            model.Products = products.Skip(productSkıp).Take(productCount).ToList(); ;
            model.CurrentPage = page;
            model.PageCount = (int)Math.Ceiling(products.Count / 7.0);
            model.TotalProductCount = products.Count;
            return model;
        }
    }
}
