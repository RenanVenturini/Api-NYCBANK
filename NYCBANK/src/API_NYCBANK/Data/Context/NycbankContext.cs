using API_NYCBANK.Data.Context.Entidades;
using Microsoft.EntityFrameworkCore;

namespace API_NYCBANK.Data.Context
{
    public class NycbankContext : DbContext
    {
        public NycbankContext(DbContextOptions<NycbankContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
