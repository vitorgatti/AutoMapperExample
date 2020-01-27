using AutoMapper;
using AutoMapperExample.Models;
using AutoMapperExample.View;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperExample.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Result()
        {
            var user = new User(1, "Carlos", "Santos", "carlosantos@hotmail.com", null);
            UserViewModel viewModel = _mapper.Map<UserViewModel>(user);

            return Ok(viewModel);
        }
    }
}