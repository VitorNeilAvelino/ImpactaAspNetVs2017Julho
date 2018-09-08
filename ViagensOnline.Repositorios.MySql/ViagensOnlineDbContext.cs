using MySql.Data.Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ViagensOnline.Dominio;

namespace ViagensOnline.Repositorios.MySql
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ViagensOnlineDbContext : DbContext
    {
        public ViagensOnlineDbContext() : base("ViagensOnlineConnectionString")
        {
          
        }

        public DbSet<Destino> Destinos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}