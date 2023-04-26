using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using WebAPI.Context;
using WebAPI.Entity;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsuarioController : Controller
    {
        private readonly AppDbContext context;
        public UsuarioController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return context.Usuario.ToList().Where(x => x.Id <= 100);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Usuario> Get(int Id)
        {
            var usuario = context.Usuario.Find(Id);
            if (usuario == null)
                return NotFound();

            return usuario;
        }
    }
}
