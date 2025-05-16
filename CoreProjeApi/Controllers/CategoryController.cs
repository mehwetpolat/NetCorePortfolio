using CoreProjeApi.DAL.ApiContext;
using CoreProjeApi.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
            using var context = new Context();
            return Ok(context.Categories.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            using var context = new Context();
            var value = context.Categories.Find(id);

            if(value == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }
        }

        [HttpPost]
        public IActionResult CreateCategory(Category c)
        {
            using var context = new Context();
            context.Add(c);
            context.SaveChanges();
            return Created("", c);
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            using var context = new Context();
            var value = context.Categories.Find(id);

            if (value == null)
            {
                return NotFound();
            }
            else
            {
                context.Remove(value);
                context.SaveChanges();
                return NoContent();
            }
        }

        [HttpPut]
        public IActionResult UpdateCategory(Category c)
        {
            using var context = new Context();
            var value = context.Find<Category>(c.CategoryId);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                value.CategoryName = c.CategoryName;
                context.Update(value);
                context.SaveChanges();
                return NoContent();
            }
        }
    }
}
