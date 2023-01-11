using BEComentarios.Models;
using Microsoft.EntityFrameworkCore;

namespace BEComentarios
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Comentario> Comentarios { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
