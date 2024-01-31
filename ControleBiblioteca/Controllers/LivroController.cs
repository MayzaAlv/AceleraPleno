using ControleBiblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleBiblioteca.Controllers
{
    public class LivroController : Controller
    {
        List<LivroModel> livros = new List<LivroModel>();

        public IActionResult Index()
        {
            LivroModel livro1 = new LivroModel()
            {
                Id = "001",
                Nome = "Crime e Castigo",
                Autor = "Fiódor Dostoiévski"
            };

            LivroModel livro2 = new LivroModel()
            {
                Id = "002",
                Nome = "Declínio de um homem",
                Autor = "Osamu Dazai"
            };

            livros.Add(livro1);
            livros.Add(livro2);

            return View(livros);
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
