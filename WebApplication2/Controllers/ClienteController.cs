using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ClienteController : Controller
    {

        List<UsuarioModel> usas = new List<UsuarioModel> { };

        Data.ContextoDB contexto = new Data.ContextoDB();

        public IActionResult Index()
        {

            var usuariosBD = contexto.Usuarios.ToList();

            return View(usuariosBD);
        }

        [HttpPost]
        public IActionResult Index(UsuarioModel user)
        {

            contexto.Usuarios.Add(user);

            contexto.SaveChanges();

            var usuariosBD = contexto.Usuarios.ToList();

            return View(usuariosBD);
        }

        public IActionResult Cadastra()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Cadastra(UsuarioModel user)
        {
            usas.Add(user);
            return View(user);
        }




    }
}
