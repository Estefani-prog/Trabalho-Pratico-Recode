using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Contato
    {
        // id int
        // nome string
        // email string
        // mensagem string

        [Key] // Primary Key
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string mensagem { get; set; }

        
    }
}
