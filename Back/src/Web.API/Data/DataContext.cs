using Microsoft.EntityFrameworkCore;
using Web.API.Models;

namespace Web.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Evento> Eventos { get; set; }
    }
}