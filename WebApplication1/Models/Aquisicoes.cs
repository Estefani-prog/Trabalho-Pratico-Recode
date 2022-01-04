using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Aquisicoes
    {
         // id int primaryKey
         // idViagem int
         // idCliente int
         // Quantidade int
         // DataCheckIn string
         // DataCheckOut string
        [Key]
        public int Id { get; set; }
        public int IdViagem  { get; set;}
        public int IdCliente  { get; set; }
        public int Quantidade { get; set; }
        public string DataCheckin { get; set; }
        public string DataCheckOut { get; set;}

    }
}
