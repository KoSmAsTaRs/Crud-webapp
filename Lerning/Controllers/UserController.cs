using Lerning.Models;
using Lerning.Service;
using Microsoft.AspNetCore.Mvc;
namespace Lerning.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet(Name = "getall")]
        ActionResult<List<User>> GetAll() =>
            UserService.GetAll();

        [HttpGet("{Id}")]
        public ActionResult <User> Get(int id)
        {
            var user = UserService.Get(id); 
            if (user == null) 
                return NotFound();
            
            return Ok(user);
        }
        
    }
}
