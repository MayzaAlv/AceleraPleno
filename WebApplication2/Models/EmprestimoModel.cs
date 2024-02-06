using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    [Table("EMPRESTIMO")]
    public class EmprestimoModel
    {
        [Key]
        public int ID { get; set; }

        [Column("ID_USUARIO")]
        public string IDUSUARIO { get; set; }

        [Column("ID_LIVRO")]
        public int IDLIVRO { get; set; }

        [Column("DT_EMPRESTIMO")]
        public DateTime DTEMPRESTIMO { get; set; }

        [Column("DT_DEVOLUCAO")]
        public DateTime? DTDEVOLUCAO { get; set; }

        public UsuarioModel Usuario(string id)
        {
            Data.ContextoDB contexto = new Data.ContextoDB();

            try { 
            var usuario = contexto.Usuarios.Where(u => u.Id == id).First();

                return usuario;
            }
            catch
            {
                return new UsuarioModel();
            }
            
        }

        public LivroModel Livro(int cod)
        {
            Data.ContextoDB contexto = new Data.ContextoDB();

            try
            {
                var livro = contexto.Livros.Where(u => u.COD == cod).First();

                return livro;
            }
            catch
            {
                return new LivroModel();
            }

        }
    }
}
