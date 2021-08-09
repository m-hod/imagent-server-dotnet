using imagent_server.Models;
using imagent_server.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace imagent_server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController: ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = _userRepository.Get(id);
            if (user == null) return NotFound();
            return Ok(user);
        }
        
        [HttpPost]
        public ActionResult<User> CreateUser(User user)
        {
            return _userRepository.Add(user);
        }
         
        [HttpPut("{id}")]
        public ActionResult<User> UpdateUser(User user)
        {
            return _userRepository.Update(user);
        }

        [HttpDelete("{id}")]
        public void DeleteUser(User user)
        {
            _userRepository.Delete(user);
        }
    }
}