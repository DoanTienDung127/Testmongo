using Microsoft.AspNetCore.Mvc;
using Testmongo.Models;
using Testmongo.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Testmongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public ActionResult<List<user>> Get()
        {
            return userService.Getall();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<user> Get(string id)
        {
            var user = userService.Get(id);
            if (user == null)
                return NotFound($"User with id = {id} not found");
            return user;
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult<user> Post([FromBody] user user)
        {
            userService.Create(user);
            return CreatedAtAction(nameof(Get), new { id = user.id }, user);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] user user)
        {
            var existingUser = userService.Get(id);
            if (existingUser == null)
                return NotFound($"User with id = {id} not found");
            userService.Update(id, user);
            return NoContent();

        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var user = userService.Get(id);
            if(user==null)
                return NotFound($"User with id = {id} not found");
            userService.Remove(user.id);
            return Ok($"User with id = {id} deleted");
        }
    }
}
