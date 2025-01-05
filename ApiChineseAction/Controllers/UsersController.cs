using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiChineseAction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService _usersService)
        {
            this._userService = _usersService;
        }

        /// GET: api/<UsersController>
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _userService.getUsers();
        }

        // GET api/<<UsersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            User user = await _userService.getById(id);
            return user != null ? Ok(user) : NotFound();
        }

        // POST api/<<UsersController>
        [HttpPost]
        public async Task<ActionResult<User>> Post([FromBody] User user)
        {
            try
            {
                User newUser = await _userService.createUser(user);
                return CreatedAtAction(nameof(Get), new { id = newUser.Id }, newUser);
            }
            catch (Exception e)
            {
                return BadRequest();
            }

        }


        [HttpPost("login")]
        public async Task<ActionResult<User>> Login([FromQuery] string email, [FromQuery] string password)
        {
            try
            {
                User userLogin = await _userService.login(email, password);
                return userLogin==null?Unauthorized(): Ok(userLogin);
            }
            catch (Exception e)
            {
                return BadRequest();
            }

        }

        // PUT api/<<UsersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<User>> Put(int id, [FromBody] User userToUpdate)
        {
            User checkUser = await _userService.updateUser(id, userToUpdate);
            return checkUser != null ? Ok(checkUser) : BadRequest();
        }

        // DELETE api/<<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userService.deleteUser(id);
        }
    }
}
