using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagementWebApi.Models;

namespace ProductManagementWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static int staticId = 60;
        public static List<Product> _products = new List<Product>()
        {
             new Product() { Id = 1, Name = "Asus PC", Price=1800, Stock=1, CategoryId=1, IsStatus = true },
             new Product() { Id = 2, Name = "MSI PC", Price=3000, Stock=7, CategoryId=1, IsStatus = true },
             new Product() { Id = 3, Name = "LG TV", Price=700, Stock=5, CategoryId=4, IsStatus = true },
             new Product() { Id = 4, Name = "Samsung TV", Price=900, Stock=6, CategoryId=4, IsStatus = true },
             new Product() { Id = 5, Name = "Apple Tablet", Price=500, Stock=8, CategoryId=3, IsStatus = true },
             new Product() { Id = 6, Name = "Samsung Tablet", Price=400, Stock=5, CategoryId=3, IsStatus = true },
             new Product() { Id = 7, Name = "Apple İphone", Price=300, Stock=10, CategoryId=2, IsStatus = true },
             new Product() { Id = 8, Name = "Samsung Galaxy", Price=1000, Stock=4, CategoryId=2, IsStatus = true },
             new Product() { Id = 9, Name = "Monster Laptop", Price=500, Stock=20, CategoryId=1, IsStatus = true },
             new Product() { Id = 10, Name = "Mi Telefon", Price=2000, Stock=5, CategoryId=2, IsStatus = true },
             new Product() { Id = 11, Name = "Dell Laptop", Price = 1200, Stock = 15, CategoryId = 1, IsStatus = true },
             new Product() { Id = 12, Name = "HP Printer", Price = 300, Stock = 12, CategoryId = 5, IsStatus = true },
             new Product() { Id = 13, Name = "Canon Camera", Price = 800, Stock = 8, CategoryId = 6, IsStatus = true },
             new Product() { Id = 14, Name = "Sony Headphones", Price = 150, Stock = 25, CategoryId = 7, IsStatus = true },
             new Product() { Id = 15, Name = "Bose Speakers", Price = 250, Stock = 10, CategoryId = 7, IsStatus = true },
             new Product() { Id = 16, Name = "LG Refrigerator", Price = 1200, Stock = 5, CategoryId = 8, IsStatus = true },
             new Product() { Id = 17, Name = "Whirlpool Washing Machine", Price = 600, Stock = 18, CategoryId = 9, IsStatus = true },
             new Product() { Id = 18, Name = "Lenovo Tablet", Price = 350, Stock = 12, CategoryId = 3, IsStatus = true },
             new Product() { Id = 19, Name = "Acer Monitor", Price = 400, Stock = 20, CategoryId = 10, IsStatus = true },
             new Product() { Id = 20, Name = "Microsoft Surface", Price = 900, Stock = 8, CategoryId = 1, IsStatus = true },
             new Product() { Id = 21, Name = "Epson Projector", Price = 500, Stock = 7, CategoryId = 13, IsStatus = true },
             new Product() { Id = 22, Name = "LG Smartwatch", Price = 180, Stock = 15, CategoryId = 14, IsStatus = true },
             new Product() { Id = 23, Name = "GoPro Action Camera", Price = 350, Stock = 10, CategoryId = 6, IsStatus = true },
             new Product() { Id = 24, Name = "Corsair Gaming Mouse", Price = 60, Stock = 25, CategoryId = 15, IsStatus = true },
             new Product() { Id = 25, Name = "Razer Gaming Laptop", Price = 1500, Stock = 8, CategoryId = 1, IsStatus = true },
             new Product() { Id = 26, Name = "JBL Bluetooth Speaker", Price = 120, Stock = 20, CategoryId = 7, IsStatus = true },
             new Product() { Id = 27, Name = "Panasonic Smart TV", Price = 800, Stock = 12, CategoryId = 4, IsStatus = true },
             new Product() { Id = 28, Name = "Xiaomi Robot Vacuum", Price = 250, Stock = 15, CategoryId = 16, IsStatus = true },
             new Product() { Id = 29, Name = "Fujifilm Mirrorless Camera", Price = 1000, Stock = 5, CategoryId = 6, IsStatus = true },
             new Product() { Id = 30, Name = "SteelSeries Gaming Headset", Price = 100, Stock = 30, CategoryId = 17, IsStatus = true },
             new Product() { Id = 31, Name = "Sony PlayStation 5", Price = 500, Stock = 3, CategoryId = 18, IsStatus = true },
             new Product() { Id = 32, Name = "Bose Noise-Canceling Headphones", Price = 300, Stock = 10, CategoryId = 7, IsStatus = true },
             new Product() { Id = 33, Name = "LG Ultrawide Monitor", Price = 700, Stock = 5, CategoryId = 10, IsStatus = true },
             new Product() { Id = 34, Name = "Microsoft Xbox Series X", Price = 450, Stock = 8, CategoryId = 18, IsStatus = true },
             new Product() { Id = 35, Name = "Canon DSLR Camera", Price = 1200, Stock = 6, CategoryId = 6, IsStatus = true },
             new Product() { Id = 36, Name = "Anker Portable Charger", Price = 40, Stock = 15, CategoryId = 19, IsStatus = true },
             new Product() { Id = 37, Name = "Dyson Vacuum Cleaner", Price = 300, Stock = 12, CategoryId = 16, IsStatus = true },
             new Product() { Id = 38, Name = "AOC Gaming Monitor", Price = 250, Stock = 20, CategoryId = 10, IsStatus = true },
             new Product() { Id = 39, Name = "Apple MacBook Pro", Price = 1500, Stock = 8, CategoryId = 1, IsStatus = true },
             new Product() { Id = 40, Name = "Samsung Soundbar", Price = 200, Stock = 30, CategoryId = 7, IsStatus = true },
             new Product() { Id = 42, Name = "Corsair Mechanical Keyboard", Price = 120, Stock = 18, CategoryId = 12, IsStatus = true },
             new Product() { Id = 43, Name = "Google Nest Thermostat", Price = 200, Stock = 10, CategoryId = 21, IsStatus = true },
             new Product() { Id = 44, Name = "LG Bluetooth Earbuds", Price = 80, Stock = 20, CategoryId = 7, IsStatus = true },
             new Product() { Id = 45, Name = "Nintendo Switch", Price = 300, Stock = 5, CategoryId = 18, IsStatus = true },
             new Product() { Id = 46, Name = "Samsung SSD", Price = 100, Stock = 15, CategoryId = 22, IsStatus = true },
             new Product() { Id = 47, Name = "Garmin Fitness Tracker", Price = 150, Stock = 12, CategoryId = 23, IsStatus = true },
             new Product() { Id = 48, Name = "Breville Coffee Maker", Price = 120, Stock = 8, CategoryId = 24, IsStatus = true },
             new Product() { Id = 49, Name = "Logitech Gaming Mouse", Price = 60, Stock = 30, CategoryId = 15, IsStatus = true },
             new Product() { Id = 50, Name = "DJI Mavic Air Drone", Price = 800, Stock = 6, CategoryId = 25, IsStatus = true },
             new Product() { Id = 51, Name = "Huawei Smartwatch", Price = 150, Stock = 15, CategoryId = 14, IsStatus = true },
             new Product() { Id = 52, Name = "Vizio 4K TV", Price = 600, Stock = 10, CategoryId = 4, IsStatus = true },
             new Product() { Id = 53, Name = "Fitbit Fitness Tracker", Price = 80, Stock = 20, CategoryId = 23, IsStatus = true },
             new Product() { Id = 54, Name = "HP Gaming Laptop", Price = 1200, Stock = 8, CategoryId = 1, IsStatus = true },
             new Product() { Id = 55, Name = "Xbox Elite Controller", Price = 150, Stock = 12, CategoryId = 15, IsStatus = true },
             new Product() { Id = 56, Name = "Apple AirPods Pro", Price = 250, Stock = 10, CategoryId = 7, IsStatus = true },
             new Product() { Id = 57, Name = "Acer Chromebook", Price = 300, Stock = 15, CategoryId = 1, IsStatus = true },
             new Product() { Id = 58, Name = "Sony 65-inch OLED TV", Price = 2000, Stock = 5, CategoryId = 4, IsStatus = true },
             new Product() { Id = 59, Name = "LG Microwave", Price = 150, Stock = 15, CategoryId = 11, IsStatus = true },
             new Product() { Id = 60, Name = "Logitech Keyboard", Price = 80, Stock = 30, CategoryId = 12, IsStatus = true }
        };
        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return _products.Where(x => x.IsStatus == true).ToList();
        }

        //id parametresini aldığını söylüyoruz
        [HttpGet("{id}")]
        public Product GetById(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            return product;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                _products.Remove(product);
                return StatusCode(200); //Başarılı
            }
            else
            {
                return StatusCode(404); //Bulunamadı
            }
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            staticId++;
            if (!String.IsNullOrEmpty(product.Name))
            {
                product.Id = staticId;
                _products.Add(product);
                return Ok("Ekleme Başarılı");
            }
            else
            {
                return Ok("Category Name Boş olamaz");
            }
        }


        [HttpPut]
        public IActionResult Put(Product product)
        {
            var findProduct = _products.FirstOrDefault(x => x.Id == product.Id);
            if (findProduct != null)
            {
                findProduct.Id = product.Id;
                findProduct.Name = product.Name;
                findProduct.Price = product.Price;
                findProduct.Stock = product.Stock;
                findProduct.CategoryId = product.CategoryId;
                findProduct.IsStatus = product.IsStatus;
                return Ok("Düzenleme Başarılı.");
            }
            else
            {
                return Ok("Düzenleme Başarısız.");
            }
        }
    }
}
