using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.Context;

public class ApplicationDbContext: DbContext
{
    public DbSet<Usuario> Usuario { get; set; }

    public DbSet<Factura> Factura { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
    {
    }

    
}
