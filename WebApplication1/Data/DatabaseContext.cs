using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options){}
        public DbSet<Viagens> viagens { get; set; }
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Aquisicoes> adquirido { get; set; }
        public DbSet<WebApplication1.Models.Contato> Contato { get; set; }
    }

