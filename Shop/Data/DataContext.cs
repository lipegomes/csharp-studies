using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Data
    {
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
            {

            }

    // DbSet busca a tabela Product no banco de dados
    public DbSet<Product> Products { get; set; }

    // DbSet busca a tabela Category no banco de dados
    public DbSet<Category> Categories { get; set; }

    // DbSet busca a tabela Users no banco de dados
    public DbSet<User> Users { get; set; }
    }
}