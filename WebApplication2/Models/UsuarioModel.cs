using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    [Table("Usuario")]
    public class UsuarioModel
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
