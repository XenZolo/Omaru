using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using omaru.Data;
using Omaru.Models;

namespace Omaru.Controllers
{

    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly MockUsersRepo _repository = new MockUsersRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Users>> GetAllUsers()
        {
            var userItems = _repository.GetUsers();

            return Ok(userItems);
        }
    }
}