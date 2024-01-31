using ControleBiblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleBiblioteca.Controllers
{
    public class UsuarioController : Controller
    {
        List<UsuarioModel> usuarios = new List<UsuarioModel>();
        public IActionResult Index()
        {

            UsuarioModel us1 = new UsuarioModel();
            us1.Id = "001";
            us1.Nome = "João da Silva";
            us1.Login = "João";
            us1.Senha = "123";

            UsuarioModel us2 = new UsuarioModel();
            us2.Id = "002";
            us2.Nome = "Manoel Ferreira";
            us2.Login = "Manoel";
            us2.Senha = "123";

            UsuarioModel us3 = new UsuarioModel();
            us3.Id = "003";
            us3.Nome = "José Felisberto";
            us3.Login = "Zé";
            us3.Senha = "123";

            usuarios.Add(us1);
            usuarios.Add(us2);
            usuarios.Add(us3);

            return View(usuarios);
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
