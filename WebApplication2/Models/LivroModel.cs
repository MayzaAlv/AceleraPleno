using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    [Table("LIVRO")]
    public class LivroModel
    {
        [Key]
        public int COD { get; set; }

        public string LIVRO { get; set; }

        public int PG { get; set; }

        public decimal VALOR { get; set; }
    }
}
