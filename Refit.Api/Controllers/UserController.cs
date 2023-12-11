using Microsoft.AspNetCore.Mvc;
using Refit.Api.Models;

namespace Refit.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            List<User> users = new List<User>()
            {
                new User() { UserId = 1,FirstName = "Sanjarbek",LastName = "Berdikulov"},
                new User() { UserId = 2,FirstName = "Alisher",LastName = "Almatov"},
                new User() { UserId = 3,FirstName = "Ahror",LastName = "Ummadjonov"},
                new User() { UserId = 4,FirstName = "Diyorbek",LastName = "Berdiyev"},
                new User() { UserId = 5,FirstName = "Sherdor",LastName = "Saydullayev"}
            };

            return Ok(users);
        }
    }
}