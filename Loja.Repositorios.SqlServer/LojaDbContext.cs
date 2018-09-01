using Loja.Dominio;
using Loja.Repositorios.SqlServer.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Repositorios.SqlServer
{
    //design pattern: Unit of Work
    public class LojaDbContext : DbContext
    {
        public LojaDbContext() : base("lojaConnectionString")
        {

        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new CategoriaConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
