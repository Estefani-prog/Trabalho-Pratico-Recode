using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Viagens
    {
        [Key] // Primary Key
        public int Id { get; set; }
        public string Destino { get; set; }
        public int Quantidade { get; set; }


    }
}
