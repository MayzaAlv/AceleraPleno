using ControleBiblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleBiblioteca.Controllers
{
    public class EmprestimoController : Controller
    {
        List<EmprestimoModel> emprestimos = new List<EmprestimoModel>();

        public IActionResult Index()
        {
            EmprestimoModel emprestimo1 = new EmprestimoModel()
            {
                Id = "001",
                Livro = "Crime e Castigo",
                Usuario = "Manoel Ferreira"
            };

            EmprestimoModel emprestimo2 = new EmprestimoModel()
            {
                Id = "002",
                Livro = "Declínio de um homem",
                Usuario = "João da Silva"
            };

            emprestimos.Add(emprestimo1);
            emprestimos.Add(emprestimo2);

            return View(emprestimos);
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
