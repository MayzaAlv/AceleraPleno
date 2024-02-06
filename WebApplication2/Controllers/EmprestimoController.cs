using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmprestimoController : Controller
    {
        Data.ContextoDB contexto = new Data.ContextoDB();

        public IActionResult Index()
        {
            var emprestimos = contexto.Emprestimos.ToList();

            return View(emprestimos);
        }


        [HttpPost]
        public IActionResult Index(EmprestimoModel em)
        {
            contexto.Emprestimos.Add(em);

            contexto.SaveChanges();

            var emprestimosDB = contexto.Emprestimos.ToList();

            return View(emprestimosDB);
        }

        public IActionResult Cadastra()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastra(EmprestimoModel em)
        {
            contexto.Add(em);
            return View(em);
        }
    }
}
