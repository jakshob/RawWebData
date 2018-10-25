using DataService;
using Microsoft.AspNetCore.Mvc;

namespace Webservice.Controller
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : Microsoft.AspNetCore.Mvc.Controller
    {
        IDataService _dataService;

        public CategoriesController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            var data = _dataService.GetCategories();


            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var cat = _dataService.GetCategory(id);
            if (cat == null) return NotFound();
            return Ok(cat);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteData(int id)
        {
            var data = _dataService.DeleteCategory(id);
            return Ok(data);
        }
/*
        [HttpPost]
        public IActionResult AddCategory(CategoryPostAndPutModel category)
        {
            _dataService.CreateCategory(category.Name);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCategory(int id, CategoryPostAndPutModel category)
        {
            var cat = _dataService.UpdateCategory(id, category.Name);
            if (cat == null) return NotFound();
            return Ok(cat);
        }
        */
    }


}
