using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class LessonsController : Controller
    {
        ILessonService _lessonService;

        public LessonsController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll() 
        { 
            var result=_lessonService.GetAll();
            if (result.Success) 
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("add")]

        public IActionResult Add(Lesson lesson) 
        {
            var result = _lessonService.Add(lesson);
            if (result.Success) 
            { 
                return Ok(result); 
            }
            return BadRequest(result);
            
        }
        [HttpPost("delete")]

        public IActionResult Delete(Lesson lesson)
        {
            var result = _lessonService.Delete(lesson);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("update")]

        public IActionResult Update(Lesson lesson)
        {
            var result = _lessonService.Update(lesson);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

    }
}
