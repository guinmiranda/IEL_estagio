using IEL.Models;
using Microsoft.EntityFrameworkCore;

namespace IEL.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<EstudanteModel> Estudantes { get; set; }  
    }
}
