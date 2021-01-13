using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Omaru.Data;
using Omaru.Models;

namespace Omaru.Controllers
{

    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IOmaruRepo _repository;

        public UsersController(IOmaruRepo repository)
        {
            _repository = repository;
         }

        //private readonly MockUsersRepo _repository = new MockUsersRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Users>> GetAllUsers()
        {
            var userItems = _repository.GetAllUsers();

            return Ok(userItems);
        }
    }
}