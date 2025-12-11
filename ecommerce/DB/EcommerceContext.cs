using ecommerce.Models.Usuarios;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.DB
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
