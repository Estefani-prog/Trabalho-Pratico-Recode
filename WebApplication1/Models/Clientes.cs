using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Clientes
    {
        // id int primaryKey
        // nome string
        // email string
        // telefone string
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }   
        public string email { get; set; }
        public string telefone { get; set; }

        
    }
}
