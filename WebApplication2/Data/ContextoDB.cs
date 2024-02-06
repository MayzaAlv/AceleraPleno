using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class ContextoDB:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexao = "server=zapcidade.app;port=3306;database=livraria;uid=livraria;password=aceleranet";
            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));

        }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        public DbSet<LivroModel> Livros { get; set; }

        public DbSet<EmprestimoModel> Emprestimos { get; set; }
    }
}
