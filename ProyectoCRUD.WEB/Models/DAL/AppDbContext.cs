using Microsoft.EntityFrameworkCore;
using ProyectoCRUD.WEB.Models.Entities;

namespace ProyectoCRUD.WEB.Models.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Maquinaria> Maquinas { get; set; }
    }
}
