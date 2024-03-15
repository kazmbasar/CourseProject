using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersImagesController : ControllerBase
    {
        private IUserImagesService _userImagesService;

        public UsersImagesController(IUserImagesService userImagesService)
        {
            _userImagesService = userImagesService;
        }
        [HttpPost("add")]
        public IActionResult Add([FromForm]IFormFile file, [FromForm] UserImage userImage)
        {
            var result = _userImagesService.Add(file, userImage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

    }
}
