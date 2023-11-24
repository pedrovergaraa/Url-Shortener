using AgendaApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Url_Shortener.Data;
using Url_Shortener.Entities;
using Url_Shortener.Models;
using Url_Shortener.Services;

namespace Url_Shortener.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //Este post es para validar el usuario 
        //Se tiene que verificar con el authentication
        //Y una vez que haya hecho todo eso, puede ingresa

        private readonly UrlContext _context;

        private readonly IUserService _userService;
        public UserController(IUserService userRepository)
        {
            _userService = userRepository;
        }
        [HttpPost]
        public IActionResult CreateUser(UserForCreationDto dto)
        {
            try
            {
                _userService.Create(dto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Created("Created", dto);
        }

    }
}
