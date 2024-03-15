using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : Controller
    {
        IClassService _classService;

        public ClassesController(IClassService classService)
        {
            _classService = classService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _classService.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("getbyuid")]
        public IActionResult GetAll(int userId) 
        {
            var result = _classService.GetAllByUserId(userId);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("add")]
        public IActionResult Add(Class _class)
        {
            var result = _classService.Add(_class);
            if(result.Success)
            {
                return Ok(result);

            }
            return BadRequest();
        }
        [HttpPost("delete")]
        public IActionResult Delete(Class _class)
        {
            var result = _classService.Delete(_class);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest();
        }
        [HttpPost("update")]
        public IActionResult Update(Class _class)
        {
            var result = _classService.Update(_class);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest();
        }
    }

}
