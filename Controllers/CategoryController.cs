using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagementWebApi.Models;

namespace ProductManagementWebApi.Controllers
{
    [Route("api/[controller]")]


    //dışarıya json olarak açan apicontroller
    [ApiController]

    //kalıtım olarak get post gibi işlemleri alır.
    public class CategoryController : ControllerBase
    {
        static int staticId = 4;
        private static List<Category> _categories = new List<Category>()
        {
             new Category() { Id = 1, Name = "Bilgisayar", IsStatus = true },
             new Category() { Id = 2, Name = "Telefon", IsStatus = true },
             new Category() { Id = 3, Name = "Tablet", IsStatus = true },
             new Category() { Id = 4, Name = "TV", IsStatus = true },
        };
        [HttpGet]
        public IEnumerable<Category> GetAll()
        {
            return _categories.Where(x => x.IsStatus == true).ToList();
        }

        //id parametresini aldığını söylüyoruz
        [HttpGet("{id}")]
        public Category GetById(int id)
        {
            var category = _categories.FirstOrDefault(x => x.Id == id);
            return category;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var category = _categories.FirstOrDefault(x => x.Id == id);
            if (category != null)
            {
                _categories.Remove(category);
                return StatusCode(200); //Başarılı
            }
            else
            {
                return StatusCode(404); //Bulunamadı
            }
        }

        [HttpPost]
        public IActionResult Post(Category category)
        {
            staticId++;
            if (!String.IsNullOrEmpty(category.Name))
            {
                category.Id = staticId;
                _categories.Add(category);
                return Ok("Ekleme Başarılı");
            }
            else
            {
                return Ok("Category Name Boş olamaz");
            }
        }


        [HttpPut]
        public IActionResult Put(Category category)
        {
            var findCategory = _categories.FirstOrDefault(x => x.Id == category.Id);
            if (findCategory != null)
            {
                findCategory.Name = category.Name;
                findCategory.IsStatus = true;
                return Ok("Düzenleme Başarılı.");
            }
            else
            {
                return Ok("Düzenleme Başarısız.");
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Category category)
        {
            var findCategory = _categories.FirstOrDefault(x => x.Id == id);
            if (findCategory != null)
            {
                findCategory.Name = category.Name;
                findCategory.IsStatus = true;
                return Ok("Düzenleme Başarılı.");
            }
            else
            {
                return Ok("Düzenleme Başarısız.");
            }
        }
    }
}
