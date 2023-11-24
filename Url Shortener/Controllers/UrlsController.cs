using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Url_Shortener.Data;
using Url_Shortener.Helpers;
using Url_Shortener.Models;

//1-Crear una funcion que genere una cadena aleatoria de 6 caracteres alfanumericos
//2-Crear 2 endpoints en el controller, por ej, uno que genere un numero aleatorio y otro para redirigir a la URL original
//3-Cuando se ingrese la URL, generar una URL corta y guardarla en la base de datos, asegurarme si ya existe en la DB para evitar duplicados
//4-Logica para redirigir a la URL original. Cuando se ingrese una URL corta, buscar la URL original en la DB y redirigir al uruario a la original

namespace Url_Shortener.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrlsController : ControllerBase
    {
        private readonly UrlContext _context;

        public UrlsController(UrlContext context)
        {
            _context = context;
        }

        [HttpPost("shorten")]
        public IActionResult CreateNewUrl(string newurl, CategoriaEnum category)
        {
            var urlHelper = new UrlHelper();
            var urlEntity = new Entities.URL()
            {
                Url = newurl,
                ShortUrl = urlHelper.GetShortUrl(),
                Categoria = category
            };
            _context.Urls.Add(urlEntity);
            _context.SaveChanges();
            return Ok(urlEntity.ShortUrl);
        }



        [HttpGet("get")]
        public IActionResult GetUrl(string ClienteUrl)
        {
            var urlEntity = _context.Urls.FirstOrDefault(c => c.ShortUrl == ClienteUrl);  

            if(urlEntity == null)
            { 
                return NotFound("No se encontro la URL");
            }
            urlEntity.ContVisitas += 1;
            _context.SaveChanges();
            return Ok(urlEntity.Url);
        }

        [HttpGet("categoria")]
        public IActionResult GetCategory(CategoriaEnum Categoria)
        {
            var urlsFounded = _context.Urls.Where(x => x.Categoria == Categoria).ToList();

            var urlList = urlsFounded.Select(url => url.Url).ToList();
            return Ok(urlList);

        }

    };
    


}
